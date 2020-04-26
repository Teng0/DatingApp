import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-weatherForecast',
  templateUrl: './weatherForecast.component.html',
  styleUrls: ['./weatherForecast.component.css']
})
export class WeatherForecastComponent implements OnInit {
  values :any;


  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

  getValues(){
    this.http.get("http://localhost:5000/WeatherForecast").subscribe(response=>{
      this.values = response;
    },err=>{
      console.log(err);
    })

  }

}
