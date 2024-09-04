/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Add_cityComponent } from './add_city.component';

describe('Add_cityComponent', () => {
  let component: Add_cityComponent;
  let fixture: ComponentFixture<Add_cityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add_cityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add_cityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
