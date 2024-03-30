import React from "react";
import { Beverage } from "../../models/beverage.model";

interface Props {
  cart: Beverage[];
  item: Beverage;
  addToCart(item: Beverage, cart: Beverage[]): void;
}

const AddBeverageItem = ({ cart, item, addToCart }: Props) => {
  const handleAddToCart = () => {
    // Call the addToCart function here
    addToCart(item, cart);
  };

  return (
    <>
      <button type="button" className="btn btn-dark" onClick={handleAddToCart}>
        Add to cart
      </button>
    </>
  );
};

export default AddBeverageItem;
