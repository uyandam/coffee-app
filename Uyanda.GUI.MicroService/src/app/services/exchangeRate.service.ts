import { Injectable } from "@angular/core";
import { ExchangeRate } from "../models/exchangeRate.model";

@Injectable()
export class ExchangeRateService {
    private exchangeRate: ExchangeRate 

    constructor() {
        this.exchangeRate = {id: 0, sourceCurrency: "", destinationCurrency : "", exchangeRate : 0}
    }

    setExchangeRate (): void {
        
    }

}