import {
  useEffect,
  useMemo,
  useState,
} from "react";

import { useCart } from "../cart/CartContext";

import type {
  MenuExtra,
  MenuItem,
  MenuVariant,
} from "../types/menu";

interface ProductModalProps {
  item: MenuItem | null;
  onClose: () => void;
}

function formatPrice(price: number) {
  return new Intl.NumberFormat("sv-SE", {
    style: "currency",
    currency: "SEK",
    minimumFractionDigits: 0,
    maximumFractionDigits: 0,
  }).format(price);
}

export default function ProductModal({
  item,
  onClose,
}: ProductModalProps) {
  const { addItem } = useCart();

  const [quantity, setQuantity] =
    useState(1);

  const [selectedVariantId, setSelectedVariantId] =
    useState<number | null>(null);

  const [selectedExtraIds, setSelectedExtraIds] =
    useState<Set<number>>(new Set());

  const [comment, setComment] =
    useState("");

  useEffect(() => {
    if (!item) {
      return;
    }

    setQuantity(1);
    setSelectedExtraIds(new Set());
    setComment("");

    if (item.variants.length === 1) {
      setSelectedVariantId(
        item.variants[0].id
      );
    } else {
      setSelectedVariantId(null);
    }
  }, [item]);

  const selectedVariant =
    useMemo<MenuVariant | null>(() => {
      if (
        !item ||
        selectedVariantId === null
      ) {
        return null;
      }

      return (
        item.variants.find(
          (variant) =>
            variant.id ===
            selectedVariantId
        ) ?? null
      );
    }, [
      item,
      selectedVariantId,
    ]);

  const selectedExtras =
    useMemo<MenuExtra[]>(() => {
      if (!item) {
        return [];
      }

      return item.extras.filter(
        (extra) =>
          selectedExtraIds.has(
            extra.id
          )
      );
    }, [
      item,
      selectedExtraIds,
    ]);

  const unitPrice =
    useMemo(() => {
      if (!item) {
        return 0;
      }

      const basePrice =
        selectedVariant?.price ??
        item.price ??
        0;

      const extrasPrice =
        selectedExtras.reduce(
          (sum, extra) =>
            sum +
            extra.priceChange,
          0
        );

      return (
        basePrice +
        extrasPrice
      );
    }, [
      item,
      selectedVariant,
      selectedExtras,
    ]);

  const totalPrice =
    unitPrice * quantity;

  if (!item) {
    return null;
  }

  const variantRequired =
    item.price === null &&
    item.variants.length > 0;

  const canAdd =
    !variantRequired ||
    selectedVariant !== null;

  function toggleExtra(
    extraId: number
  ) {
    setSelectedExtraIds(
      (current) => {
        const next =
          new Set(current);

        if (next.has(extraId)) {
          next.delete(extraId);
        } else {
          next.add(extraId);
        }

        return next;
      }
    );
  }

  function handleAdd() {
    if (!item || !canAdd) {
      return;
    }

    console.log(
      "PRODUCT MODAL - lägger till:",
      item.name,
      quantity,
      selectedVariant,
      selectedExtras
    );

    addItem({
      menuItem: item,
      quantity,
      variant: selectedVariant,
      extras: selectedExtras,
      comment:
        comment.trim() !== ""
          ? comment.trim()
          : null,
    });

    onClose();
  }

  return (
    <div
      className="product-modal-backdrop"
      onClick={onClose}
    >
      <section
        className="product-modal"
        role="dialog"
        aria-modal="true"
        aria-labelledby="product-modal-title"
        onClick={(event) =>
          event.stopPropagation()
        }
      >
        <div className="product-modal__header">
          <div>
            <p className="section-eyebrow">
              Lägg till
            </p>

            <h2 id="product-modal-title">
              {item.name}
            </h2>

            {item.description && (
              <p>
                {item.description}
              </p>
            )}
          </div>

          <button
            type="button"
            className="product-modal__close"
            onClick={onClose}
            aria-label="Stäng"
          >
            ×
          </button>
        </div>

        {item.variants.length > 0 && (
          <div className="product-modal__section">
            <h3>
              Välj alternativ
            </h3>

            <div className="product-modal__choices">
              {item.variants.map(
                (variant) => (
                  <label
                    key={variant.id}
                    className="product-choice"
                  >
                    <input
                      type="radio"
                      name="variant"
                      value={
                        variant.id
                      }
                      checked={
                        selectedVariantId ===
                        variant.id
                      }
                      onChange={() =>
                        setSelectedVariantId(
                          variant.id
                        )
                      }
                    />

                    <span>
                      {variant.name}
                    </span>

                    <strong>
                      {formatPrice(
                        variant.price
                      )}
                    </strong>
                  </label>
                )
              )}
            </div>

            {variantRequired &&
              selectedVariant === null && (
                <p className="product-modal__warning">
                  Du måste välja ett
                  alternativ.
                </p>
              )}
          </div>
        )}

        {item.extras.length > 0 && (
          <div className="product-modal__section">
            <h3>
              Tillval
            </h3>

            <div className="product-modal__choices">
              {item.extras.map(
                (extra) => (
                  <label
                    key={extra.id}
                    className="product-choice"
                  >
                    <input
                      type="checkbox"
                      checked={
                        selectedExtraIds.has(
                          extra.id
                        )
                      }
                      onChange={() =>
                        toggleExtra(
                          extra.id
                        )
                      }
                    />

                    <span>
                      {extra.name}
                    </span>

                    <strong>
                      {extra.priceChange >
                      0
                        ? "+"
                        : ""}
                      {formatPrice(
                        extra.priceChange
                      )}
                    </strong>
                  </label>
                )
              )}
            </div>
          </div>
        )}

        <div className="product-modal__section">
          <h3>
            Kommentar
          </h3>

          <textarea
            value={comment}
            onChange={(event) =>
              setComment(
                event.target.value
              )
            }
            placeholder="Exempel: ingen lök, välgräddad..."
            rows={3}
          />
        </div>

        <div className="product-modal__footer">
          <div className="product-modal__quantity">
            <button
              type="button"
              onClick={() =>
                setQuantity(
                  (current) =>
                    Math.max(
                      1,
                      current - 1
                    )
                )
              }
            >
              −
            </button>

            <strong>
              {quantity}
            </strong>

            <button
              type="button"
              onClick={() =>
                setQuantity(
                  (current) =>
                    current + 1
                )
              }
            >
              +
            </button>
          </div>

          <button
            type="button"
            className="product-modal__add"
            disabled={!canAdd}
            onClick={handleAdd}
          >
            Lägg till ·{" "}
            {formatPrice(
              totalPrice
            )}
          </button>
        </div>
      </section>
    </div>
  );
}