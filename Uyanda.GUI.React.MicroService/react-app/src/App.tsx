import { RouterProvider, createBrowserRouter } from "react-router-dom";
import Home from "./pages/Home";
import axios from "axios";
import { useState, useEffect } from "react";
import { Beverage } from "./models/beverage.model";
import { baseUrl } from "./utils/constants";

const App = () => {
  //get beverages items
  const [beverages, setBeverages] = useState<Beverage[]>([]);
  useEffect(() => {
    axios.post(baseUrl + "menu", {}).then((response) => {
      setBeverages(response.data);
    });
  }, []);

  const [cart, setCart] = useState<Beverage[]>([]);

  const addToCart = (item: Beverage, cart: Beverage[]) => {
    setCart((cart) => {
      return [...cart, item];
    });
  };

  const removeFromCart = (itemIndex: number): void => {
    const index = itemIndex;
    if (index !== -1) {
      // Remove the item from the cart using splice
      cart.splice(index, 1);
      // Update the state with the modified cart
      setCart([...cart]);
    }
  };

  const router = createBrowserRouter([
    {
      path: "/",
      element: (
        <Home
          beverages={beverages}
          cart={cart}
          addToCart={addToCart}
          removeFromCart={removeFromCart}
        />
      ),
    },
  ]);

  return (
    <>
      <RouterProvider router={router} />
    </>
  );
};

export default App;
