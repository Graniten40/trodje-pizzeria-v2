export default function InfoSection() {
  return (
    <section className="info-section">
      <div className="info-section__grid">
        <article id="om-oss" className="info-card info-card--about">
          <div className="info-card__about-content">
            <h3>OM OSS</h3>

            <p>
              Trödje Pizzeria är en lokal pizzeria med
              hjärtat i maten. Vi använder färska och
              noggrant utvalda råvaror för att ge dig
              den bästa smakupplevelsen – varje gång.
            </p>

            <p>Tack för att du stödjer oss!</p>
          </div>

          <img
            src="/info/moose-forest.png"
            alt=""
            className="info-card__about-image"
            aria-hidden="true"
          />
        </article>

        <article className="info-card">
          <h3>ÖPPETTIDER</h3>

          <div className="opening-hours">
            <div>
              <span>Måndag</span>
              <span>11:00 – 21:00</span>
            </div>
            <div>
              <span>Tisdag</span>
              <span>11:00 – 21:00</span>
            </div>
            <div>
              <span>Onsdag</span>
              <span>11:00 – 21:00</span>
            </div>
            <div>
              <span>Torsdag</span>
              <span>11:00 – 21:00</span>
            </div>
            <div>
              <span>Fredag</span>
              <span>11:00 – 22:00</span>
            </div>
            <div>
              <span>Lördag</span>
              <span>12:00 – 22:00</span>
            </div>
            <div>
              <span>Söndag</span>
              <span>12:00 – 21:00</span>
            </div>
          </div>
        </article>

        <article id="kontakt" className="info-card info-card--contact">
          <div className="info-card__contact-text">
            <h3>KONTAKT & HITTA HIT</h3>

            <div className="contact-list">
              <p>📞 026-16 14 11</p>
              <p>📍 Tittmyrvägen 1, 805 96 Gävle</p>
              <p>📘 Följ oss på Facebook & Instagram</p>
            </div>
          </div>

          <div className="info-card__map">
            <iframe
              title="Karta till Trödje Pizzeria"
              src="https://www.google.com/maps?q=Tittmyrvägen+1,+805+96+Gävle&output=embed"
              loading="lazy"
              referrerPolicy="no-referrer-when-downgrade"
            />
          </div>
        </article>
      </div>
    </section>
  );
}