import type { Order, OrderStatus } from "../types/orders";

interface OrderCardProps {
  order: Order;
  onStatusChange: (
    orderId: number,
    status: OrderStatus
  ) => Promise<void>;
}

const statusLabels: Record<OrderStatus, string> = {
  New: "Ny",
  Confirmed: "Bekräftad",
  Preparing: "Tillagas",
  ReadyForPickup: "Klar för hämtning",
  Collected: "Hämtad",
  Rejected: "Avvisad",
  Cancelled: "Avbruten",
};

const nextStatus: Partial<
  Record<OrderStatus, OrderStatus>
> = {
  New: "Confirmed",
  Confirmed: "Preparing",
  Preparing: "ReadyForPickup",
  ReadyForPickup: "Collected",
};

export default function OrderCard({
  order,
  onStatusChange,
}: OrderCardProps) {
  const next = nextStatus[order.status];

  return (
    <article className={`order-card order-card--${order.status}`}>
      <header className="order-card__header">
        <div>
          <h2>Order #{order.id}</h2>
          <p>
            {order.customerName} · {order.phone}
          </p>
        </div>

        <strong className="order-card__status">
          {statusLabels[order.status]}
        </strong>
      </header>

      {order.comment && (
        <p className="order-card__comment">
          Orderkommentar: {order.comment}
        </p>
      )}

      <div className="order-card__items">
        {order.items.map((item) => (
          <div
            key={item.id}
            className="order-card__item"
          >
            <div>
              <strong>
                {item.quantity} × {item.name}
              </strong>

              {item.variant && (
                <p>
                  Val: {item.variant.name}
                </p>
              )}

              {item.extras.length > 0 && (
                <ul>
                  {item.extras.map((extra) => (
                    <li key={extra.id}>
                      {extra.name}
                      {extra.priceChange !== 0 &&
                        ` ${
                          extra.priceChange > 0
                            ? "+"
                            : ""
                        }${extra.priceChange} kr`}
                    </li>
                  ))}
                </ul>
              )}

              {item.comment && (
                <p>
                  Kommentar: {item.comment}
                </p>
              )}
            </div>

            <strong>
              {item.totalPrice} kr
            </strong>
          </div>
        ))}
      </div>

      <footer className="order-card__footer">
        <strong>
          Totalt: {order.totalPrice} kr
        </strong>

        <div className="order-card__actions">
          {next && (
            <button
              type="button"
              onClick={() =>
                onStatusChange(order.id, next)
              }
            >
              {statusLabels[next]}
            </button>
          )}

          {order.status === "New" && (
            <button
              type="button"
              onClick={() =>
                onStatusChange(
                  order.id,
                  "Rejected"
                )
              }
            >
              Avvisa
            </button>
          )}

          {order.status !== "Collected" &&
            order.status !== "Rejected" &&
            order.status !== "Cancelled" && (
              <button
                type="button"
                onClick={() =>
                  onStatusChange(
                    order.id,
                    "Cancelled"
                  )
                }
              >
                Avbryt
              </button>
            )}
        </div>
      </footer>
    </article>
  );
}