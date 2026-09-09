import {
  useMemo,
  useState,
} from "react";

import { useCart } from "../cart/CartContext";

import {
  createOrder,
} from "../services/ordersApi";

interface CheckoutModalProps {
  onClose: () => void;
}

const RESTAURANT_ID = 1;

function formatPrice(price: number) {
  return new Intl.NumberFormat(
    "sv-SE",
    {
      style: "currency",
      currency: "SEK",
      minimumFractionDigits: 0,
      maximumFractionDigits: 0,
    }
  ).format(price);
}

export default function CheckoutModal({
  onClose,
}: CheckoutModalProps) {
  const {
    items,
    totalItems,
    totalPrice,
    clearCart,
  } = useCart();

  const [name, setName] =
    useState("");

  const [phone, setPhone] =
    useState("");

  const [email, setEmail] =
    useState("");

  const [comment, setComment] =
    useState("");

  const [error, setError] =
    useState<string | null>(null);

  const [isSubmitting, setIsSubmitting] =
    useState(false);

  const [
    orderCreated,
    setOrderCreated,
  ] = useState(false);

  const [orderId, setOrderId] =
    useState<number | null>(null);

  const canSubmit =
    useMemo(() => {
      return (
        items.length > 0 &&
        name.trim().length >= 2 &&
        phone.trim().length >= 6 &&
        !isSubmitting
      );
    }, [
      items,
      name,
      phone,
      isSubmitting,
    ]);

  async function handleSubmit(
    event: React.FormEvent
  ) {
    event.preventDefault();

    if (!canSubmit) {
      setError(
        "Fyll i namn och telefonnummer."
      );

      return;
    }

    setError(null);
    setIsSubmitting(true);

    try {
      const payload = {
        restaurantId:
          RESTAURANT_ID,

        customerName:
          name.trim(),

        phone:
          phone.trim(),

        email:
          email.trim()
            ? email.trim()
            : null,

        comment:
          comment.trim()
            ? comment.trim()
            : null,

        items:
          items.map((item) => ({
            menuItemId:
              item.menuItemId,

            quantity:
              item.quantity,

            menuItemVariantId:
              item.variant?.id ??
              null,

            menuItemExtraIds:
              item.extras.map(
                (extra) =>
                  extra.id
              ),

            comment:
              item.comment,
          })),
      };

      const createdOrder =
        await createOrder(payload);

      if (
        createdOrder &&
        typeof createdOrder.id ===
          "number"
      ) {
        setOrderId(
          createdOrder.id
        );
      }

      clearCart();
      setOrderCreated(true);
    } catch (caughtError) {
      console.error(
        caughtError
      );

      setError(
        "Beställningen kunde inte skickas. Försök igen."
      );
    } finally {
      setIsSubmitting(false);
    }
  }

  if (orderCreated) {
    return (
      <div
        className="checkout-backdrop"
        onClick={onClose}
      >
        <section
          className="checkout-modal"
          onClick={(event) =>
            event.stopPropagation()
          }
        >
          <div className="checkout-success">
            <div className="checkout-success__icon">
              ✓
            </div>

            <h2>
              Beställningen är skickad!
            </h2>

            {orderId !== null && (
              <p>
                Ordernummer:{" "}
                <strong>
                  #{orderId}
                </strong>
              </p>
            )}

            <p>
              Din beställning har
              skickats till Trödje
              Pizzeria.
            </p>

            <button
              type="button"
              className="checkout-modal__submit"
              onClick={onClose}
            >
              KLAR
            </button>
          </div>
        </section>
      </div>
    );
  }

  return (
    <div
      className="checkout-backdrop"
      onClick={onClose}
    >
      <section
        className="checkout-modal"
        role="dialog"
        aria-modal="true"
        aria-labelledby="checkout-title"
        onClick={(event) =>
          event.stopPropagation()
        }
      >
        <div className="checkout-modal__header">
          <div>
            <p className="section-eyebrow">
              BESTÄLLNING
            </p>

            <h2 id="checkout-title">
              Kassa
            </h2>
          </div>

          <button
            type="button"
            className="checkout-modal__close"
            onClick={onClose}
            aria-label="Stäng kassan"
          >
            ×
          </button>
        </div>

        <form
          onSubmit={handleSubmit}
          className="checkout-modal__body"
        >
          <div className="checkout-form">
            <div className="checkout-form__field">
              <label htmlFor="checkout-name">
                Namn *
              </label>

              <input
                id="checkout-name"
                type="text"
                value={name}
                onChange={(event) =>
                  setName(
                    event.target.value
                  )
                }
                placeholder="För- och efternamn"
                autoComplete="name"
              />
            </div>

            <div className="checkout-form__field">
              <label htmlFor="checkout-phone">
                Telefon *
              </label>

              <input
                id="checkout-phone"
                type="tel"
                value={phone}
                onChange={(event) =>
                  setPhone(
                    event.target.value
                  )
                }
                placeholder="07X-XXX XX XX"
                autoComplete="tel"
              />
            </div>

            <div className="checkout-form__field">
              <label htmlFor="checkout-email">
                E-post
                <span>
                  Valfritt
                </span>
              </label>

              <input
                id="checkout-email"
                type="email"
                value={email}
                onChange={(event) =>
                  setEmail(
                    event.target.value
                  )
                }
                placeholder="namn@exempel.se"
                autoComplete="email"
              />
            </div>

            <div className="checkout-form__field">
              <label htmlFor="checkout-comment">
                Kommentar till beställningen
              </label>

              <textarea
                id="checkout-comment"
                value={comment}
                onChange={(event) =>
                  setComment(
                    event.target.value
                  )
                }
                placeholder="Exempel: ring när maten är klar..."
                rows={3}
              />
            </div>
          </div>

          <div className="checkout-order">
            <h3>
              Din beställning
            </h3>

            <p className="checkout-order__count">
              {totalItems}{" "}
              {totalItems === 1
                ? "vara"
                : "varor"}
            </p>

            <div className="checkout-order__items">
              {items.map((item) => (
                <article
                  key={item.key}
                  className="checkout-order-item"
                >
                  <div className="checkout-order-item__top">
                    <strong>
                      {item.quantity} ×{" "}
                      {item.name}
                    </strong>

                    <strong>
                      {formatPrice(
                        item.totalPrice
                      )}
                    </strong>
                  </div>

                  {item.variant && (
                    <span>
                      {
                        item.variant
                          .name
                      }
                    </span>
                  )}

                  {item.extras.map(
                    (extra) => (
                      <span
                        key={
                          extra.id
                        }
                      >
                        +{" "}
                        {extra.name}
                      </span>
                    )
                  )}

                  {item.comment && (
                    <span className="checkout-order-item__comment">
                      Kommentar:{" "}
                      {
                        item.comment
                      }
                    </span>
                  )}
                </article>
              ))}
            </div>

            <div className="checkout-order__total">
              <span>
                Totalt
              </span>

              <strong>
                {formatPrice(
                  totalPrice
                )}
              </strong>
            </div>
          </div>

          {error && (
            <p className="checkout-modal__error">
              {error}
            </p>
          )}

          <div className="checkout-modal__footer">
            <button
              type="button"
              className="checkout-modal__back"
              disabled={
                isSubmitting
              }
              onClick={onClose}
            >
              TILLBAKA
            </button>

            <button
              type="submit"
              className="checkout-modal__submit"
              disabled={!canSubmit}
            >
              {isSubmitting
                ? "SKICKAR..."
                : `SKICKA BESTÄLLNING · ${formatPrice(
                    totalPrice
                  )}`}
            </button>
          </div>
        </form>
      </section>
    </div>
  );
}