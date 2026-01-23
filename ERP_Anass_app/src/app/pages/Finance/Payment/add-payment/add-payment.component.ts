import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { PaymentService } from 'src/app/Services/Finance/Payment.service';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';
import { BankAccountService } from 'src/app/Services/Finance/BankAccount.service';

@Component({
  selector: 'app-add-payment',
  templateUrl: './add-payment.component.html',
  styleUrls: ['./add-payment.component.css'],
  standalone: false
})
export class AddPaymentComponent implements OnInit {
  paymentForm: FormGroup;
  invoices: any[] = [];
  bankAccounts: any[] = [];

  constructor(
    private fb: FormBuilder,
    private paymentService: PaymentService,
    private invoiceService: InvoiceService,
    private bankAccountService: BankAccountService,
    private router: Router
  ) {
    this.paymentForm = this.fb.group({
      referenceNumber: ['', Validators.required],
      paymentDate: [new Date(), Validators.required],
      paymentMethod: ['Transfer', Validators.required],
      amount: [0, [Validators.required, Validators.min(0)]],
      invoiceId: [null],
      idBankAccount: [null, Validators.required]
    });
  }

  ngOnInit(): void {
    this.loadData();
    this.onInvoiceChange();
  }

  loadData() {
    this.invoiceService.getInvoices().subscribe(data => this.invoices = data);
    this.bankAccountService.getBankAccounts().subscribe(data => this.bankAccounts = data);
  }

  onInvoiceChange() {
    this.paymentForm.get('invoiceId')?.valueChanges.subscribe(invoiceId => {
      if (invoiceId) {
        const invoice = this.invoices.find(i => i.idInvoice === invoiceId);
        if (invoice) {
          this.paymentForm.patchValue({
            amount: invoice.totalAmount // Pre-fill amount
          });
        }
      }
    });
  }

  onSubmit() {
    if (this.paymentForm.valid) {
      this.paymentService.createPayment(this.paymentForm.value).subscribe(() => {
        this.router.navigate(['/Finance/Payment/Payment-List']);
      });
    }
  }
}
