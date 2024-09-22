/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { InfoServiceService } from './InfoService.service';

describe('Service: InfoService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [InfoServiceService]
    });
  });

  it('should ...', inject([InfoServiceService], (service: InfoServiceService) => {
    expect(service).toBeTruthy();
  }));
});
