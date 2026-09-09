import {
  useState,
} from "react";

import { useCart } from "../cart/CartContext";

function formatPrice(
  price: number
) {
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

export default function CartDrawer() {
  const {
    items,
    totalItems,
    totalPrice,
    removeItem,
    clearCart,
  } = useCart();

  const [
    isOpen,
    setIsOpen,
  ] = useState(false);

  if (items.length === 0) {
    return null;
  }

  return (
    <>
      <button
        type="button"
        className="cart-floating-button"
        onClick={() =>
          setIsOpen(true)
        }
      >
        <span>
          🛒 Varukorg
        </span>

        <strong>
          {totalItems}
        </strong>

        <span>
          {formatPrice(
            totalPrice
          )}
        </span>
      </button>

      {isOpen && (
        <div
          className="cart-drawer-backdrop"
          onClick={() =>
            setIsOpen(false)
          }
        >
          <aside
            className="cart-drawer"
            onClick={(event) =>
              event.stopPropagation()
            }
          >
            <div className="cart-drawer__header">
              <div>
                <p className="section-eyebrow">
                  DIN BESTÄLLNING
                </p>

                <h2>
                  Varukorg
                </h2>
              </div>

              <button
                type="button"
                className="cart-drawer__close"
                onClick={() =>
                  setIsOpen(false)
                }
                aria-label="Stäng varukorgen"
              >
                ×
              </button>
            </div>

            <div className="cart-drawer__items">
              {items.map(
                (item) => (
                  <article
                    key={
                      item.key
                    }
                    className="cart-item"
                  >
                    <div className="cart-item__top">
                      <div>
                        <h3>
                          {
                            item.quantity
                          }
                          ×{" "}
                          {
                            item.name
                          }
                        </h3>

                        {item.variant && (
                          <p>
                            {
                              item
                                .variant
                                .name
                            }
                          </p>
                        )}
                      </div>

                      <strong>
                        {formatPrice(
                          item.totalPrice
                        )}
                      </strong>
                    </div>

                    {item.extras.length >
                      0 && (
                      <div className="cart-item__extras">
                        {item.extras.map(
                          (
                            extra
                          ) => (
                            <span
                              key={
                                extra.id
                              }
                            >
                              +{" "}
                              {
                                extra.name
                              }

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
                        {
                          item.comment
                        }
                      </p>
                    )}

                    <div className="cart-item__bottom">
                      <span>
                        {formatPrice(
                          item.unitPrice
                        )}{" "}
                        / st
                      </span>

                      <button
                        type="button"
                        onClick={() =>
                          removeItem(
                            item.key
                          )
                        }
                      >
                        Ta bort
                      </button>
                    </div>
                  </article>
                )
              )}
            </div>

            <div className="cart-drawer__summary">
              <div>
                <span>
                  Antal
                </span>

                <strong>
                  {totalItems}
                </strong>
              </div>

              <div className="cart-drawer__total">
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

            <div className="cart-drawer__actions">
              <button
                type="button"
                className="cart-drawer__clear"
                onClick={clearCart}
              >
                Töm varukorgen
              </button>

              <button
                type="button"
                className="cart-drawer__checkout"
                onClick={() => {
                  console.log(
                    "Gå till checkout"
                  );
                }}
              >
                GÅ TILL KASSAN
              </button>
            </div>
          </aside>
        </div>
      )}
    </>
  );
}