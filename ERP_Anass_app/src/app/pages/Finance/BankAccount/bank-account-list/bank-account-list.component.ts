import { Component, OnInit } from '@angular/core';
import { BankAccountService } from 'src/app/Services/Finance/BankAccount.service';
import { BankAccount } from 'src/app/models/Finance/BankAccount';

@Component({
  selector: 'app-bank-account-list',
  templateUrl: './bank-account-list.component.html',
  styleUrls: ['./bank-account-list.component.css'],
  standalone: false
})
export class BankAccountListComponent implements OnInit {
  bankAccounts: BankAccount[] = [];

  constructor(private bankAccountService: BankAccountService) { }

  ngOnInit(): void {
    this.loadBankAccounts();
  }

  loadBankAccounts() {
    this.bankAccountService.getBankAccounts().subscribe(data => {
      this.bankAccounts = data;
    });
  }

  deleteBankAccount(id: number) {
    if (confirm("Are you sure you want to delete this bank account?")) {
      this.bankAccountService.deleteBankAccount(id).subscribe(() => {
        this.loadBankAccounts();
      });
    }
  }
}
