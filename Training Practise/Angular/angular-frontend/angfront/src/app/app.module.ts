import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CHomePageComponent } from './c-home-page/c-home-page.component';
import { CHomeComponent } from './c-home/c-home.component';
import { HomeComponent } from './home/home.component';
import { MarcosComponent } from './marcos/marcos.component';
import { HarshComponent } from './harsh/harsh.component';
import { JamaalComponent } from './jamaal/jamaal.component';
import { GabrielComponent } from './gabriel/gabriel.component';
import { NavbarComponent } from './navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    CHomePageComponent,
    CHomeComponent,
    HomeComponent,
    MarcosComponent,
    HarshComponent,
    JamaalComponent,
    GabrielComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
