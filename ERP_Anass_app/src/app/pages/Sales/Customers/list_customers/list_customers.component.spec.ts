/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { List_customersComponent } from './list_customers.component';

describe('List_customersComponent', () => {
  let component: List_customersComponent;
  let fixture: ComponentFixture<List_customersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ List_customersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(List_customersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
