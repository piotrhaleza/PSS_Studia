import { HttpClient } from '@angular/common/http';
import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { IRegistry } from './registry';

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
    
    var formData = new FormData();
    formData.append("login", this.login);
    formData.append("password", this.password);
    this.http.post<IRegistry>(this.APIUrl + '/AddUser', formData).subscribe(data  => {
      if (data.Succes) {
        this.router.navigate(['login']);
      } else {
        alert('Wystąpił błąd: ' + data.Message);
      }
    }, error => {
      console.error('Wystąpił błąd podczas wysyłania żądania:', error);
      alert('Wystąpił błąd podczas wysyłania żądania.');
    });
  }


}
