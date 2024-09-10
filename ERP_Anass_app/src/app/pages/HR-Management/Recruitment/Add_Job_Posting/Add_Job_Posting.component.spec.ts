/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { Add_Job_PostingComponent } from './Add_Job_Posting.component';

describe('Add_Job_PostingComponent', () => {
  let component: Add_Job_PostingComponent;
  let fixture: ComponentFixture<Add_Job_PostingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Add_Job_PostingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Add_Job_PostingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
