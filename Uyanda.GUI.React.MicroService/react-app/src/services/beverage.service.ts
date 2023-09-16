import { log } from "console";
import { Beverage } from "../models/menu.model";
import { menuBaseUrl } from "../utils/constants";


// Assuming the Beverage interface is already defined
// and the API endpoint is https://example.com/api/beverages

const menuUrl = menuBaseUrl + "menu";

async function getMenu() {
  try {
    const response = await fetch (menuUrl, {
      method: 'POST',
      body: '{}',
      headers : {
        'Content-Type': 'application/json',
        Accept: 'appllication/json',
      },
    });

    if(!response.ok){
      throw new Error(`Error! status: ${response.status}`);
    }

    const result = (await response.json());

    return result;

  } catch(error) {
    console.log(error);
    return error;
  }
}

export default getMenu;