import { RouterProvider, createBrowserRouter } from "react-router-dom";
import Home from "./pages/Home";
import axios from "axios";
import { useState, useEffect } from "react";
import { Beverage } from "./models/beverage.model";
import { baseUrl } from "./utils/constants";
import Checkout from "./pages/Checkout";

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
      // Find the item in the cart
      const existingItem = cart.find((cartItem) => cartItem.id === item.id);

      if (existingItem) {
        // If the item exists, increment the count
        return cart.map((cartItem) =>
          cartItem.id === item.id
            ? { ...cartItem, count: cartItem.count + 1 }
            : cartItem
        );
      } else {
        // If the item doesn't exist, add it to the cart with a count of 1
        return [...cart, { ...item, count: 1 }];
      }
    });
  };

  const removeFromCart = (itemIndex: number): void => {
    const item = cart[itemIndex];
    if (item.count > 1) {
      // Subtract one from the count property
      item.count -= 1;
      // Update the state with the modified cart
      setCart([...cart]);
    } else if (item.count === 1) {
      // Remove the item from the cart using splice
      cart.splice(itemIndex, 1);
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
    {
      path: "/checkout",
      element: <Checkout cart={cart} />, // Add the missing 'cart' prop
    },
  ]);

  return (
    <>
      <RouterProvider router={router} />
    </>
  );
};

export default App;
