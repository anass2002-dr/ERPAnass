
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Account, AccountType } from 'src/app/models/Finance/Account';
import { AccountService } from 'src/app/Services/Finance/Account.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-add-account',
    templateUrl: './add-account.component.html',
    styleUrls: ['./add-account.component.css'],
    standalone: false
})
export class AddAccountComponent implements OnInit {
    @Input() account?: Account;
    accountForm: FormGroup;
    showAlert: boolean = false;
    isUpdateMode: boolean = false;
    id: string = "";
    breadcrumbs: any[] = [];

    // Convert Enum to Array for Dropdown
    accountTypes = Object.keys(AccountType)
        .filter(key => !isNaN(Number(key)))
        .map(key => ({ id: Number(key), name: AccountType[Number(key)] }));


    constructor(private fb: FormBuilder, private route: ActivatedRoute, private router: Router, private accountService: AccountService) {
        this.accountForm = this.fb.group({
            accountCode: ['', Validators.required],
            accountName: ['', Validators.required],
            type: [null, Validators.required],
            isAcitve: [true]
        });
    }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);

        this.route.paramMap.subscribe(params => {
            this.id = params.get('id') || "";
            if (this.id) {
                this.isUpdateMode = true;
                this.accountService.getAccountById(parseInt(this.id)).subscribe(account => {
                    this.account = account;
                    this.accountForm.patchValue(account);
                });
            }
        });
    }

    onSubmit() {
        if (this.accountForm.valid) {
            const formValue = this.accountForm.value;
            // Ensure type is a number
            formValue.type = Number(formValue.type);

            const account: Account = { ...this.account, ...formValue };

            if (this.isUpdateMode) {
                this.accountService.updateAccount(account).subscribe(response => {
                    console.log('Account updated successfully', response);
                    this.router.navigate(['Finance/list-account']);
                }, error => {
                    console.error('Error updating account', error);
                    this.showAlert = true;
                });
            } else {
                this.accountService.createAccount(account).subscribe(response => {
                    console.log('Account created successfully', response);
                    this.router.navigate(['Finance/list-account']);
                }, error => {
                    console.error('Error creating Account', error);
                    this.showAlert = true;
                });
            }
        } else {
            console.log('Form not valid');
            this.showAlert = true;
        }
    }

    onReset() {
        this.accountForm.reset();
        this.showAlert = false;
    }

    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb);
    }
    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list);
    }
}
