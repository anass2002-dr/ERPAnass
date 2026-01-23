import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { BankAccountService } from 'src/app/Services/Finance/BankAccount.service';

@Component({
  selector: 'app-add-bank-account',
  templateUrl: './add-bank-account.component.html',
  styleUrls: ['./add-bank-account.component.css'],
  standalone: false
})
export class AddBankAccountComponent implements OnInit {
  bankForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private bankAccountService: BankAccountService,
    private router: Router
  ) {
    this.bankForm = this.fb.group({
      bankName: ['', Validators.required],
      accountNumber: ['', Validators.required],
      iban: ['', Validators.required],
      swiftCode: ['', Validators.required],
      currentBalance: [0, [Validators.required, Validators.min(0)]]
    });
  }

  ngOnInit(): void {
  }

  onSubmit() {
    if (this.bankForm.valid) {
      this.bankAccountService.createBankAccount(this.bankForm.value).subscribe(() => {
        this.router.navigate(['/Finance/BankAccount/BankAccount-List']);
      });
    }
  }
}
