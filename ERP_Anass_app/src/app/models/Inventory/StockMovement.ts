
export enum StockMovementType {
    Purchase = 0,
    Sale = 1,
    Adjustment = 2,
    Transfer = 3
}

export interface StockMovement {
    idStockMovement?: number;
    articleID?: number;
    warehouseID?: number;
    quantity?: number;
    type?: StockMovementType;
    movementDate?: Date;
    article?: any; // Avoiding circular dependency for now, or use Article interface
    warehouse?: any; // Avoiding circular dependency for now, or use Warehouse interface
}
