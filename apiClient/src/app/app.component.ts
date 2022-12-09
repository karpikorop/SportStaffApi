import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Api';
  results: any;
  income: any;

  

  constructor(http: HttpClient){
    const pathItem = 'https://localhost:7115/api/Item';
    
    const pathSale = 'https://localhost:7115/api/Sale';

    this.results = http.get<any>(pathItem).subscribe(data => {
      this.results = data;
    })
    this.income = http.get<any>(pathSale).subscribe(data => {
      this.income = data;
    })
    

  }
/*
  sellId: any;
  sellIncome: any;
  public putOnClick(){

    
    const body = { 
      id: 1,
      income: 1
    }

    body.id = this.sellId;
    body.income = this.sellIncome;
    this.httpA.put<any>('https://localhost:7115/api/Sale', body).subscribe();
    
    return 1;
  }*/
}

