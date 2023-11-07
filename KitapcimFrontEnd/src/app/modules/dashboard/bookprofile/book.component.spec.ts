import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BookProfileComponent } from './bookprofile.component';

describe('BookProfileComponent', () => {
  let component: BookProfileComponent;
  let fixture: ComponentFixture<BookProfileComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BookProfileComponent]
    });
    fixture = TestBed.createComponent(BookProfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
