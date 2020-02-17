import { Component, OnInit, ViewChild } from '@angular/core';
import {MatSidenav } from '@angular/material/sidenav';
import { Router } from '@angular/router';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  
  @ViewChild('sidenav') sidenav: MatSidenav;

  constructor(private router: Router) {}

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
