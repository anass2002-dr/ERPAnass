
import { Component, Input, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { JournalEntry, JournalEntryStatus } from 'src/app/models/Finance/JournalEntry';
import { JournalEntryService } from 'src/app/Services/Finance/JournalEntry.service';
import { AccountService } from 'src/app/Services/Finance/Account.service';
import { Account } from 'src/app/models/Finance/Account';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-add-journal-entry',
    templateUrl: './add-journal-entry.component.html',
    styleUrls: ['./add-journal-entry.component.css'],
    standalone: false
})
export class AddJournalEntryComponent implements OnInit {
    @Input() entry?: JournalEntry;
    entryForm: FormGroup;
    showAlert: boolean = false;
    isUpdateMode: boolean = false;
    id: string = "";
    breadcrumbs: any[] = [];
    accounts: Account[] = [];

    constructor(
        private fb: FormBuilder,
        private route: ActivatedRoute,
        private router: Router,
        private journalEntryService: JournalEntryService,
        private accountService: AccountService
    ) {
        this.entryForm = this.fb.group({
            entryDate: [new Date(), Validators.required],
            description: ['', Validators.required],
            status: [JournalEntryStatus.Draft],
            journalDetails: this.fb.array([])
        });
    }

    get journalDetails() {
        return this.entryForm.get('journalDetails') as FormArray;
    }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);

        // Load Accounts for dropdown
        this.accountService.getAccounts().subscribe(data => {
            this.accounts = data;
        });

        this.route.paramMap.subscribe(params => {
            this.id = params.get('id') || "";
            if (this.id) {
                this.isUpdateMode = true;
                this.journalEntryService.getJournalEntryById(parseInt(this.id)).subscribe(entry => {
                    this.entry = entry;
                    this.entryForm.patchValue({
                        entryDate: entry.entryDate,
                        description: entry.description,
                        status: entry.status
                    });

                    // Clear existing and add lines from entry
                    this.journalDetails.clear();
                    if (entry.journalDetails) {
                        entry.journalDetails.forEach(detail => {
                            this.journalDetails.push(this.fb.group({
                                idJournalDetails: [detail.idJournalDetails],
                                accountID: [detail.accountID, Validators.required],
                                description: [detail.description],
                                debitAmount: [detail.debitAmount],
                                creditAmount: [detail.creditAmount]
                            }));
                        });
                    }
                });
            } else {
                // Add initial empty line
                this.addDetailLine();
            }
        });
    }

    addDetailLine() {
        const detailGroup = this.fb.group({
            accountID: [null, Validators.required],
            description: [''],
            debitAmount: [0],
            creditAmount: [0]
        });
        this.journalDetails.push(detailGroup);
    }

    removeDetailLine(index: number) {
        this.journalDetails.removeAt(index);
    }

    get totalDebit(): number {
        return this.journalDetails.controls
            .map(c => c.get('debitAmount')?.value || 0)
            .reduce((a, b) => a + b, 0);
    }

    get totalCredit(): number {
        return this.journalDetails.controls
            .map(c => c.get('creditAmount')?.value || 0)
            .reduce((a, b) => a + b, 0);
    }

    get isBalanced(): boolean {
        return Math.abs(this.totalDebit - this.totalCredit) < 0.01; // Tolerance for float comparison
    }

    onSubmit() {
        if (this.entryForm.valid && this.isBalanced) {
            const formValue = this.entryForm.value;
            const entry: JournalEntry = {
                ...this.entry,
                ...formValue,
                totalDebit: this.totalDebit,
                totalCredit: this.totalCredit
            };

            if (this.isUpdateMode) {
                this.journalEntryService.updateJournalEntry(entry).subscribe(response => {
                    console.log('Entry updated successfully', response);
                    this.router.navigate(['Finance/list-journal-entry']);
                }, error => {
                    console.error('Error updating entry', error);
                    this.showAlert = true;
                });
            } else {
                this.journalEntryService.createJournalEntry(entry).subscribe(response => {
                    console.log('Entry created successfully', response);
                    this.router.navigate(['Finance/list-journal-entry']);
                }, error => {
                    console.error('Error creating entry', error);
                    this.showAlert = true;
                });
            }
        } else {
            console.log('Form not valid or not balanced');
            this.showAlert = true;
        }
    }

    onReset() {
        this.entryForm.reset();
        this.journalDetails.clear();
        this.addDetailLine();
        this.showAlert = false;
    }

    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb);
    }
    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list);
    }
}
