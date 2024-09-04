/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { List_cityComponent } from './list_city.component';

describe('List_cityComponent', () => {
  let component: List_cityComponent;
  let fixture: ComponentFixture<List_cityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ List_cityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(List_cityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
