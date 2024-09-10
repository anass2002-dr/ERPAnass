/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { List_Job_PostingComponent } from './List_Job_Posting.component';

describe('List_Job_PostingComponent', () => {
  let component: List_Job_PostingComponent;
  let fixture: ComponentFixture<List_Job_PostingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ List_Job_PostingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(List_Job_PostingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
