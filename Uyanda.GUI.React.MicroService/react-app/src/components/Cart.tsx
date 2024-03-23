import React from "react";
import { Beverage } from "../models/beverage.model";
import BeverageItem from "./beverageComponents/BeverageItem";
import RemoveBeverageItem from "./beverageComponents/RemoveBeverageItem";

interface Props {
  cart: Beverage[];
}

const Cart = ({ cart }: Props) => {
  return (
    <>
      <div>
        <h1>Cart items</h1>

        {cart.length > 0 ? (
          <ul>
            {cart.map((item, index) => (
              <li
                key={item.id}
                className="list-group-item p-3 mb-2 bg-primary text-white"
              >
                <BeverageItem
                  beverageName={item.beverageName.name}
                  beverageType={item.beverageType.name}
                  beverageSize={item.beverageSize.name}
                  price={item.price.price}
                  count={item.count}
                />
                <RemoveBeverageItem />
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
