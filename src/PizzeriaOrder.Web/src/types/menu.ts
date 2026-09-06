export interface MenuVariant {
  id: number;
  name: string;
  price: number;
}

export interface MenuExtra {
  id: number;
  name: string;
  priceChange: number;
}

export interface MenuItem {
  id: number;
  name: string;
  description: string | null;
  price: number | null;
  imageUrl: string | null;
  variants: MenuVariant[];
  extras: MenuExtra[];
}

export interface MenuCategory {
  id: number;
  name: string;
  sortOrder: number;
  items: MenuItem[];
}