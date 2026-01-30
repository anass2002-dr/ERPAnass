
export enum StockMovementType {
    Purchase = 0,
    Sale = 1,
    Adjustment = 2,
    Transfer = 3
}

export interface StockMovement {
    idStockMovement?: number;
    warehouseID?: number;
    type?: StockMovementType;
    movementDate?: Date;
    warehouse?: any;
    stockMovementDetails?: StockMovementDetail[];
}

export interface StockMovementDetail {
    idStockMovementDetail?: number;
    stockMovementId?: number;
    articleID?: number;
    quantity?: number;
    article?: any;
}
