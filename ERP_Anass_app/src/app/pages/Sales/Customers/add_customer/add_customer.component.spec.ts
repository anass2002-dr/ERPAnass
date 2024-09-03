/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Add_customerComponent } from './add_customer.component';

describe('Add_customerComponent', () => {
  let component: Add_customerComponent;
  let fixture: ComponentFixture<Add_customerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add_customerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add_customerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
