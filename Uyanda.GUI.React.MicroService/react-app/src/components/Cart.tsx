import { Beverage } from "../models/beverage.model";
import BeverageItem from "./beverageComponents/BeverageItem";
import RemoveBeverageItem from "./beverageComponents/RemoveBeverageItem";
import { v4 as uuidv4 } from "uuid";

interface Props {
  cart: Beverage[];
  removeFromCart(itemIdToRemove: number): void;
}

const Cart = ({ cart, removeFromCart }: Props) => {
  return (
    <>
      <div>
        <h1>Cart items</h1>

        {cart.length > 0 ? (
          <ul>
            {cart.map((item, index) => (
              <li
                // key={uuidv4()}
                key={item.id}
                className="list-group-item p-3 mb-2 bg-primary text-white"
              >
                <BeverageItem
                  beverageName={item.beverageName.name}
                  beverageType={item.beverageType.name}
                  beverageSize={item.beverageSize.name}
                  price={item.price.price}
                  count={item.count}
                  showQuantity={true}
                />
                <RemoveBeverageItem
                  itemId={index}
                  removeFromCart={removeFromCart}
                />
              </li>
            ))}
          </ul>
        ) : (
          <p>Your cart is empty.</p>
        )}
      </div>
    </>
  );
};

export default Cart;
