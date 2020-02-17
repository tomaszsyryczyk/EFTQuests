import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MerchantsComponent } from './merchants/merchants.component';
import { HideoutComponent } from './hideout/hideout.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { QuestListComponent } from './quest-list/quest-list.component';


const appRoutes: Routes = [
  { path: 'hideout', component: HideoutComponent },
  { path: 'merchants', component: MerchantsComponent },

  { path: '',
    redirectTo: '/hideout',
    pathMatch: 'full'
  },
  { path: '**', component: PageNotFoundComponent }
];


@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
