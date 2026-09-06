export type OrderStatus =
  | "New"
  | "Confirmed"
  | "Preparing"
  | "ReadyForPickup"
  | "Collected"
  | "Rejected"
  | "Cancelled";

export interface OrderItemVariant {
  id: number;
  menuItemVariantId: number;
  name: string;
  price: number;
}

export interface OrderItemExtra {
  id: number;
  menuItemExtraId: number;
  name: string;
  priceChange: number;
}

export interface OrderItem {
  id: number;
  menuItemId: number;
  name: string;
  quantity: number;
  unitPrice: number;
  totalPrice: number;
  comment: string | null;
  variant: OrderItemVariant | null;
  extras: OrderItemExtra[];
}

export interface Order {
  id: number;
  restaurantId: number;
  customerName: string;
  phone: string;
  email: string | null;
  comment: string | null;
  totalPrice: number;
  status: OrderStatus;
  createdAtUtc: string;
  items: OrderItem[];
}