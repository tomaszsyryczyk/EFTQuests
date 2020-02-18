import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MerchantsService, Merchant } from '../services/merchants/merchants.service';

@Component({
  selector: 'app-quest-list',
  templateUrl: './quest-list.component.html',
  styleUrls: ['./quest-list.component.scss']
})
export class QuestListComponent implements OnInit {

  @Input()
  merchantId : number;
  merchant : Merchant;
  quests;
  constructor(private route : ActivatedRoute, private merchantService: MerchantsService) { }

  ngOnInit(): void {
    // debugger;
    this.loadQuestForMerchant(this.merchantId);
  }

  loadQuestForMerchant(merchantId: number) {
    this.merchantService.getMerchantQuest(merchantId).subscribe((data: Merchant)=>{
      this.quests = data;
    })
  }

}
