import { Injectable } from "@angular/core";
import { Invoice } from "../models/invoice.model";
import { CartService } from "./cart.service";


@Injectable()
export class InvoiceService {

    private _invoice: Invoice  [] = []
    // private _cart 

    constructor(private _cart: CartService){}

    generateInvoice (): void {
        this._invoice[0].cart = this._cart.getCart()
        this._invoice[0].totalCost = this.calculateTotalCost();
    }

    private calculateTotalCost() : number{

        let totalCost  = 0;

        for (let i = 0; i < this._cart.getCart().length; i++){
            totalCost = totalCost + this._cart.getCart()[i].price.price; 
        }

        return totalCost;
    }

}