import { Component, OnInit } from '@angular/core';
import { ApiService } from '../Services/service';
import { HttpClient } from '@angular/common/http';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-map-configuration',
  templateUrl: './map-configuration.component.html',
  styleUrls: ['./map-configuration.component.css']
})
export class MapConfigurationComponent implements OnInit {

    constructor(private _api_service:ApiService){ }
    mapTypesValues:any;
    mapSubTypes:any;
    selectedMapType:any;
    selectedMapSubType:any;
    configurationObject: any;
    geoFencing: any;
    inputValue: any;
    ngOnInit(): void {
    this._api_service.getMapTypesData().subscribe((result: any) => {this.mapTypesValues = result});
  }
  getSubTypes(event:any){
    this.selectedMapType = event.target.value;
    this._api_service.getSubTypes(event.target.value).subscribe((result: any)=> {this.mapSubTypes = result});
  }
  getSelectedValue(event:any){
    this.selectedMapSubType = event.target.value;
  }
  GetStatus(event:any){
    this.geoFencing = event.target.checked;
  }
  onClickSubmit(data:any){
    this.configurationObject = {
      "clusterRadius": data.cluster_radius,
      "geoFencing": this.geoFencing,
      "timeBuffer": data.time_buffer,
      "locationBuffer": data.location_buffer,
      "duration": data.duration,
      "mapTypeId": this.selectedMapType,
      "mapSubTypeId": this.selectedMapSubType
    }
    this._api_service.addConfiguration(this.configurationObject).subscribe((result)=> {
      if(result == 1){
        alert("Saved Successfully");
      }
    });

  }
  getValidated(event:any){
    this.inputValue = `"${event.target.value}"`;
    if(this.inputValue.includes(".")){
      if(this.inputValue.split(".")[1].length-1 > 3){
        alert("You must enter a number has a 3 decimal numbers only !")
        event.target.value = "";
      }
    }
  }
  reset(){
    for(let i = 0; i < document.getElementsByTagName("input").length - 2; i++){
        document.getElementsByTagName("input")[i].value = "";
    }
    document.getElementsByTagName("select")[0].value = "";
    document.getElementsByTagName("select")[1].value = "";
  }
}

