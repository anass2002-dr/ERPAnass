import { Sale } from '../Sale/Sale';
import { Customer } from '../Customer/Customer';
import { Purchase } from '../Purchase/Purchase';
import { Supplier } from '../Supplier/Supplier';
import { Article } from '../Article/Article';

export interface Invoice {
    idInvoice?: number;
    invoiceNumber: string;
    issueDate: Date;
    dueDate: Date;
    totalAmount: number;
    taxAmount: number;
    status: string; // Draft, Open, Paid, Overdue
    invoiceType: string; // Sale, Purchase

    saleId?: number;
    sale?: Sale;

    customerId?: number;
    customer?: Customer;

    purchaseId?: number;
    purchase?: Purchase;

    supplierId?: number;
    supplier?: Supplier;

    invoiceDetails?: InvoiceDetails[];
}

export interface InvoiceDetails {
    idInvoiceDetail?: number;
    quantity: number;
    price: number;
    taxRate: number;
    total: number;

    invoiceId?: number;

    articleId?: number;
    article?: Article;
}
