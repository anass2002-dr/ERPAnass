import { Article } from "../Article/Article";

export interface PurchaseDetails {
  idPurchaseDetails?: Number,
  idArticle?: Number,
  quantity?: number,
  totalPrice?: Number,
  taxAmount?: Number,
  quality?: string,
  isActive?: boolean,
  idPurchase?: Number,
  article?: Article
}
