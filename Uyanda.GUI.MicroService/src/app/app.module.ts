import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './pages/header/header.component';
import { MenuComponent } from './pages/menu/menu.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from  '@angular/common/http';
import { CoffeeShopService } from './services/coffee-shop.service';
import { CartService } from './services/cart.service';
import { CartComponent } from './pages/cart/cart.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    MenuComponent,
    CartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule 
  ],
  providers: [
    CoffeeShopService,
    CartService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
