import type { MenuCategory } from "../types/menu";

const API_URL =
  import.meta.env.VITE_API_URL ??
  "http://localhost:5083";

export async function getMenu(
  restaurantId: number
): Promise<MenuCategory[]> {
  const response = await fetch(
    `${API_URL}/api/restaurants/${restaurantId}/menu`
  );

  if (!response.ok) {
    throw new Error(
      "Kunde inte hämta menyn."
    );
  }

  return response.json();
}