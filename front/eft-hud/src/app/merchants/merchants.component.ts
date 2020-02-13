import { Component, OnInit, OnDestroy } from '@angular/core';
import { MerchantsService, Merchant } from '../services/merchants/merchants.service';
import {  takeUntil } from 'rxjs/operators';
import { Subject } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-merchants',
  templateUrl: './merchants.component.html',
  styleUrls: ['./merchants.component.scss']
})
export class MerchantsComponent implements OnInit, OnDestroy {
  imagesPath : string = "/assets/images/merchants/";

  merchants: Merchant[] = [];
  destroy$: Subject<boolean> = new Subject<boolean>();

  constructor(private merchantService: MerchantsService, private router : Router) { }

  ngOnInit() {

    this.merchantService.getMerchants().pipe(takeUntil(this.destroy$)).subscribe((data: Merchant[])=>{
      console.log(data);
      this.merchants = data;
    })  
  }
  ngOnDestroy() {
    this.destroy$.next(true);
    // Unsubscribe from the subject
    this.destroy$.unsubscribe();
  }

  public loadQuestsForMerchant(merchant : Merchant){
    this.router.navigate(['merchants/quest-list/' , merchant.id]);
  }

}
