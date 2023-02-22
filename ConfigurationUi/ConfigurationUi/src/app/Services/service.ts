import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn: 'root'
})

export class ApiService {
    constructor(private _http:HttpClient){ }

    getMapTypesData(){
        return(this._http.get("http://localhost:5141/map-type"));
    }
    getSubTypes(id:any){
        return(this._http.get(`http://localhost:5141/map-sub-type/get-by-mapType/${id}`))
    }
    addConfiguration(data:any) {
      return this._http.post("http://localhost:5141/configurations",data);
      }
}