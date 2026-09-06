import OrdersPage from "./admin/pages/OrdersPage";
import HomePage from "./pages/HomePage";
import "./styles/site.css";

function App() {
  const path =
    window.location.pathname.toLowerCase();

  if (path.startsWith("/admin")) {
    return <OrdersPage />;
  }

  return <HomePage />;
}

export default App;