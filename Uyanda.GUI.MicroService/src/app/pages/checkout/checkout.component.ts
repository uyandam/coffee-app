import { Component, OnInit } from '@angular/core';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {

  constructor(private _cartService: CartService) { }

  ngOnInit(): void {
    console.log(`cart size ${this._cartService.getCart().length}`);
    
  }

}
