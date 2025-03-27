export interface Purchase {
  idPurchase?: number;
  purchaseRef?: string;
  totalAmount?: number;
  TotalPayment?: number;
  idCurrency?: number;
  paymentStatus?: string;
  paymentDate?: Date;
  purchaseDate?: Date;
  createdAt?: Date;
  updatedAt?: Date;
  remarks?: string;
  idSupplier?: number;
  isActive?: boolean;
  currencyName?: string;
  supplierName?: string;

  // Additional Fields
  purchaseStatus?: string; // e.g., "Pending", "Approved", "Received"
  expectedDeliveryDate?: Date;
  actualDeliveryDate?: Date;
  shippingAddress?: string;
  purchaseType?: string; // e.g., "Raw Material", "Services"
  discountAmount?: number;
  discountPercentage?: number;
  taxRate?: number;
  totalTaxAmount?: number;
  exchangeRate?: number;
  approvedBy?: string;
  approvalDate?: Date;
  paymentTerms?: string; // e.g., "Net 30", "Net 60"
  purchaseChannel?: string; // e.g., "Online", "Offline"
}
