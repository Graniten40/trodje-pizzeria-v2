import { useState } from "react";
import { useCart } from "../cart/CartContext";
import CheckoutModal from "./CheckoutModal";

function formatPrice(price: number) {
  return new Intl.NumberFormat("sv-SE", {
    style: "currency",
    currency: "SEK",
    minimumFractionDigits: 0,
    maximumFractionDigits: 0,
  }).format(price);
}

export default function CartDrawer() {
  const {
    items,
    totalItems,
    totalPrice,
    updateItemQuantity,
    removeItem,
    clearCart,
  } = useCart();

  const [
    showCheckout,
    setShowCheckout,
  ] = useState(false);

  return (
    <>
      <aside className="cart-sidebar">
        <div className="cart-sidebar__header">
          <h2>Din kundvagn</h2>

          <p>
            {totalItems}{" "}
            {totalItems === 1
              ? "vara"
              : "varor"}
          </p>
        </div>

        {items.length === 0 ? (
          <div className="cart-sidebar__empty">
            <div className="cart-sidebar__empty-icon">
              🛒
            </div>

            <p>
              Din kundvagn är tom.
            </p>
          </div>
        ) : (
          <>
            <div className="cart-sidebar__items">
              {items.map((item) => (
                <article
                  key={item.key}
                  className="cart-item"
                >
                  <div className="cart-item__top">
                    <div>
                      <h3>
                        {item.quantity} ×{" "}
                        {item.name}
                      </h3>

                      {item.variant && (
                        <p>
                          {item.variant.name}
                        </p>
                      )}
                    </div>

                    <strong>
                      {formatPrice(
                        item.totalPrice
                      )}
                    </strong>
                  </div>

                  {item.extras.length > 0 && (
                    <div className="cart-item__extras">
                      {item.extras.map(
                        (extra) => (
                          <span
                            key={extra.id}
                          >
                            + {extra.name}

                            {extra.priceChange !==
                              0 && (
                              <>
                                {" "}
                                (
                                {extra.priceChange >
                                0
                                  ? "+"
                                  : ""}
                                {extra.priceChange}{" "}
                                kr)
                              </>
                            )}
                          </span>
                        )
                      )}
                    </div>
                  )}

                  {item.comment && (
                    <p className="cart-item__comment">
                      Kommentar:{" "}
                      {item.comment}
                    </p>
                  )}

                  <div className="cart-item__bottom">
                    <div className="cart-item__quantity">
                      <button
                        type="button"
                        onClick={() =>
                          updateItemQuantity(
                            item.key,
                            item.quantity -
                              1
                          )
                        }
                      >
                        −
                      </button>

                      <strong>
                        {item.quantity}
                      </strong>

                      <button
                        type="button"
                        onClick={() =>
                          updateItemQuantity(
                            item.key,
                            item.quantity +
                              1
                          )
                        }
                      >
                        +
                      </button>
                    </div>

                    <button
                      type="button"
                      className="cart-item__remove"
                      onClick={() =>
                        removeItem(
                          item.key
                        )
                      }
                    >
                      Ta bort
                    </button>
                  </div>

                  <div className="cart-item__unit-price">
                    {formatPrice(
                      item.unitPrice
                    )}{" "}
                    / st
                  </div>
                </article>
              ))}
            </div>

            <div className="cart-sidebar__summary">
              <div>
                <span>
                  Antal
                </span>

                <strong>
                  {totalItems}
                </strong>
              </div>

              <div className="cart-sidebar__total">
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

            <button
              type="button"
              className="cart-sidebar__checkout"
              onClick={() =>
                setShowCheckout(true)
              }
            >
              GÅ TILL KASSAN
            </button>

            <button
              type="button"
              className="cart-sidebar__clear"
              onClick={clearCart}
            >
              Töm kundvagnen
            </button>
          </>
        )}
      </aside>

      {showCheckout && (
        <CheckoutModal
          onClose={() =>
            setShowCheckout(false)
          }
        />
      )}
    </>
  );
}