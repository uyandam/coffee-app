import { Beverage } from "../models/menu.model";
import { menuBaseUrl } from "../utils/constants";


// Assuming the Beverage interface is already defined
// and the API endpoint is https://example.com/api/beverages

const menuUrl = menuBaseUrl + "menu";
// Create a function that makes a POST request and returns a Promise of Beverage[]
export function getMenu(data: any): Promise<Beverage[]> {
    // Use the fetch API to make the request
    return fetch(menuUrl, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(data),
    })
      .then((response) => {
        // Check if the response is ok
        if (response.ok) {
          // Return the response as JSON
          return response.json();
        } else {
          // Throw an error with the status text
          throw new Error(response.statusText);
        }
      })
      .then((json) => {
        // Return the JSON as a Beverage[] interface
        return json as Beverage[];
      });
  }


  // Use the function to post some data and get the result
  getMenu({})
    .then((result) => {
      // Log the result to the console
      console.log(result);
    })
    .catch((error) => {
      // Handle any errors
      console.error(error);
    });
  

//   // Use the function to post some data and get the result
//   getMenu([
//     { name: "Coffee", type: "Hot", size: "Small", price: 15 },
//     { name: "Tea", type: "Hot", size: "Large", price: 20 },
//   ])
//     .then((result) => {
//       // Log the result to the console
//       console.log(result);
//     })
//     .catch((error) => {
//       // Handle any errors
//       console.error(error);
//     });
  