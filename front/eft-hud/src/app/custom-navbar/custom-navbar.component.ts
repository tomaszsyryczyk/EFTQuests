import { Component, OnInit, ViewChild } from '@angular/core';
import {MatSidenav} from '@angular/material/sidenav';
import { Router } from '@angular/router';

@Component({
  selector: 'app-custom-navbar',
  templateUrl: './custom-navbar.component.html',
  styleUrls: ['./custom-navbar.component.scss']
})
export class CustomNavbarComponent implements OnInit {

  @ViewChild('sidenav') sidenav: MatSidenav;
  constructor(public router: Router) { }

  ngOnInit(): void {
  }

  close() {
    this.sidenav.close();
  };

  hideout(){
    this.router.navigate(['hideout']);
    this.close();
  };

  merchants(){
    this.router.navigate(['merchants']);
    this.close();
  };

}
