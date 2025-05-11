import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductTypeListComponent } from './product-type-list/product-type-list.component';
import { ColoursComponent } from './colours/colours.component';
import { ProductCreateComponent } from './product-create/product-create.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ColoursComponent,
    ProductListComponent,
    ProductTypeListComponent,
    ProductCreateComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
