import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { JwtHelperService } from '@auth0/angular-jwt';
import { BehaviorSubject } from 'rxjs';
import {map} from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = environment.apiUrl;
  jwtHelper = new JwtHelperService();
  decodedToken: any;
  Hospital = new BehaviorSubject<string>('0');
  currentHospital = this.Hospital.asObservable();

constructor(private http: HttpClient) { }

changeCurrentHospital(sh: string) { this.Hospital.next(sh); }

login(model: any) {
    return this.http.post(this.baseUrl + 'auth/login', model).pipe(
        map((response: any) => {
            const r = response;
            if (releaseEvents) {
                localStorage.setItem('token', r.token);
                this.decodedToken = this.jwtHelper.decodeToken(r.token);
                console.log(this.decodedToken);
            }
        })
    );
}

register(model: any) { return this.http.post(this.baseUrl + 'auth/register', model);}

loggedIn() {
    const token = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
}

}
