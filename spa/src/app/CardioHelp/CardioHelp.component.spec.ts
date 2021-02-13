/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { CardioHelpComponent } from './CardioHelp.component';

describe('CardioHelpComponent', () => {
  let component: CardioHelpComponent;
  let fixture: ComponentFixture<CardioHelpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CardioHelpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CardioHelpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
