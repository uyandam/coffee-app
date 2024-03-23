import Cart from "../components/Cart";
import Menu from "../components/Menu";
import { Beverage } from "../models/beverage.model";

interface Props {
  beverages: Beverage[];
  cart: Beverage[];
  addToCart(item: Beverage, cart: Beverage[]): void;
}

const Home = ({ cart, addToCart, beverages }: Props) => {
  return (
    <>
      <div>
        <div className="container">
          <div className="row">
            <div className="col-sm">
              <Menu
                title={"Menu items"}
                beverages={beverages}
                cart={cart}
                addToCart={addToCart}
              />
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
