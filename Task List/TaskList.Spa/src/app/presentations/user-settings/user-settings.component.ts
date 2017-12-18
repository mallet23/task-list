import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {IUserSettings} from '../../models/user-settings.model';

@Component({
  selector: 'app-user-settings',
  templateUrl: './user-settings.component.html',
  styleUrls: ['./user-settings.component.css']
})
export class UserSettingsComponent implements OnInit {

  constructor() {
  }

  dateTimeFormats: string[] = ['dd/mm/yy', 'dd.mm.yy'];

  ngOnInit() {
  }

  @Output()
  saveSettings: EventEmitter<IUserSettings> = new EventEmitter<IUserSettings>();

  @Input()
  userSettings: IUserSettings;

  selectColor(color: string) {
    this.userSettings.altRowColor = color;
  }

  selectDateFormat(dateFormat: string) {
    this.userSettings.dateTimeFormat = dateFormat;
  }

  onSubmit() {
    this.saveSettings.emit(this.userSettings);
  }
}
