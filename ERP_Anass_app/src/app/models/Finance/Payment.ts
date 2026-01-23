
export interface Payment {
    idPayment?: number;
    amount?: number;
    paymentDate?: Date;
    paymentMethod?: string; // Cash, Check, Transfer, Card
    referenceNumber?: string;
    saleId?: number;
    purchaseId?: number;
    idCashAccount?: number;
    idBankAccount?: number;
    invoiceId?: number;
}
