/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Add_salesComponent } from './add_sales.component';

describe('Add_salesComponent', () => {
  let component: Add_salesComponent;
  let fixture: ComponentFixture<Add_salesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add_salesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add_salesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
