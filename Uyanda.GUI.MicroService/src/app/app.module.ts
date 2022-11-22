import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { AppRoutingModule } from './app-routing.module';
import { PagesComponent } from './pages/pages.component';
import { HeaderComponent } from './pages/header/header.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { ApiCallService } from './services/api-call.service';
import { ConstantsService } from './services/constants.service';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    PagesComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule ,
    HttpClientModule
  ],
  providers: [
    ApiCallService,
    ConstantsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
