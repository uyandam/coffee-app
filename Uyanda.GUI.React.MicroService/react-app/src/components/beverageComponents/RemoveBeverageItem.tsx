import React from "react";

interface Props {
  itemId: number;
  removeFromCart(itemIdToRemove: number): void;
}

const RemoveBeverageItem = ({ itemId, removeFromCart }: Props) => {
  const handleRemoveItemEvent = () => {
    removeFromCart(itemId);
  };
  return (
    <>
      <button
        type="button"
        className="btn btn-dark"
        onClick={handleRemoveItemEvent}
      >
        Remove from cart
      </button>
    </>
  );
};

export default RemoveBeverageItem;
