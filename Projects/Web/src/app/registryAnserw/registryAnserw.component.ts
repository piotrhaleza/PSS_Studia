import { HttpClient } from '@angular/common/http';
import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'registry-root',
  templateUrl: './registry.component.html',
  styleUrls: ['./registry.component.css']
})
export class RegistryComponent {

  readonly APIUrl = "http://localhost:7127/User";
  notes: any = [];

  comunicate: string = '';
  login: string = '';
  password: string = '';
  passwordConfirm: string = '';
 email: string = '';
  

  constructor(private http: HttpClient, private router: Router) {

  }

  registry() {

    

    if (this.password === this.passwordConfirm) {
      this.comunicate = '';
      this.tryRegister();
    }
    else
      this.comunicate = "Hasła różnią się od siebie"
    
  }

  tryRegister() {
    
  }


}
