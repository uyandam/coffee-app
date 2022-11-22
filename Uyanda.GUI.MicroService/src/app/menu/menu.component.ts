import { Component, OnInit } from '@angular/core';
import { Menu } from '../models/menu.model';
import { ApiCallService } from '../services/api-call.service';


@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  constructor(private apiCall: ApiCallService) { }
  menu: Menu [] = [];
  private cart: [] = [];

  ngOnInit(): void {
    
    this.apiCall.menu().subscribe((element: any) => {
      this.menu = element

      console.log(this.menu);
      
    })
        
  }

  addToCart(element: Menu){

    console.log("add to cart method");
    
    console.log(element);
    
  }

}
