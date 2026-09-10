export default function LunchSection() {
  return (
    <section id="lunch" className="lunch-section">
      <div className="lunch-section__grid">

        <article className="lunch-card lunch-card--light">
          <div className="lunch-card__content">
            <p className="lunch-card__eyebrow">
              LUNCH
            </p>

            <h2>
              VARDAGAR 11–14
            </h2>

            <p className="lunch-card__description">
              Pizza, sallad, dryck & kaffe ingår
            </p>

            <strong className="lunch-card__price">
              129 kr
            </strong>

            <a
              href="/meny"
              className="lunch-card__button lunch-card__button--light"
            >
              VISA LUNCHMENY
            </a>
          </div>

          <div className="lunch-card__visual">
            <img
              src="/images/pizzas/lunch-pizza.png"
              alt="Lunch med pizza, sallad och dryck"
              className="lunch-card__image"
            />
          </div>
        </article>

        <article className="lunch-card lunch-card--red">
          <div className="lunch-card__content">
            <p className="lunch-card__eyebrow">
              FAMILJEDEAL ♡
            </p>

            <h2>
              2 valfria pizzor, sallad,
              <br />
              2 drycker & sås
            </h2>

            <strong className="lunch-card__price">
              249 kr
            </strong>

            <a
              href="/meny"
              className="lunch-card__button lunch-card__button--dark"
            >
              BESTÄLL NU
            </a>

            <small>
              Gäller för avhämtning
            </small>
          </div>

          <div className="lunch-card__visual">
            <img
                src="/images/pizzas/family-deal.png"
                alt="Familjedeal"
                className="lunch-card__family-image"
            />
            </div>
        </article>

      </div>
    </section>
  );
}