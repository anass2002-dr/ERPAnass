/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SupplierService } from './Supplier.service';

describe('Service: SupplierService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SupplierService]
    });
  });

  it('should ...', inject([SupplierService], (service: SupplierService) => {
    expect(service).toBeTruthy();
  }));
});
