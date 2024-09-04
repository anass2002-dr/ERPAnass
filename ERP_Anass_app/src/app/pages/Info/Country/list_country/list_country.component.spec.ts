/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { List_countryComponent } from './list_country.component';

describe('List_countryComponent', () => {
  let component: List_countryComponent;
  let fixture: ComponentFixture<List_countryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ List_countryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(List_countryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
