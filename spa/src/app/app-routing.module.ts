import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CardioHelpComponent } from './CardioHelp/CardioHelp.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { OviComponent } from './Ovi/Ovi.component';
import { SoaComponent } from './Soa/Soa.component';
import { WaitlistComponent } from './Waitlist/Waitlist.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: '', component: HomeComponent },
  { path: 'login', component: LoginComponent },
  { path: 'soa', component: SoaComponent },
  { path: 'waitlist', component: WaitlistComponent },
  { path: 'ovi', component: OviComponent },
  { path: 'cardiohelp', component: CardioHelpComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
