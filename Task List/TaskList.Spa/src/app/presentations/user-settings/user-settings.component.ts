import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {IUserSettings} from '../../models/user-settings.model';
import {DateTimeFormats} from '../../shared/constants/date-time-formats';

@Component({
  selector: 'app-user-settings',
  templateUrl: './user-settings.component.html',
  styleUrls: ['./user-settings.component.css']
})
export class UserSettingsComponent implements OnInit {

  constructor() {
  }

  dateTimeFormats: string[] = DateTimeFormats;

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
