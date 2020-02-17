import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MerchantsComponent } from './merchants/merchants.component';
import { HideoutComponent } from './hideout/hideout.component';
import { CustomNavbarComponent } from './custom-navbar/custom-navbar.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { HttpClientModule } from '@angular/common/http';
import { QuestListComponent } from './quest-list/quest-list.component';
import { CustomMaterialModule } from './material-module';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    AppComponent,
    MerchantsComponent,
    HideoutComponent,
    CustomNavbarComponent,
    PageNotFoundComponent,
    QuestListComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CustomMaterialModule,
    HttpClientModule,
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
