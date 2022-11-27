import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Beverage } from 'src/app/models/beverage.model';
import { CartService } from 'src/app/services/cart.service';
import { CoffeeShopService } from 'src/app/services/coffee-shop.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html'
})
export class MenuComponent implements OnInit {
  

  public menu: Beverage[] = [];

  constructor(private _coffeeShopService: CoffeeShopService, private _cartService: CartService) { }

  ngOnInit(): void {
    this._coffeeShopService.menu()
    .subscribe((element) => {
      
      this.menu = element;

      
      
    });
  }

  addToCart(element: Beverage){

    //deep copy

    var copiedElement = JSON.parse(JSON.stringify(element));

    this._cartService.addToCart(copiedElement);
  }


}
