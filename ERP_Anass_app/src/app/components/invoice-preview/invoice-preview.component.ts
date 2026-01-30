import { Component, Inject, OnInit, NgZone } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';
import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';

@Component({
    selector: 'app-invoice-preview',
    templateUrl: './invoice-preview.component.html',
    styleUrls: ['./invoice-preview.component.css'],
    standalone: false
})
export class InvoicePreviewComponent implements OnInit {
    pdfUrl: SafeResourceUrl | null = null;
    loading = true;

    constructor(
        public dialogRef: MatDialogRef<InvoicePreviewComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private invoiceService: InvoiceService,
        private sanitizer: DomSanitizer,
        private ngZone: NgZone
    ) { }

    ngOnInit() {
        this.loadPdfMakeScripts().then(() => {
            console.log('PDFMake scripts loaded successfully');
            if (this.data.invoiceId) {
                this.loadInvoiceData(this.data.invoiceId);
            }
        }).catch(err => {
            console.error('Failed to load PDFMake scripts', err);
            this.loading = false;
        });
    }

    loadPdfMakeScripts(): Promise<void> {
        return new Promise((resolve, reject) => {
            if ((window as any).pdfMake) {
                resolve();
                return;
            }

            const script1 = document.createElement('script');
            script1.src = 'https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.2.7/pdfmake.min.js';
            script1.onload = () => {
                const script2 = document.createElement('script');
                script2.src = 'https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.2.7/vfs_fonts.js';
                script2.onload = () => resolve();
                script2.onerror = () => reject('Could not load vfs_fonts.js');
                document.head.appendChild(script2);
            };
            script1.onerror = () => reject('Could not load pdfmake.min.js');
            document.head.appendChild(script1);
        });
    }

    loadInvoiceData(id: number) {
        console.log('Loading invoice data for ID:', id);
        this.loading = true;
        this.invoiceService.getInvoicePdfData(id).subscribe(data => {
            console.log('Invoice data received:', data);
            this.generatePdf(data);
        }, error => {
            console.error('Error fetching invoice data', error);
            this.loading = false;
        });
    }

    generatePdf(invoice: any) {
        console.log('Starting PDF generation via CDN...');
        const pdfMake = (window as any).pdfMake;

        if (!pdfMake || !pdfMake.vfs) {
            console.error('PDFMake is not fully initialized');
            this.loading = false;
            return;
        }

        try {
            const docDefinition: any = {
                content: [
                    { text: `Invoice #${invoice.invoiceNumber || 'N/A'}`, style: 'header' },
                    {
                        columns: [
                            {
                                width: '*',
                                text: [
                                    { text: 'From:\n', bold: true },
                                    invoice.tenant ? `${invoice.tenant.companyName || ''}\n${invoice.tenant.domain || ''}\n` : 'Company Name\n'
                                ]
                            },
                            {
                                width: '*',
                                text: [
                                    { text: 'To:\n', bold: true },
                                    invoice.customer ? `${invoice.customer.customerName || ''}\n${invoice.customer.address || ''}\n` :
                                        (invoice.supplier ? `${invoice.supplier.supplierName || ''}\n${invoice.supplier.address || ''}\n` : 'Client Name\n')
                                ]
                            }
                        ]
                    },
                    { text: `Date: ${new Date(invoice.issueDate).toLocaleDateString()}`, margin: [0, 10, 0, 0] },
                    { text: `Due Date: ${new Date(invoice.dueDate).toLocaleDateString()}`, margin: [0, 0, 0, 10] },
                    {
                        table: {
                            headerRows: 1,
                            widths: ['*', 'auto', 'auto', 'auto', 'auto'],
                            body: [
                                [{ text: 'Item', style: 'tableHeader' }, { text: 'Quantity', style: 'tableHeader' }, { text: 'Price', style: 'tableHeader' }, { text: 'Tax %', style: 'tableHeader' }, { text: 'Total', style: 'tableHeader' }],
                                ...invoice.invoiceDetails.map((item: any) => [
                                    item.itemName || `Item #${item.articleId || 'N/A'}`,
                                    item.quantity || 0,
                                    { text: (item.price || 0).toFixed(2), alignment: 'right' },
                                    { text: (item.taxRate || 0) + '%', alignment: 'right' },
                                    { text: (item.total || 0).toFixed(2), alignment: 'right' }
                                ])
                            ]
                        },
                        layout: 'lightHorizontalLines',
                        margin: [0, 10, 0, 10]
                    },
                    {
                        columns: [
                            { width: '*', text: '' },
                            {
                                width: 'auto',
                                table: {
                                    body: [
                                        ['Subtotal:', { text: (invoice.totalAmount - invoice.taxAmount).toFixed(2), alignment: 'right' }],
                                        ['Tax:', { text: invoice.taxAmount.toFixed(2), alignment: 'right' }],
                                        [{ text: 'Total:', bold: true }, { text: invoice.totalAmount.toFixed(2), alignment: 'right', bold: true }]
                                    ]
                                },
                                layout: 'noBorders'
                            }
                        ]
                    }
                ],
                styles: {
                    header: { fontSize: 18, bold: true, margin: [0, 0, 0, 10] },
                    tableHeader: { bold: true, fontSize: 12, color: 'black' }
                }
            };

            console.log('DocDefinition created');
            const pdfDocGenerator = pdfMake.createPdf(docDefinition);
            console.log('PDF Generator created');

            pdfDocGenerator.getDataUrl((dataUrl: string) => {
                this.ngZone.run(() => {
                    console.log('Data URL generated, length:', dataUrl.length);
                    this.pdfUrl = this.sanitizer.bypassSecurityTrustResourceUrl(dataUrl);
                    console.log('Safe URL created');
                    this.loading = false;
                });
            });
        } catch (e) {
            console.error('PDF Generation Error:', e);
            this.loading = false;
        }
    }

    close() {
        this.dialogRef.close();
    }
}
