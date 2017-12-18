import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-dropdown',
  templateUrl: './dropdown.component.html',
  styleUrls: ['./dropdown.component.css']
})
export class DropdownComponent implements OnInit {

  constructor() {
  }

  ngOnInit() {
  }

  @Output()
  valueSelected: EventEmitter<string> = new EventEmitter<string>();

  @Input()
  items: string[];

  @Input()
  value: string;

  isOpened = false;

  togglePanel(): void {
    this.isOpened = !this.isOpened;
  }

  closePanel() {
    this.isOpened = false;
  }

  selectValue(value: string) {
    this.value = value;

    this.closePanel();
    this.valueSelected.emit(value);
  }
}
