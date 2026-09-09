import {
  createContext,
  useContext,
  useMemo,
  useState,
} from "react";

import type {
  AddCartItemInput,
  CartItem,
} from "./cartTypes";

interface CartContextValue {
  items: CartItem[];
  totalItems: number;
  totalPrice: number;

  addItem: (
    input: AddCartItemInput
  ) => void;

  updateItemQuantity: (
    key: string,
    quantity: number
  ) => void;

  removeItem: (
    key: string
  ) => void;

  clearCart: () => void;
}

const CartContext =
  createContext<CartContextValue | null>(
    null
  );

function createCartKey(
  input: AddCartItemInput
) {
  const extraIds = input.extras
    .map((extra) => extra.id)
    .sort((a, b) => a - b)
    .join("-");

  const variantId =
    input.variant?.id ?? "none";

  const comment =
    input.comment?.trim() ?? "";

  return [
    input.menuItem.id,
    variantId,
    extraIds,
    comment,
  ].join("|");
}

function calculateUnitPrice(
  input: AddCartItemInput
) {
  const basePrice =
    input.variant?.price ??
    input.menuItem.price ??
    0;

  const extrasPrice =
    input.extras.reduce(
      (sum, extra) =>
        sum + extra.priceChange,
      0
    );

  return basePrice + extrasPrice;
}

export function CartProvider({
  children,
}: {
  children: React.ReactNode;
}) {
  const [items, setItems] =
    useState<CartItem[]>([]);

  function addItem(
    input: AddCartItemInput
  ) {
    const key =
      createCartKey(input);

    const unitPrice =
      calculateUnitPrice(input);

    setItems((current) => {
      const existing =
        current.find(
          (item) =>
            item.key === key
        );

      if (existing) {
        return current.map(
          (item) =>
            item.key === key
              ? {
                  ...item,

                  quantity:
                    item.quantity +
                    input.quantity,

                  totalPrice:
                    unitPrice *
                    (
                      item.quantity +
                      input.quantity
                    ),
                }
              : item
        );
      }

      const newItem: CartItem = {
        key,

        menuItemId:
          input.menuItem.id,

        name:
          input.menuItem.name,

        quantity:
          input.quantity,

        basePrice:
          input.variant?.price ??
          input.menuItem.price ??
          0,

        variant:
          input.variant,

        extras:
          input.extras,

        comment:
          input.comment,

        unitPrice,

        totalPrice:
          unitPrice *
          input.quantity,
      };

      return [
        ...current,
        newItem,
      ];
    });
  }

  function updateItemQuantity(
    key: string,
    quantity: number
  ) {
    if (quantity <= 0) {
      removeItem(key);
      return;
    }

    setItems((current) =>
      current.map((item) =>
        item.key === key
          ? {
              ...item,
              quantity,
              totalPrice:
                item.unitPrice *
                quantity,
            }
          : item
      )
    );
  }

  function removeItem(
    key: string
  ) {
    setItems((current) =>
      current.filter(
        (item) =>
          item.key !== key
      )
    );
  }

  function clearCart() {
    setItems([]);
  }

  const totalItems =
    useMemo(
      () =>
        items.reduce(
          (sum, item) =>
            sum +
            item.quantity,
          0
        ),
      [items]
    );

  const totalPrice =
    useMemo(
      () =>
        items.reduce(
          (sum, item) =>
            sum +
            item.totalPrice,
          0
        ),
      [items]
    );

  const value =
    useMemo(
      () => ({
        items,
        totalItems,
        totalPrice,
        addItem,
        updateItemQuantity,
        removeItem,
        clearCart,
      }),
      [
        items,
        totalItems,
        totalPrice,
      ]
    );

  return (
    <CartContext.Provider
      value={value}
    >
      {children}
    </CartContext.Provider>
  );
}

export function useCart() {
  const context =
    useContext(CartContext);

  if (!context) {
    throw new Error(
      "useCart måste användas inne i CartProvider."
    );
  }

  return context;
}