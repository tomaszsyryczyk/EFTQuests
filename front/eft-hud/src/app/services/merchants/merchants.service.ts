import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse} from '@angular/common/http';

import {throwError} from 'rxjs';
import {retry, catchError} from 'rxjs/operators';

export interface Merchant {
  id: number;
  name: string;
  iconName: string;
  quests: Quest[];
}

export interface Quest {
  id: number;
  name: string;
  merchantId: number;
  requirements: string[];
  itemRequirements: QuestItemRequirement[];
  rewards: string[];
}

export interface QuestItemRequirement {
  id: number;
  name: string;
  iconName: string;
  count: number;
  findInRaid: boolean;
}

@Injectable({
  providedIn: 'root'
})

export class MerchantsService {
  private REST_API_SERVER = 'http://localhost:8081/api/';
  private REST_API_MERCHANTS = `${this.REST_API_SERVER}merchants/`;
  private REST_API_QUESTS = `${this.REST_API_SERVER}quests/merchant/`;

  constructor(private http: HttpClient) {
  }

  handleError(error: HttpErrorResponse) {
    let errorMessage = 'Unknown error!';
    errorMessage = error.error instanceof ErrorEvent
      ? `Error: ${error.error.message}`
      : `Error Code: ${error.status}\nMessage: ${error.message}`;


    console.log(errorMessage);
    return throwError(errorMessage);
  }

  public getMerchants() {
    return this.http.get<Merchant[]>(this.REST_API_MERCHANTS).pipe(retry(3), catchError(this.handleError));
  }

  public getMerchant(id: number) {
    const url = this.REST_API_MERCHANTS + id;
    return this.http.get<Merchant>(url).pipe(retry(3), catchError(this.handleError));
  }

  public getMerchantQuest(id: number) {
    const url = this.REST_API_QUESTS + id;
    console.log(url);
    return this.http.get(url);
  }

}
