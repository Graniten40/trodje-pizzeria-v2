import OrdersPage from "./admin/pages/OrdersPage";
import HomePage from "./pages/HomePage";
import MenuPage from "./pages/MenuPage";

import "./styles/site.css";

function App() {
  const path =
    window.location.pathname.toLowerCase();

  if (path.startsWith("/admin")) {
    return <OrdersPage />;
  }

  if (path.startsWith("/meny")) {
    return <MenuPage />;
  }

  return <HomePage />;
}

export default App;