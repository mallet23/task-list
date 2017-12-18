import {Component, OnInit} from '@angular/core';

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
    'white',
    'redA-200',
    'redA-400',
    'redA-700',

    'pinkA-100',
    'pinkA-200',
    'pinkA-400',
    'pinkA-700',

    'purpleA-100',
    'purpleA-200',
    'purpleA-400',
    'purpleA-700',

    'indigoA-100',
    'indigoA-200',
    'indigoA-400',
    'indigoA-700',
  ];

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
  }
}
