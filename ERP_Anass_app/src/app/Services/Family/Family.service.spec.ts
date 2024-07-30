/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { FamilyService } from './Family.service';

describe('Service: Family', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [FamilyService]
    });
  });

  it('should ...', inject([FamilyService], (service: FamilyService) => {
    expect(service).toBeTruthy();
  }));
});
