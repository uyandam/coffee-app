import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Beverage } from "../models/beverage.model";


@Injectable()
export class CoffeeShopService {
    private _baseUrl = 'https://localhost:7009/api/Gateway/';

    constructor(private http: HttpClient){

    }


    menu(){
        return this.http.post<Beverage[]>(this._baseUrl + 'menu', {});
    }

}