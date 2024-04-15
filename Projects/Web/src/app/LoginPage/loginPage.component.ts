import { Component, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'login-page',
  templateUrl: './loginPage.component.html',
  styleUrls: ['./loginPage.component.css']
})
export class LoginPageComponent {
  Title: string = 'angularproject3';
  image: string = "";
  currentImageIndex = 0;

  readonly APIUrl = "http://localhost:7127/User";
  notes: any = [];

  images = [
    'assets/images/wallpapers1.jpg',
    'assets/images/wallpapers2.jpg',
    'assets/images/wallpapers3.jpg',
    'assets/images/wallpapers4.jpg',
  ].map(img => ({ backgroundImage: `url(${img.replace(/\\/g, '/')})` }));

  styles = this.images.map(img => ({
    backgroundPosition: 'center center',
    backgroundRepeat: 'no-repeat',
    backgroundSize: 'cover',
    ...img
  }));
  constructor(private http: HttpClient, private router: Router) {

  }
  nextImage() {
    this.currentImageIndex = (this.currentImageIndex + 1) % this.images.length;
  }
 
  ngOnInit() {
    
    setInterval(() => {
      this.nextImage();
    }, 4000);
  }

  
  registry() {
    this.router.navigate(['registry']);
  }

}
