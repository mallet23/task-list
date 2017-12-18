import {Component} from '@angular/core';
import {TabState} from './tab-state';
import {ITask} from './models/task.model';
import {IUserSettings} from './models/user-settings.model';
import {TasksMock} from './shared/mock-tasks';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  _userSettings: IUserSettings = {
    altRowColor: '#ffffff',
    dateTimeFormat: 'dd/MM/yyyy'
  };

  tasks: ITask[] = TasksMock;

  tabStates = TabState;

  currentTabState = TabState.TasksList;

  get userSettings(): IUserSettings {
    return this._userSettings;
  }

  set userSettings(userSettings: IUserSettings) {
    this._userSettings = userSettings;
  }

  changeTab(tabState: TabState): void {
    this.currentTabState = tabState;
  }

  addTask(task: ITask) {
    const maxIndex = Math.max.apply(null, this.tasks.map(x => x.id));
    task.id = maxIndex + 1;
    this.tasks.push(task);
    this.changeTab(TabState.TasksList);
  }

  saveSettings(userSettings: IUserSettings) {
    this.userSettings = userSettings;
    this.changeTab(TabState.TasksList);
  }

  removeTask(id: number) {
    const index = this.tasks.findIndex(x => x.id === id);

    if (index > -1) {
      this.tasks.splice(index, 1);
    }
  }

  completeTask(id: number) {
    const index = this.tasks.findIndex(x => x.id === id);

    if (index > -1) {
      this.tasks[index].isCompleted = true;
    }
  }

  refreshTable() {
    // refresh table
  }
}
