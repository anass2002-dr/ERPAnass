
import { JournalDetails } from './JournalDetails';

export enum JournalEntryStatus {
    Draft = 0,
    Posted = 1
}

export interface JournalEntry {
    idJournalEntry?: number;
    entryDate?: Date;
    description?: string;
    totalDebit?: number;
    totalCredit?: number;
    status?: JournalEntryStatus;
    journalDetails?: JournalDetails[];
}
