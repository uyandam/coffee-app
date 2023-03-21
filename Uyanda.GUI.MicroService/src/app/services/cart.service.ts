import { Injectable } from "@angular/core";
import { Beverage } from "../models/beverage.model";

@Injectable()
export class CartService {
    private _cart: Beverage [] = [];
    
    constructor(){}

    addToCart(element: Beverage): void {

        let itemIndex = this.elementIndext(element);

        console.log(`element count value ${element.count}`);
        
        if (itemIndex !== -1) {
            this._cart[itemIndex].count += element.count;
        } else {
            this._cart.push(element);
        }

        console.log(this._cart);
        
    }

    removeFromCart(element: Beverage): void{

        let itemIndex = this.elementIndext(element);

        if (itemIndex === -1){
            return;
        }

        if (this._cart[itemIndex].count === 1){

            this._cart.splice(itemIndex, 1);

            return;
        }

        this._cart[itemIndex].count -= 1;

        return;

    }

    getCart(): Beverage []{
        
        //deep copy
        var copiedElement = JSON.parse(JSON.stringify(this._cart));

        return copiedElement;
        
    }

    getItemCount(element: Beverage): number {
        let itemIndex = this.elementIndext(element);

        if (itemIndex === -1){
            return 0;
        }

        return this._cart[itemIndex].count;

    }

    //check if item exists in cart

    isElementFound(element: Beverage): boolean {

        return this._cart.some((item: Beverage) => {
            return item.id === element.id;
        });

    }


    private elementIndext(element: Beverage): number {
        const isElementFound = this._cart.some((item: Beverage) => {
            return item.id === element.id;
        });

        let itemIndex = this._cart.findIndex((item: Beverage) => element.id == item.id);

        return itemIndex;
    }


}