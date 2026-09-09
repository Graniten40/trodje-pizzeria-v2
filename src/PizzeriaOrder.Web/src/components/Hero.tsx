export default function Hero() {
  return (
    <section className="hero">
      <div className="hero__inner">
        <div className="hero__content">
          <p className="hero__eyebrow">
            Välkommen till
          </p>

          <h1>
            TRÖDJE
            <span>PIZZERIA</span>
          </h1>

          <p className="hero__description">
            Pizza, kebab, grill och sallader
            tillagade med färska råvaror.
            Beställ enkelt online eller kom
            förbi oss i Trödje.
          </p>

          <div className="hero__actions">
            <a
              href="/meny"
              className="button button--primary"
            >
              BESTÄLL ONLINE
            </a>

            <a
              href="/meny"
              className="button button--secondary"
            >
              VISA MENY
            </a>
          </div>

          <div className="hero__features">
            <span>✓ Färska råvaror</span>
            <span>✓ Nylagad mat</span>
            <span>✓ Beställ enkelt online</span>
          </div>
        </div>

        <div className="hero__visual">
          <div className="hero__pizza-placeholder">
            <span>TRÖDJE</span>
            <strong>PIZZERIA</strong>
            <small>
              Här lägger vi den riktiga
              pizzabilden
            </small>
          </div>
        </div>
      </div>
    </section>
  );
}