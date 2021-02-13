import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AlertifyService } from './_services/alertify.service';
import { AuthService } from './_services/auth.service';

import { JwtModule } from '@auth0/angular-jwt';
import { AuthGuard } from './_guards/auth.guard';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { SoaComponent } from './Soa/Soa.component';
import { WaitlistComponent } from './Waitlist/Waitlist.component';
import { OviComponent } from './Ovi/Ovi.component';
import { CardioHelpComponent } from './CardioHelp/CardioHelp.component';



export function tokenGetter() { return localStorage.getItem('token'); }

@NgModule({
   declarations: [
      AppComponent,
      HomeComponent,
      NavMenuComponent,
      LoginComponent,
      SoaComponent,
      WaitlistComponent,
      OviComponent,
      CardioHelpComponent
   ],
   imports: [
      HttpClientModule,
      BrowserModule,
      FormsModule,
      AppRoutingModule,
      BrowserAnimationsModule,
      JwtModule.forRoot({
         config: {
             tokenGetter: tokenGetter,
             whitelistedDomains: ['localhost:5000'],
             blacklistedRoutes: ['localhost:5000/api/auth']
         }
     }),
   ],
   providers: [AlertifyService, AuthService, AuthGuard],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
