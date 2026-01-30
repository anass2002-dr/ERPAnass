import { Article } from "../Article/Article";
import { TaxConfiguration } from "../TaxConfiguration/TaxConfiguration";

export interface PurchaseDetails {
  idPurchaseDetails?: number;
  idArticle?: number;
  quantity?: number;
  unitPrice?: number;
  totalPrice?: number;
  taxAmount?: number;
  quality?: string;
  isActive?: boolean;
  idPurchase?: number;

  // Relations
  article?: Article;
  taxConfig?: TaxConfiguration;
  idTaxConfig?: number;

  // Additional Fields
  lineItemStatus?: string;
  unitOfMeasure?: string;
  lineDiscountAmount?: number;
  lineDiscountPercentage?: number;
  batchNumber?: string;
  expiryDate?: Date;
  serialNumber?: string;
  warehouseLocation?: string;
  receivedQuantity?: number;
  rejectedQuantity?: number;
  lineTaxRate?: number;
  extraTax?: number;
}
