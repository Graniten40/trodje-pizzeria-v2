import type {
  MenuExtra,
  MenuItem,
  MenuVariant,
} from "../types/menu";

export interface CartItem {
  key: string;
  menuItemId: number;
  name: string;
  quantity: number;

  basePrice: number;

  variant: MenuVariant | null;
  extras: MenuExtra[];

  comment: string | null;

  unitPrice: number;
  totalPrice: number;
}

export interface AddCartItemInput {
  menuItem: MenuItem;
  quantity: number;
  variant: MenuVariant | null;
  extras: MenuExtra[];
  comment: string | null;
}