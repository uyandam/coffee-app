import { Injectable } from "@angular/core";


@Injectable()
export class ConstantsService {
    private baseUrl = "https://localhost:7009/api/GateWay";

    constructor (){}

    getBaseUrl() {
        return this.baseUrl;
    }

}