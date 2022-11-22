import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ConstantsService } from './constants.service';


@Injectable()
export class ApiCallService{
    constructor(private http: HttpClient, private constants: ConstantsService) { }

    menu(): any {

        let menuApi  = this.constants.getBaseUrl() + "/menu";

        return this.http.post(menuApi, {})
    }
}