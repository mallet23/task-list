import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {Colors} from '../../shared/constants/colors';

@Component({
  selector: 'app-color-picker',
  templateUrl: './color-picker.component.html',
  styleUrls: ['./color-picker.component.css']
})
export class ColorPickerComponent implements OnInit {
  colors: string[] = Colors;
  isOpened = false;

  @Output()
  colorSelected: EventEmitter<string> = new EventEmitter<string>();

  @Input()
  selectedColor = this.colors[0];

  constructor() {
  }

  ngOnInit() {
  }

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
