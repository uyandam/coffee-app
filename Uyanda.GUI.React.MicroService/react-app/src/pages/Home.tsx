import Menu from "../components/Menu";
import { Beverage } from "../models/beverage.model";

interface Props {
  beverages: Beverage[] | undefined;
}

const Home = ({ beverages }: Props) => {
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
