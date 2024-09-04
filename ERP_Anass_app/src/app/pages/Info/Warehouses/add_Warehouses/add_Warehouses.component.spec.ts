/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Add_WarehousesComponent } from './add_Warehouses.component';

describe('Add_WarehousesComponent', () => {
  let component: Add_WarehousesComponent;
  let fixture: ComponentFixture<Add_WarehousesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add_WarehousesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add_WarehousesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
