import {NgModule} from '@angular/core';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatTabsModule} from '@angular/material/tabs';

@NgModule({
  exports: [
    MatSidenavModule,
    MatTooltipModule,
    MatButtonModule,
    MatToolbarModule,
    MatTabsModule
  ]
})
export class CustomMaterialModule {}