import {
  useEffect,
  useMemo,
  useState,
} from "react";

import Header from "../components/Header";
import ProductModal from "../components/ProductModal";
import CartDrawer from "../components/CartDrawer";
import { getMenu } from "../services/menuApi";

import type {
  MenuCategory,
  MenuItem,
} from "../types/menu";

const RESTAURANT_ID = 1;

type MenuGroup = {
  id: string;
  label: string;
  categoryNames: string[];
};

const MENU_GROUPS: MenuGroup[] = [
  {
    id: "pizza",
    label: "Pizza",
    categoryNames: [
      "Skinkpizzor",
      "Havspizzor",
      "Köttfärspizzor",
      "Salami & Baconpizzor",
      "Ox-/Fläskfilépizzor",
      "Gorgonzolapizzor",
      "Mexikanska pizzor",
      "Kycklingpizzor",
      "Kebabpizzor",
    ],
  },
  {
    id: "kebab",
    label: "Kebab",
    categoryNames: [
      "Kebab / Kyckling / Falafel",
    ],
  },
  {
    id: "kottratter",
    label: "Kötträtter",
    categoryNames: [
      "Kötträtter",
    ],
  },
  {
    id: "grill",
    label: "Grill",
    categoryNames: [
      "Grillrätter",
    ],
  },
  {
    id: "fisk",
    label: "Fisk",
    categoryNames: [
      "Fiskrätter",
    ],
  },
  {
    id: "pasta",
    label: "Pasta",
    categoryNames: [
      "Pastarätter",
    ],
  },
  {
    id: "sallad",
    label: "Sallad",
    categoryNames: [
      "Sallader",
    ],
  },
  {
    id: "barn",
    label: "Barn",
    categoryNames: [
      "Barnrätter",
    ],
  },
];

function formatPrice(price: number) {
  return new Intl.NumberFormat("sv-SE", {
    style: "currency",
    currency: "SEK",
    minimumFractionDigits: 0,
    maximumFractionDigits: 0,
  }).format(price);
}

function getItemPriceText(
  item: MenuItem
) {
  if (item.price !== null) {
    return formatPrice(item.price);
  }

  if (item.variants.length === 0) {
    return "";
  }

  const prices = item.variants.map(
    (variant) => variant.price
  );

  const lowestPrice = Math.min(
    ...prices
  );

  return `Från ${formatPrice(
    lowestPrice
  )}`;
}

function slugify(value: string) {
  return value
    .toLowerCase()
    .replaceAll("å", "a")
    .replaceAll("ä", "a")
    .replaceAll("ö", "o")
    .replace(/[^a-z0-9]+/g, "-")
    .replace(/^-|-$/g, "");
}

export default function MenuPage() {
  const [categories, setCategories] =
    useState<MenuCategory[]>([]);

  const [loading, setLoading] =
    useState(true);

  const [error, setError] =
    useState<string | null>(null);

  const [
    selectedItem,
    setSelectedItem,
  ] = useState<MenuItem | null>(
    null
  );

  useEffect(() => {
    async function loadMenu() {
      try {
        setError(null);

        const data = await getMenu(
          RESTAURANT_ID
        );

        setCategories(data);
      } catch {
        setError(
          "Kunde inte hämta menyn."
        );
      } finally {
        setLoading(false);
      }
    }

    void loadMenu();
  }, []);

  const groupedMenu = useMemo(() => {
    return MENU_GROUPS.map(
      (group) => {
        const groupCategories =
          categories.filter(
            (category) =>
              group.categoryNames.includes(
                category.name
              )
          );

        return {
          ...group,
          categories:
            groupCategories,
        };
      }
    ).filter(
      (group) =>
        group.categories.length > 0
    );
  }, [categories]);

  function scrollToGroup(
    groupId: string
  ) {
    document
      .getElementById(
        `menu-group-${groupId}`
      )
      ?.scrollIntoView({
        behavior: "smooth",
        block: "start",
      });
  }

  if (loading) {
    return (
      <>
        <Header />

        <main className="menu-page">
          <p>
            Laddar menyn...
          </p>
        </main>
      </>
    );
  }

  return (
    <>
      <Header />

      <main className="menu-page">
        <section className="menu-page__hero">
          <p className="section-eyebrow">
            TRÖDJE PIZZERIA
          </p>

          <h1>
            Meny
          </h1>

          <p>
            Pizza, kebab, grill,
            sallader och mycket mer.
          </p>
        </section>

        {error && (
          <p className="menu-page__error">
            {error}
          </p>
        )}

        {!error && (
          <>
            <nav className="menu-category-nav">
              <div className="menu-category-nav__inner">
                {groupedMenu.map(
                  (group) => (
                    <button
                      key={group.id}
                      type="button"
                      onClick={() =>
                        scrollToGroup(
                          group.id
                        )
                      }
                    >
                      {group.label}
                    </button>
                  )
                )}
              </div>
            </nav>

            <div className="menu-order-layout">
              <div className="menu-groups">
                {groupedMenu.map(
                  (group) => (
                    <section
                      key={group.id}
                      id={`menu-group-${group.id}`}
                      className="menu-group"
                    >
                      <div className="menu-group__heading">
                        <h2>
                          {group.label}
                        </h2>

                        <span />
                      </div>

                      {group.categories.map(
                        (category) => (
                          <section
                            key={
                              category.id
                            }
                            id={`category-${slugify(
                              category.name
                            )}`}
                            className="menu-category"
                          >
                            <div className="menu-category__heading">
                              <h3>
                                {
                                  category.name
                                }
                              </h3>

                              {category.name
                                .toLowerCase()
                                .includes(
                                  "pizz"
                                ) && (
                                <p>
                                  I våra pizzor
                                  ingår tomat och
                                  ost.
                                </p>
                              )}
                            </div>

                            <div className="menu-items">
                              {category.items.map(
                                (item) => (
                                  <article
                                    key={
                                      item.id
                                    }
                                    className="menu-item"
                                  >
                                    <div className="menu-item__main">
                                      <div className="menu-item__text">
                                        <h4>
                                          {
                                            item.name
                                          }
                                        </h4>

                                        {item.description && (
                                          <p>
                                            {
                                              item.description
                                            }
                                          </p>
                                        )}

                                        {item.variants.length >
                                          0 && (
                                          <div className="menu-item__variants">
                                            {item.variants.map(
                                              (
                                                variant
                                              ) => (
                                                <span
                                                  key={
                                                    variant.id
                                                  }
                                                >
                                                  {
                                                    variant.name
                                                  }
                                                  :{" "}
                                                  {formatPrice(
                                                    variant.price
                                                  )}
                                                </span>
                                              )
                                            )}
                                          </div>
                                        )}
                                      </div>

                                      <div className="menu-item__right">
                                        <strong>
                                          {getItemPriceText(
                                            item
                                          )}
                                        </strong>

                                        <button
                                          type="button"
                                          className="menu-item__add"
                                          onClick={() =>
                                            setSelectedItem(
                                              item
                                            )
                                          }
                                        >
                                          Lägg till
                                        </button>
                                      </div>
                                    </div>
                                  </article>
                                )
                              )}
                            </div>
                          </section>
                        )
                      )}
                    </section>
                  )
                )}
              </div>

              <CartDrawer />
            </div>
          </>
        )}

        <ProductModal
          item={selectedItem}
          onClose={() =>
            setSelectedItem(null)
          }
        />
      </main>
    </>
  );
}