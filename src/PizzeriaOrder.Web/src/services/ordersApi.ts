const API_URL =
  import.meta.env.VITE_API_URL ??
  "http://localhost:5083";

export interface CreateOrderItemRequest {
  menuItemId: number;
  quantity: number;
  menuItemVariantId: number | null;
  menuItemExtraIds: number[];
  comment: string | null;
}

export interface CreateOrderRequest {
  restaurantId: number;
  customerName: string;
  phone: string;
  email: string | null;
  comment: string | null;
  items: CreateOrderItemRequest[];
}

export async function createOrder(
  order: CreateOrderRequest
) {
  const response = await fetch(
    `${API_URL}/api/orders`,
    {
      method: "POST",

      headers: {
        "Content-Type":
          "application/json",
      },

      body: JSON.stringify(order),
    }
  );

  if (!response.ok) {
    const errorText =
      await response.text();

    throw new Error(
      errorText ||
        "Kunde inte skapa beställningen."
    );
  }

  return response.json();
}