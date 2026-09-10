import Header from "../components/Header";
import Hero from "../components/Hero";
import PopularPizzas from "../components/PopularPizzas";
import GiftCardSection from "../components/GiftCardSection";
import LunchSection from "../components/LunchSection";
import InfoSection from "../components/InfoSection";
import Footer from "../components/Footer";

export default function HomePage() {
  return (
    <>
      <Header />

      <main>
        <Hero />

        <PopularPizzas />

        <LunchSection />

        <GiftCardSection />

        <InfoSection />

        <Footer />
      </main>
    </>
  );
}