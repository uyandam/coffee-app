import { Injectable } from "@angular/core";
import { Beverage } from "../models/beverage.model";

@Injectable()
export class CartService {
    private _cart: Beverage [] = [];
    
    constructor(){}

    addToCart(element: Beverage) {

        const isElementFound = this._cart.some((item: Beverage) => {
            return item.id === element.id;
        });

        let itemIndex = this._cart.findIndex((item: Beverage) => element.id == item.id);

        console.log(`element count value ${element.count}`);
        
        if (itemIndex !== -1) {
            this._cart[itemIndex].count += element.count;
        } else {
            this._cart.push(element);
        }

        console.log(this._cart);
        
        
    }


}