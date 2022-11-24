import { Injectable } from "@angular/core";
import { Menu } from "../models/menu.model";

@Injectable()
export class CartService {
    cart: Menu [] = [];
}