
import { Account } from './Account';

export interface JournalDetails {
    idJournalDetails?: number;
    journalEntryID?: number;
    accountID?: number;
    debitAmount?: number;
    creditAmount?: number;
    description?: string;
    account?: Account;
}
