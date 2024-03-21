import Menu from "../components/Menu";
import { Beverage } from "../models/beverage.model";

const Home = ({ beverages }: { beverages: Beverage[] | undefined }) => {
  console.log("------------------------------------");

  console.log(beverages);

  console.log("------------------------------------");

  return (
    <>
      <Menu title={"Menu Beverage"} beverages={beverages} />
    </>
  );
};

export default Home;
