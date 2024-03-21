import { RouterProvider, createBrowserRouter } from "react-router-dom";
import Home from "./pages/Home";
import axios from "axios";
import { useState, useEffect } from "react";
import { Beverage } from "./models/beverage.model";
import { baseUrl } from "./utils/constants";

const App = () => {
  const [beverages, setBeverages] = useState<Beverage[] | undefined>();
  useEffect(() => {
    axios.post(baseUrl + "menu", {}).then((response) => {
      // console.log("Status:", response.status);
      // console.log("Data:", response.data);
      setBeverages(response.data);
    });
  }, []);

  const router = createBrowserRouter([
    {
      path: "/",
      element: <Home beverages={beverages} />,
    },
  ]);

  return (
    <>
      <RouterProvider router={router} />
    </>
  );
};

export default App;
