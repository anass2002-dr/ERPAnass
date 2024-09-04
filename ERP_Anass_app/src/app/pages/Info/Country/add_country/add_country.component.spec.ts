/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Add_countryComponent } from './add_country.component';

describe('Add_countryComponent', () => {
  let component: Add_countryComponent;
  let fixture: ComponentFixture<Add_countryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add_countryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add_countryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
