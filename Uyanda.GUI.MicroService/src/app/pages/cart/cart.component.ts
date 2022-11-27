import { Component, OnInit } from '@angular/core';
import { Beverage } from 'src/app/models/beverage.model';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  _cart: Beverage [] = [];

  constructor(private _cartService: CartService) {
    this._cart = _cartService.getCart();
   }

  ngOnInit(): void {
    console.log(this._cartService.getCart());
    
  }

  getCart(): Beverage[] {
    return this._cart;
  }

}
