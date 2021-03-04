import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { Class_CABG } from "../_models/Class_CABG";

@Injectable({
    providedIn: 'root'
  })
  export class SoaService {
    baseUrl = environment.soaUrl;
    localUrl = environment.apiUrl;
    
    constructor(private http: HttpClient) { }


    getCabg(id: number) { return this.http.get<Class_CABG[]>(this.baseUrl + 'DataTransfer/getCABG/' + id); }
    postCABG(test: Class_CABG[]){return this.http.post(this.localUrl + 'soa/cabgs', test);}



  }