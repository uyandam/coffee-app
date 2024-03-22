import Cart from "../components/Cart";
import Menu from "../components/Menu";
import { Beverage } from "../models/beverage.model";

interface Props {
  beverages: Beverage[];
  cart: Beverage[];
}

const Home = ({ beverages, cart }: Props) => {
  return (
    <>
      <div>
        <div className="container">
          <div className="row">
            <div className="col-sm">
              <Menu title={"Menu Beverage"} beverages={beverages} />
            </div>
            <div className="col-sm">
              <Cart cart={cart} />
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default Home;
