import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-color-picker',
  templateUrl: './color-picker.component.html',
  styleUrls: ['./color-picker.component.css']
})
export class ColorPickerComponent implements OnInit {

  constructor() {
  }

  ngOnInit() {
  }

  colors: string[] = [
    '#ffffff',
    '#ff5252',
    '#ff1744',
    '#d50000',

    '#ff80ab',
    '#ff4081',
    '#f50057',
    '#c51162',

    '#ea80fc',
    '#e040fb',
    '#d500f9',
    '#aa00ff',

    '#b388ff',
    '#7c4dff',
    '#651fff',
    '#6200ea',
  ];

  @Output()
  colorSelected: EventEmitter<string> = new EventEmitter<string>();

  @Input()
  selectedColor = this.colors[0];

  isOpened = false;

  togglePanel(): void {
    this.isOpened = !this.isOpened;
  }

  closePanel() {
    this.isOpened = false;
  }

  changeColor(color: string): void {
    this.selectedColor = color;

    this.closePanel();

    this.colorSelected.emit(color);
  }
}
