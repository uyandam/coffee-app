import { Beverage } from "./beverage.model";
import { Customer } from "./customer.model";
import { ExchangeRate } from "./exchangeRate.model";

export interface Invoice {
    id: number;
    cart: Beverage [];
    totalCost: number;
    exchangeRate: ExchangeRate;
    customer: Customer;
}