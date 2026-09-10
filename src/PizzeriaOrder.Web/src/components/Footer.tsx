export default function Footer() {
  return (
    <footer className="site-footer">
      <div className="site-footer__top">
        <div className="site-footer__top-inner">
          <div className="footer-promo">
            <div>
                <strong>AVHÄMTNING</strong>
                <span>Beställ online – vi lagar, du hämtar.</span>
            </div>
          </div>

          <div className="footer-logo-placeholder">
            TRÖDJE
            <span>PIZZERIA</span>
          </div>

          <a href="/meny" className="footer-order">
            <div>
              <strong>BESTÄLL ENKELT ONLINE</strong>
              <span>Snabbt, smidigt & gott!</span>
            </div>

            <span className="footer-order__arrow">→</span>
          </a>
        </div>
      </div>

      <div className="site-footer__main">
        <div className="site-footer__grid">
          <div className="footer-column">
            <h3>TRÖDJE PIZZERIA</h3>

            <p>
              Äkta pizza gjord med kärlek.
              <br />
              Tack för att du väljer oss!
            </p>
          </div>

          <div className="footer-column">
            <h3>SNABBLÄNKAR</h3>

            <nav className="footer-links">
              <a href="/">Hem</a>
              <a href="/meny">Meny</a>
              <a href="#lunch">Lunch</a>
              <a href="#om-oss">Om oss</a>
              <a href="#kontakt">Kontakt</a>
            </nav>
          </div>

          <div className="footer-column">
            <h3>FÖLJ OSS</h3>

            <div className="footer-social">
              <a
                href="https://www.facebook.com/trodjepizzeria.se"
                target="_blank"
                rel="noreferrer"
              >
                Facebook
              </a>

              <a
                href="https://www.instagram.com/trodjerestaurangpizzeria"
                target="_blank"
                rel="noreferrer"
              >
                Instagram
              </a>
            </div>
          </div>

          <div className="footer-column footer-credit">
            <h3>WEBBPLATS</h3>

            <p>
                Utvecklad av{" "}
                <a
                href="https://granitenstudio.com"
                target="_blank"
                rel="noopener noreferrer"
                >
                granitenstudio.com
                </a>
            </p>
          </div>
        </div>
      </div>
    </footer>
  );
}