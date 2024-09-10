/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Add_TrainingComponent } from './Add_Training.component';

describe('Add_TrainingComponent', () => {
  let component: Add_TrainingComponent;
  let fixture: ComponentFixture<Add_TrainingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add_TrainingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add_TrainingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
