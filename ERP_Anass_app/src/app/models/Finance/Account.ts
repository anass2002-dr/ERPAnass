
export enum AccountType {
    Asset = 1,
    Liability = 2,
    Equity = 3,
    Income = 4,
    Expense = 5
}

export interface Account {
    idAccount?: number;
    accountCode?: string;
    accountName?: string;
    type?: AccountType;
    isAcitve?: boolean;
}
