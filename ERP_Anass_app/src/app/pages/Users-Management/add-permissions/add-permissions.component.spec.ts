/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AddPermissionsComponent } from './add-permissions.component';

describe('AddPermissionsComponent', () => {
  let component: AddPermissionsComponent;
  let fixture: ComponentFixture<AddPermissionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddPermissionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddPermissionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
