import React from "react";
import { Beverage } from "../../models/beverage.model";

interface Props {
  beverageName: string;
  beverageType: string;
  beverageSize: string;
  price: number;
  count: number;
}

const BeverageItem = ({
  beverageName,
  beverageType,
  beverageSize,
  price,
  count,
}: Props) => {
  return (
    <>
      <table className="table table-dark">
        {/* <thead>
          <tr>
            <th scope="col">Item</th>
            <th scope="col">Type</th>
            <th scope="col">Size</th>
            <th scope="col">Price</th>
          </tr>
        </thead> */}

        <tbody>
          <tr>
            <th scope="row">{beverageName}</th>
            <td>{beverageType}</td>
            <td>{beverageSize}</td>
            <td>{price}</td>
          </tr>
        </tbody>
      </table>

      {/* <div> + </div>
      <p>{count}</p>
      <div> - </div>
      <div>
        <p>{beverageName}</p>
        <p>{beverageType}</p>
        <p>{beverageSize}</p>
        <p>{price}</p>
      </div> */}
    </>
  );
};

export default BeverageItem;
