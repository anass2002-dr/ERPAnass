
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { JournalEntry } from '../../models/Finance/JournalEntry';

@Injectable({
    providedIn: 'root'
})
export class JournalEntryService {

    private url: string = `${environment.ApiUrl}/JournalEntry`;

    constructor(private http: HttpClient) { }

    public getJournalEntries(): Observable<JournalEntry[]> {
        return this.http.get<JournalEntry[]>(`${this.url}/GetJournalEntries`);
    }

    public getJournalEntryById(id: number): Observable<JournalEntry> {
        return this.http.get<JournalEntry>(`${this.url}/GetJournalEntryById/${id}`);
    }

    public createJournalEntry(entry: JournalEntry): Observable<JournalEntry> {
        return this.http.post<JournalEntry>(`${this.url}/AddJournalEntry`, entry);
    }

    public updateJournalEntry(entry: JournalEntry): Observable<JournalEntry> {
        return this.http.put<JournalEntry>(`${this.url}/UpdateJournalEntry/${entry.idJournalEntry}`, entry);
    }

    public deleteJournalEntry(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/DeleteJournalEntry/${id}`);
    }
}
