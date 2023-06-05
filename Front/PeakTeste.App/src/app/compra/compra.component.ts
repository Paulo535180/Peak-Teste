import { Component } from '@angular/core';

@Component({
  selector: 'app-compra',
  templateUrl: './compra.component.html',
  styleUrls: ['./compra.component.scss']
})
export class CompraComponent {

  ngOnInit(): void {
    this.getCompras();

  }

  public compras: any;

  public getCompras(): any {
    this.compras
  }
}
