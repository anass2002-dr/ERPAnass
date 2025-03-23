import { Article } from "../Article/Article";

export interface PurchaseDetails {
  idPurchaseDetails?: number;
  idArticle?: number;
  quantity?: number;
  unitPrice?: number; // Added UnitPrice for clarity
  totalPrice?: number;
  taxAmount?: number;
  quality?: string;
  isActive?: boolean;
  idPurchase?: number;
  article?: Article;

  // Additional Fields
  lineItemStatus?: string; // e.g., "Pending", "Received", "Cancelled"
  unitOfMeasure?: string; // e.g., "Pieces", "Kilograms", "Liters"
  lineDiscountAmount?: number; // Discount at the line item level
  lineDiscountPercentage?: number; // Discount percentage at the line item level
  batchNumber?: string; // For batch/lot tracking
  expiryDate?: Date; // For perishable items
  serialNumber?: string; // For serialized items
  warehouseLocation?: string; // Location where the item will be stored
  receivedQuantity?: number; // Quantity received against ordered quantity
  rejectedQuantity?: number; // Quantity rejected during quality inspection
  lineTaxRate?: number; // Tax rate specific to the line item
}
