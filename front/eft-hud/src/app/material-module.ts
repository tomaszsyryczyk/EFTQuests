import {NgModule} from '@angular/core';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatTabsModule} from '@angular/material/tabs';
import { MatIconModule } from '@angular/material/icon';

@NgModule({
  exports: [
    MatSidenavModule,
    MatTooltipModule,
    MatButtonModule,
    MatToolbarModule,
    MatTabsModule,
    MatIconModule,
  ]
})
export class CustomMaterialModule {}