import type { Order, OrderStatus } from "../types/orders";

const API_URL =
  import.meta.env.VITE_API_URL ?? "http://localhost:5083";

export async function getActiveOrders(
  restaurantId: number
): Promise<Order[]> {
  const response = await fetch(
    `${API_URL}/api/restaurants/${restaurantId}/orders/active`
  );

  if (!response.ok) {
    throw new Error("Kunde inte hämta aktiva beställningar.");
  }

  return response.json();
}

export async function updateOrderStatus(
  orderId: number,
  status: OrderStatus
): Promise<Order> {
  const response = await fetch(
    `${API_URL}/api/orders/${orderId}/status`,
    {
      method: "PATCH",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        status,
      }),
    }
  );

  if (!response.ok) {
    throw new Error("Kunde inte uppdatera orderstatus.");
  }

  return response.json();
}

export async function getOrders(
  restaurantId: number
): Promise<Order[]> {
  const response = await fetch(
    `${API_URL}/api/restaurants/${restaurantId}/orders`
  );

  if (!response.ok) {
    throw new Error("Kunde inte hämta beställningar.");
  }

  return response.json();
}