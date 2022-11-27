import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Beverage } from 'src/app/models/beverage.model';
import { CoffeeShopService } from 'src/app/services/coffee-shop.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html'
})
export class MenuComponent implements OnInit {
  

  public menu: Beverage[] = [];

  constructor(private _coffeeShopService: CoffeeShopService) { }

  ngOnInit(): void {
    this._coffeeShopService.menu()
    .subscribe((element) => {
      console.log(element);
      
    });
  }

}
