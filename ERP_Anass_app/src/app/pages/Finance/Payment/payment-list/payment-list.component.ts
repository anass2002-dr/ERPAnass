import { Component, OnInit } from '@angular/core';
import { PaymentService } from 'src/app/Services/Finance/Payment.service';
import { Payment } from 'src/app/models/Finance/Payment';

@Component({
  selector: 'app-payment-list',
  templateUrl: './payment-list.component.html',
  styleUrls: ['./payment-list.component.css'],
  standalone: false
})
export class PaymentListComponent implements OnInit {
  payments: Payment[] = [];

  constructor(private paymentService: PaymentService) { }

  ngOnInit(): void {
    this.loadPayments();
  }

  loadPayments() {
    this.paymentService.getPayments().subscribe(data => {
      this.payments = data;
    });
  }

  deletePayment(id: number) {
    if (confirm("Are you sure you want to delete this payment?")) {
      this.paymentService.deletePayment(id).subscribe(() => {
        this.loadPayments();
      });
    }
  }
}
