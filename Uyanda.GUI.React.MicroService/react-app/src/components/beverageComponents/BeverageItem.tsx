import React from "react";
import { Beverage } from "../../models/beverage.model";

interface Props {
  beverageName: string;
  beverageType: string;
  beverageSize: string;
  price: number;
  count?: number;
  showQuantity?: boolean;
}

const BeverageItem = ({
  beverageName,
  beverageType,
  beverageSize,
  price,
  count,
  showQuantity,
}: Props) => {
  return (
    <>
      <table className="table table-dark">
        <tbody>
          <tr>
            <th scope="row">{beverageName}</th>
            <td>{beverageType}</td>
            <td>{beverageSize}</td>
            <td>
              {" "}
              {"R "}
              {price}
            </td>
            {showQuantity && count && (
              <td>
                {"Quantity: "}
                {count}
              </td>
            )}
          </tr>
        </tbody>
      </table>
    </>
  );
};

export default BeverageItem;
