export interface Purchase {
  idPurchase?: Number,
  purchaseRef?: string,
  totalAmount?: Number,
  idCurrency?: Number,
  paymentStatus?: string,
  paymentDate?: Date,
  purchaseDate?: Date,
  createdAt?: Date,
  updatedAt?: Date,
  remarks?: string,
  idSupplier?: Number,
  isAcitve?: boolean,
  currencyName?: string,
  supplierName?: string
}
