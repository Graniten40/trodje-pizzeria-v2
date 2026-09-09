import {
  useCallback,
  useEffect,
  useRef,
  useState,
} from "react";

import OrderCard from "../components/OrderCard";

import {
  getActiveOrders,
  getOrders,
  updateOrderStatus,
} from "../services/ordersApi";

import type {
  Order,
  OrderStatus,
} from "../types/orders";

const RESTAURANT_ID = 1;

const POLLING_START_HOUR = 10;
const POLLING_END_HOUR = 23;

const POLLING_INTERVAL_MS = 5000;
const SCHEDULE_CHECK_INTERVAL_MS = 30000;

function isPollingTime() {
  const now = new Date();

  const minutesSinceMidnight =
    now.getHours() * 60 +
    now.getMinutes();

  const startMinutes =
    POLLING_START_HOUR * 60;

  const endMinutes =
    POLLING_END_HOUR * 60;

  return (
    minutesSinceMidnight >= startMinutes &&
    minutesSinceMidnight < endMinutes
  );
}

export default function OrdersPage() {
  const [orders, setOrders] =
    useState<Order[]>([]);

  const [
    historyOrders,
    setHistoryOrders,
  ] = useState<Order[]>([]);

  const [loading, setLoading] =
    useState(true);

  const [error, setError] =
    useState<string | null>(null);

  const [
    soundEnabled,
    setSoundEnabled,
  ] = useState(false);

  const [
    showHistory,
    setShowHistory,
  ] = useState(false);

  const [
    pollingActive,
    setPollingActive,
  ] = useState(
    isPollingTime()
  );

  const knownOrderIds =
    useRef<Set<number>>(
      new Set()
    );

  const audioContextRef =
    useRef<AudioContext | null>(
      null
    );

  const playNewOrderSound =
    useCallback(() => {
      const audioContext =
        audioContextRef.current;

      if (
        !audioContext ||
        audioContext.state !==
          "running"
      ) {
        return;
      }

      const now =
        audioContext.currentTime;

      const playTone = (
        frequency: number,
        startDelay: number,
        duration: number
      ) => {
        const oscillator =
          audioContext.createOscillator();

        const gain =
          audioContext.createGain();

        oscillator.type = "sine";

        oscillator.frequency.value =
          frequency;

        gain.gain.setValueAtTime(
          0.0001,
          now + startDelay
        );

        gain.gain
          .exponentialRampToValueAtTime(
            1,
            now +
              startDelay +
              0.02
          );

        gain.gain
          .exponentialRampToValueAtTime(
            0.0001,
            now +
              startDelay +
              duration
          );

        oscillator.connect(gain);

        gain.connect(
          audioContext.destination
        );

        oscillator.start(
          now + startDelay
        );

        oscillator.stop(
          now +
            startDelay +
            duration
        );
      };

      playTone(
        880,
        0,
        0.65
      );

      playTone(
        1320,
        0.18,
        0.75
      );

      playTone(
        1760,
        0.36,
        0.8
      );
    }, []);

  async function enableSound() {
    try {
      const AudioContextClass =
        window.AudioContext ||
        (
          window as typeof window & {
            webkitAudioContext?:
              typeof AudioContext;
          }
        ).webkitAudioContext;

      if (!AudioContextClass) {
        setError(
          "Webbläsaren stödjer inte orderljud."
        );

        return;
      }

      const audioContext =
        audioContextRef.current ??
        new AudioContextClass();

      audioContextRef.current =
        audioContext;

      await audioContext.resume();

      setSoundEnabled(true);
      setError(null);

      playNewOrderSound();
    } catch {
      setError(
        "Kunde inte aktivera orderljudet."
      );
    }
  }

  async function loadHistoryOrders() {
    try {
      const data =
        await getOrders(
          RESTAURANT_ID
        );

      const history =
        data.filter(
          (order) =>
            order.status ===
              "Collected" ||
            order.status ===
              "Rejected" ||
            order.status ===
              "Cancelled"
        );

      setHistoryOrders(
        history
      );
    } catch {
      setError(
        "Kunde inte hämta orderhistoriken."
      );
    }
  }

  const loadOrders =
    useCallback(
      async () => {
        try {
          setError(null);

          const data =
            await getActiveOrders(
              RESTAURANT_ID
            );

          const previousIds =
            knownOrderIds.current;

          if (
            previousIds.size >
            0
          ) {
            const hasNewOrder =
              data.some(
                (order) =>
                  order.status ===
                    "New" &&
                  !previousIds.has(
                    order.id
                  )
              );

            if (
              hasNewOrder &&
              soundEnabled
            ) {
              playNewOrderSound();
            }
          }

          knownOrderIds.current =
            new Set(
              data.map(
                (order) =>
                  order.id
              )
            );

          setOrders(data);
        } catch {
          setError(
            "Kunde inte hämta beställningarna."
          );
        } finally {
          setLoading(false);
        }
      },
      [
        soundEnabled,
        playNewOrderSound,
      ]
    );

  /*
   * Kontrollerar om klockan
   * är mellan 10:00 och 11:00.
   */
  useEffect(() => {
    function updatePollingState() {
      const active =
        isPollingTime();

      setPollingActive(
        active
      );
    }

    updatePollingState();

    const scheduleInterval =
      window.setInterval(
        updatePollingState,
        SCHEDULE_CHECK_INTERVAL_MS
      );

    return () => {
      window.clearInterval(
        scheduleInterval
      );
    };
  }, []);

  /*
   * Automatisk polling.
   *
   * Kör endast mellan
   * 10:00 och 11:00.
   */
  useEffect(() => {
    if (!pollingActive) {
      setLoading(false);

      return;
    }

    void loadOrders();

    const pollingInterval =
      window.setInterval(
        () => {
          void loadOrders();
        },
        POLLING_INTERVAL_MS
      );

    return () => {
      window.clearInterval(
        pollingInterval
      );
    };
  }, [
    pollingActive,
    loadOrders,
  ]);

  async function handleStatusChange(
    orderId: number,
    status: OrderStatus
  ) {
    try {
      setError(null);

      await updateOrderStatus(
        orderId,
        status
      );

      await loadOrders();

      if (showHistory) {
        await loadHistoryOrders();
      }
    } catch {
      setError(
        "Kunde inte uppdatera beställningen."
      );
    }
  }

  async function toggleHistory() {
    if (!showHistory) {
      await loadHistoryOrders();
    }

    setShowHistory(
      (current) =>
        !current
    );
  }

  if (loading) {
    return (
      <main className="orders-page">
        <h1>
          Beställningar
        </h1>

        <p>
          Laddar beställningar...
        </p>
      </main>
    );
  }

  return (
    <main className="orders-page">
      <header className="orders-page__header">
        <div>
          <h1>
            Beställningar
          </h1>

          <p>
            Aktiva beställningar:{" "}
            {orders.length}
          </p>

          <p
            className={
              pollingActive
                ? "orders-page__polling orders-page__polling--active"
                : "orders-page__polling"
            }
          >
            {pollingActive
              ? "● Automatisk ordersökning aktiv"
              : "Automatisk ordersökning pausad"}
          </p>

          <small>
            Automatisk sökning:
            10:00–23:00
          </small>
        </div>

        <div className="orders-page__header-actions">
          <button
            type="button"
            className={
              soundEnabled
                ? "sound-button sound-button--enabled"
                : "sound-button"
            }
            onClick={
              enableSound
            }
          >
            {soundEnabled
              ? "🔔 Ljud aktiverat"
              : "🔔 Aktivera orderljud"}
          </button>

          {soundEnabled && (
            <button
              type="button"
              onClick={
                playNewOrderSound
              }
            >
              Testa ljudet
            </button>
          )}

          <button
            type="button"
            onClick={() => {
              void loadOrders();

              if (
                showHistory
              ) {
                void loadHistoryOrders();
              }
            }}
          >
            Uppdatera
          </button>
        </div>
      </header>

      {error && (
        <p className="orders-page__error">
          {error}
        </p>
      )}

      {orders.length === 0 ? (
        <section className="orders-page__empty">
          <h2>
            Inga aktiva
            beställningar
          </h2>

          <p>
            {pollingActive
              ? "Nya beställningar visas här automatiskt."
              : "Automatisk ordersökning körs mellan 10:00 och 23:00."}
          </p>
        </section>
      ) : (
        <section className="orders-page__list">
          {orders.map(
            (order) => (
              <OrderCard
                key={order.id}
                order={order}
                onStatusChange={
                  handleStatusChange
                }
              />
            )
          )}
        </section>
      )}

      <section className="orders-history">
        <button
          type="button"
          className="orders-history__toggle"
          onClick={() => {
            void toggleHistory();
          }}
        >
          {showHistory
            ? "▲ Dölj orderhistorik"
            : "▼ Visa orderhistorik"}
        </button>

        {showHistory && (
          <div className="orders-history__content">
            {historyOrders.length ===
            0 ? (
              <p>
                Det finns inga
                avslutade
                beställningar.
              </p>
            ) : (
              <>
                <p className="orders-history__count">
                  Avslutade
                  beställningar:{" "}
                  {
                    historyOrders.length
                  }
                </p>

                <div className="orders-page__list">
                  {historyOrders.map(
                    (order) => (
                      <OrderCard
                        key={
                          order.id
                        }
                        order={
                          order
                        }
                        onStatusChange={
                          handleStatusChange
                        }
                      />
                    )
                  )}
                </div>
              </>
            )}
          </div>
        )}
      </section>
    </main>
  );
}