import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgModel } from '@angular/forms';
import { Beverage } from 'src/app/models/beverage.model';
import { CartService } from 'src/app/services/cart.service';
import { CoffeeShopService } from 'src/app/services/coffee-shop.service';



@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html'
})
export class MenuComponent implements OnInit {
  
  defaultCount: number = 0;

  public menu: Beverage[] = [];

  constructor(private _coffeeShopService: CoffeeShopService, private _cartService: CartService) { }

  ngOnInit(): void {
    this._coffeeShopService.menu()
    .subscribe((element) => {
      
      this.menu = element;

    });
    this.defaultCount = 0;
  }

  addToCart(element: Beverage): void{

    //deep copy

    var copiedElement = JSON.parse(JSON.stringify(element));

    this._cartService.addToCart(copiedElement);
  }

  removeFromCart(element: Beverage): void {

    //deep copy
    var copiedElement = JSON.parse(JSON.stringify(element));

    this._cartService.removeFromCart(copiedElement);

    console.log(this._cartService.getCart());
    

  }


}
