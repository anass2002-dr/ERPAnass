export interface Sale {
  idSale?: number;
  saleRef?: string;
  totalAmount?: number;
  TotalPayment?: number;
  idCurrency?: number;
  paymentStatus?: string;
  paymentDate?: Date;
  saleDate?: Date;
  createdAt?: Date;
  updatedAt?: Date;
  remarks?: string;
  idCustomer?: number;
  isActive?: boolean;
  currencyName?: string;
  customerName?: string;

  // Additional Fields
  saleStatus?: string; // e.g., "Pending", "Approved", "Received"
  expectedDeliveryDate?: Date;
  actualDeliveryDate?: Date;
  shippingAddress?: string;
  saleType?: string; // e.g., "Raw Material", "Services"
  discountAmount?: number;
  discountPercentage?: number;
  taxRate?: number;
  totalTaxAmount?: number;
  exchangeRate?: number;
  approvedBy?: string;
  approvalDate?: Date;
  paymentTerms?: string; // e.g., "Net 30", "Net 60"
  saleChannel?: string; // e.g., "Online", "Offline"
}
