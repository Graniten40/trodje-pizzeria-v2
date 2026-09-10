import Header from "../components/Header";
import Hero from "../components/Hero";
import PopularPizzas from "../components/PopularPizzas";
import GiftCardSection from "../components/GiftCardSection";
import LunchSection from "../components/LunchSection";

export default function HomePage() {
  return (
    <>
      <Header />

      <main>
        <Hero />

        <PopularPizzas />

        <LunchSection />

        <GiftCardSection />

        <section
          id="om-oss"
          className="homepage-placeholder"
        >
          <p className="section-eyebrow">
            TRÖDJE PIZZERIA
          </p>

          <h2>Om oss</h2>
        </section>

        <section
          id="kontakt"
          className="homepage-placeholder"
        >
          <p className="section-eyebrow">
            KONTAKT
          </p>

          <h2>Kontakt & hitta hit</h2>

          <p>
            Tittmyrvägen 1, 805 96 Gävle
          </p>

          <p>
            026-16 14 11
          </p>
        </section>
      </main>
    </>
  );
}