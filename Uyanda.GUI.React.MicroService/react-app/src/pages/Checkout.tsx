import React from "react";
import { Beverage } from "../models/beverage.model";

interface Props {
  cart: Beverage[];
}

const Checkout = ({ cart }: Props) => {
  console.log(cart);

  return <div>Checkout</div>;
};

export default Checkout;
