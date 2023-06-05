import { Component } from '@angular/core';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})

export class FormComponent {
  parcelas!: number;
  valor!: number;

  submitForm() {
    // Aqui você pode realizar ações com os valores das parcelas e do valor
    console.log('Parcelas:', this.parcelas);
    console.log('Valor:', this.valor);
  }
}
