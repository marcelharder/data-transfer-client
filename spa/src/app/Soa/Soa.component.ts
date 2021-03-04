import { Component, OnInit } from '@angular/core';
import { Class_CABG } from '../_models/Class_CABG';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { SoaService } from '../_services/soa.service';

@Component({
  selector: 'app-Soa',
  templateUrl: './Soa.component.html',
  styleUrls: ['./Soa.component.css']
})
export class SoaComponent implements OnInit {

  listCabg:Array<Class_CABG> = [];

  constructor(
    private alertify:AlertifyService,
    private auth: AuthService, 
    private soa: SoaService) { }

  ngOnInit() {
  }
  aortic_surgery(){this.alertify.message("aortic surgery ..");}
  
  cabg(){
    this.soa.getCabg(this.auth.decodedToken.nameid).subscribe(next => {
      this.listCabg = next;
      this.soa.postCABG(this.listCabg).subscribe(next => {}, error => {this.alertify.error(error)})
    }, error => {this.alertify.error(error)})
  }

  cpb(){this.alertify.message("cpb ..");}


  






}
