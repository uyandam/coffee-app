import { Button } from "react-bootstrap";
import getMenu from "../services/beverage.service";
import { useEffect, useState } from "react";
import { Beverage } from "../models/menu.model";



function Home() {

  const [beverages, setBeverages] = useState<Beverage[]>([]);

  useEffect(() => {

    const getData = async () => {

      const result = await getMenu();

      setBeverages(result);

    }

    getData();

  }, [])


  // const getItems = async () => {
  //   let items = await getMenu();
  //   // console.log(items);
  //   return await getMenu();
  // }

  // getItems();



  console.log(beverages);

  return (<>
        <h1>Home page</h1>

        <ul>
          {beverages.map((elem) => (
            <li key={elem.id}>
              <h2>{elem.beverageName.name}</h2>
              <p>{elem.beverageSize.name}</p>
              <p>{elem.beverageType.name}</p>
              <p> {elem.price.currency} {elem.price.price}</p>
            </li>
          ))}
        </ul>

    </>)
}

export default Home;