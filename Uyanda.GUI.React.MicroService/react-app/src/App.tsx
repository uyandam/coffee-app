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

  const router = createBrowserRouter([
    {
      path: "/",
      element: <Home beverages={beverages} cart={cart} />,
    },
  ]);

  return (
    <>
      <RouterProvider router={router} />
    </>
  );
};

export default App;
