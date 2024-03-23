import React from "react";
import { Beverage } from "../models/beverage.model";

interface Props {
  cart: Beverage[];
}

const Cart = ({ cart }: Props) => {
  return (
    <>
      <div>
        <h1>Cart component</h1>

        {cart.length > 0 ? (
          <ul>
            {cart.map((item, index) => (
              <li
                key={item.id}
                className="list-group-item p-3 mb-2 bg-primary text-white"
              >
                {item.beverageName.name}
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
