import { Component,ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  Title: string = 'angularproject3';

  constructor(private router: Router)
  {
  
  }
  ngOnInit(): void {
    
  }
 
}
