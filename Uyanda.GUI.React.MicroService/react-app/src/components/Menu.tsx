import Title from "./Title";
import BeverageItem from "./beverageComponents/BeverageItem";
import { Beverage } from "../models/beverage.model";
import RemoveBeverageItem from "./beverageComponents/RemoveBeverageItem";
import AddBeverageItem from "./beverageComponents/AddBeverageItem";

interface Prop {
  title: string;
  beverages: Beverage[] | undefined;
}

const Menu = ({ title = "boom fist", beverages }: Prop) => {
  return (
    <>
      <div>
        <Title title={title} />
      </div>
      <div>
        <table className="table table-dark">
          <thead>
            <tr>
              <th scope="col">Item</th>
              <th scope="col">Type</th>
              <th scope="col">Size</th>
              <th scope="col">Price</th>
            </tr>
          </thead>
        </table>
        <ul className="list-group">
          {beverages &&
            beverages.map((item, index) => (
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
                <div className="container">
                  <div className="row">
                    <div className="col-sm">
                      <RemoveBeverageItem />{" "}
                    </div>

                    <div className="col-sm">
                      <AddBeverageItem />
                    </div>
                  </div>
                </div>

                <div>
                  {/* <RemoveBeverageItem /> <p>{item.count}</p> <AddBeverageItem /> */}
                </div>
              </li>
            ))}
        </ul>
      </div>
    </>
  );
};

export default Menu;
