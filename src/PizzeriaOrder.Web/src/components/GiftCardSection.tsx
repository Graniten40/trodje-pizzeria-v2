export default function GiftCardSection() {
  return (
    <section
      id="presentkort"
      className="giftcard-section"
    >
      <div className="giftcard-section__inner">
        <div className="giftcard-section__content">
          <p className="section-eyebrow">
            PRESENTKORT
          </p>

          <h2>
            Ge bort något riktigt gott
          </h2>

          <p>
            Ett presentkort på Trödje Pizzeria
            passar perfekt som födelsedagspresent,
            julklapp eller bara för att bjuda någon
            på en god middag.
          </p>

          <div className="giftcard-section__amounts">
            <span>250 kr</span>
            <span>500 kr</span>
            <span>750 kr</span>
            <span>1000 kr</span>
          </div>

          <button
            type="button"
            className="button button--dark"
          >
            KÖP PRESENTKORT
          </button>
        </div>

        <div className="giftcard">
          <div className="giftcard__logo">
            TRÖDJE
            <span>PIZZERIA</span>
          </div>

          <strong>PRESENTKORT</strong>

          <small>
            God mat. Goda stunder.
          </small>
        </div>
      </div>
    </section>
  );
}