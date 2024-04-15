import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms'


import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ProductListComponent } from './products/product-list.component';
import { ConvertToSpacesPipe } from './convert-to-spaces.pipe';
import { StarComponent } from './shared/star.component';
import { RouterModule } from '@angular/router';
import { RegistryComponent } from './registry/registry.component';
import { LoginPageComponent } from './LoginPage/loginPage.component';
import { MaterialModule } from './material-module';
import { MenubarComponent } from './menubar/menubar.component'
@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ConvertToSpacesPipe,
    StarComponent,
    LoginPageComponent,
    RegistryComponent,
    MenubarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    MaterialModule,
    RouterModule.forRoot([
      { path: 'login', component: LoginPageComponent },
        {path: 'registry', component: RegistryComponent}
      ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
