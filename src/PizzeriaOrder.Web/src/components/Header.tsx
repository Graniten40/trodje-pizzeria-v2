export default function Header() {
  return (
    <header className="site-header">
      <div className="site-header__inner">
        <a
          href="/"
          className="site-header__brand"
        >
          <div className="site-header__logo">
            TRÖDJE
            <span>PIZZERIA</span>
          </div>
        </a>

        <nav className="site-header__nav">
          <a href="/">Hem</a>
          <a href="#meny">Meny</a>
          <a href="#lunch">Lunch</a>
          <a href="#presentkort">Presentkort</a>
          <a href="#om-oss">Om oss</a>
          <a href="#kontakt">Kontakt</a>
        </nav>

        <div className="site-header__actions">
          <a
            href="tel:026161411"
            className="site-header__phone"
          >
            026-16 14 11
          </a>

          <a
            href="#meny"
            className="site-header__order"
          >
            BESTÄLL ONLINE
          </a>
        </div>
      </div>
    </header>
  );
}