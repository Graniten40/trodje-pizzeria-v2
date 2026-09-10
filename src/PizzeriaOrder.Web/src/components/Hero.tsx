import { useId } from "react";

export default function Hero() {
  const maskId = `pizza-brush-${useId().replace(/:/g, "")}`;

  return (
    <section className="hero">
      <div className="hero__inner">
        <div className="hero__content">
          <div className="hero__title-area">
            <img
              src="/hero/moose.png"
              alt=""
              className="hero__moose"
              aria-hidden="true"
            />

            <p className="hero__eyebrow">
              Välkommen till
            </p>

            <h1>
              TRÖDJE
              <span>PIZZERIA</span>
            </h1>
          </div>

          <p className="hero__description">
            Äkta pizza. Färska råvaror. Lagad med kärlek.
            <br />
            För avhämtning, beställning online eller en god stund hos oss.
          </p>

          <div className="hero__actions">
            <a href="/meny" className="button button--primary">
              🍕 BESTÄLL ONLINE
            </a>

            <a href="/meny" className="button button--secondary">
              VISA MENY
            </a>
          </div>

          <div className="hero__features">
            <span>◇ Färska råvaror</span>
            <span>◇ Nylagad mat</span>
            <span>◇ Gjort med kärlek</span>
          </div>
        </div>

        <div className="hero__visual">
          <div className="hero__pizza-wrap hero__pizza-wrap--brush">
            <svg
              className="hero__brush-image"
              viewBox="0 0 1000 650"
              role="img"
              aria-label="Pizza från Trödje Pizzeria"
            >
              <defs>
                <mask
                  id={maskId}
                  x="0"
                  y="0"
                  width="1000"
                  height="650"
                  maskUnits="userSpaceOnUse"
                  style={{ maskType: "luminance" }}
                >
                  <rect width="1000" height="650" fill="black" />

                  {/* Den stora målade ytan */}
                  <path
                    fill="white"
                    d="
                      M 130 170
                      L 225 107 L 190 119 L 320 49
                      L 295 73 L 430 28 L 410 43
                      L 565 16 L 550 28 L 755 18
                      L 738 29 L 947 22 L 920 40
                      L 985 43 L 966 68 L 995 83
                      L 979 123 L 998 141 L 988 198
                      L 1000 230 L 990 290 L 998 326
                      L 976 387 L 992 401 L 954 454
                      L 977 446 L 918 513 L 946 504
                      L 845 570 L 865 549 L 755 601
                      L 769 585 L 639 621 L 650 606
                      L 508 631 L 523 614 L 371 625
                      L 390 609 L 250 601 L 275 592
                      L 162 563 L 187 565 L 105 523
                      L 135 530 L 78 481 L 104 487
                      L 61 438 L 86 447 L 56 399
                      L 77 401 L 58 363 L 83 341
                      L 53 350 L 97 295 L 67 307
                      L 117 246 L 84 260 L 151 199
                      L 111 214 Z
                    "
                  />

                  {/* Smala penseldrag utanför huvudytan */}
                  <g fill="white">
                    <path d="M 75 180 Q 183 96 327 48 Q 187 114 75 180 Z" />
                    <path d="M 39 243 Q 100 192 195 154 Q 125 197 39 243 Z" />
                    <path d="M 26 299 Q 64 257 126 232 L 75 272 Z" />
                    <path d="M 33 375 L 57 335 L 48 365 Z" />
                    <path d="M 87 529 Q 180 596 301 613 Q 186 608 87 529 Z" />
                    <path d="M 192 619 Q 287 639 399 629 L 314 645 Z" />
                    <path d="M 698 637 Q 866 600 970 522 Q 893 598 698 637 Z" />
                    <path d="M 884 591 L 983 523 L 952 558 Z" />
                    <path d="M 333 37 L 370 17 L 356 31 Z" />
                    <path d="M 52 220 L 70 203 L 62 217 Z" />
                  </g>

                  {/* Tunna glipor som ger torra penselkanter */}
                  <g fill="black">
                    <path d="M 97 205 L 283 91 L 150 181 Z" />
                    <path d="M 56 315 L 213 223 L 97 304 Z" />
                    <path d="M 47 373 L 168 307 L 82 367 Z" />
                    <path d="M 73 475 L 190 517 L 105 496 Z" />
                    <path d="M 173 570 L 335 607 L 226 591 Z" />
                    <path d="M 696 613 L 889 548 L 791 593 Z" />
                    <path d="M 840 581 L 989 465 L 935 525 Z" />
                    <path d="M 328 58 L 518 21 L 421 48 Z" />
                  </g>
                </mask>
              </defs>

              <image
                href="/hero/pizza-hero.jpg"
                width="1000"
                height="650"
                preserveAspectRatio="xMidYMid slice"
                mask={`url(#${maskId})`}
              />
            </svg>

            <div className="hero__badge">
              <small>NYBAKAD</small>
              <strong>PIZZA</strong>
              <span>VARJE DAG!</span>
              <b>♥</b>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
}