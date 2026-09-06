import {
  useEffect,
  useState,
} from "react";

import { getMenu } from "../services/menuApi";
import type { MenuItem } from "../types/menu";

const RESTAURANT_ID = 1;

export default function PopularPizzas() {
  const [pizzas, setPizzas] =
    useState<MenuItem[]>([]);

  const [loading, setLoading] =
    useState(true);

  const [error, setError] =
    useState<string | null>(null);

  useEffect(() => {
    async function loadPopularPizzas() {
      try {
        const categories =
          await getMenu(
            RESTAURANT_ID
          );

        const pizzaItems =
          categories
            .filter((category) =>
                category.name
                    .toLowerCase()
                    .includes("pizz")
                )
            .flatMap(
              (category) =>
                category.items
            );

        setPizzas(
          pizzaItems.slice(0, 5)
        );
      } catch {
        setError(
          "Kunde inte hämta pizzorna."
        );
      } finally {
        setLoading(false);
      }
    }

    void loadPopularPizzas();
  }, []);

  if (loading) {
    return (
      <section
        id="meny"
        className="popular-pizzas"
      >
        <p>Laddar pizzor...</p>
      </section>
    );
  }

  if (error) {
    return (
      <section
        id="meny"
        className="popular-pizzas"
      >
        <p>{error}</p>
      </section>
    );
  }

  return (
    <section
      id="meny"
      className="popular-pizzas"
    >
      <div className="section-heading">
        <p className="section-eyebrow">
          VÅRA FAVORITER
        </p>

        <h2>
          Populära pizzor
        </h2>

        <span className="section-heading__line" />
      </div>

      <div className="popular-pizzas__grid">
        {pizzas.map((pizza) => (
          <article
            key={pizza.id}
            className="pizza-card"
          >
            <div className="pizza-card__image">
              {pizza.imageUrl ? (
                <img
                  src={pizza.imageUrl}
                  alt={pizza.name}
                />
              ) : (
                <div className="pizza-card__placeholder">
                  🍕
                </div>
              )}
            </div>

            <div className="pizza-card__content">
              <h3>
                {pizza.name}
              </h3>

              {pizza.description && (
                <p>
                  {pizza.description}
                </p>
              )}

              {pizza.price !== null && (
                <strong>
                  {pizza.price} kr
                </strong>
              )}
            </div>
          </article>
        ))}
      </div>

      <div className="popular-pizzas__footer">
        <a
          href="/meny"
          className="button button--secondary"
        >
          SE HELA MENYN
        </a>
      </div>
    </section>
  );
}