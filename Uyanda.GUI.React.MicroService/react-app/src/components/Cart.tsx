import React from "react";
import { Beverage } from "../models/beverage.model";

interface Props {
  cart: Beverage[];
}

const Cart = ({ cart }: { cart: Beverage[] }) => {
  return (
    <div>
      <h1>Cart component</h1>
    </div>
  );
};

export default Cart;
