import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductTypeListComponent } from './product-type-list/product-type-list.component';
import { ColoursComponent } from './colours/colours.component';
import { ProductCreateComponent } from './product-create/product-create.component';

const routes: Routes = [
  { path: 'products', component: ProductListComponent },
  { path: 'products/create', component: ProductCreateComponent },
  { path: 'product-types', component: ProductTypeListComponent },
  { path: 'colours', component: ColoursComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
