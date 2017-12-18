import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {ITask} from '../../models/task.model';
import {IUserSettings} from '../../models/user-settings.model';

@Component({
  selector: 'app-tasks-list',
  templateUrl: './tasks-list.component.html',
  styleUrls: ['./tasks-list.component.css']
})
export class TasksListComponent implements OnInit {
  private _tasks: ITask[];
  private _userSettings: IUserSettings;
  private _currentTaskId: number;

  get currentTask(): ITask {
    return this._tasks.find(x => x.id === this._currentTaskId);
  }

  filterStatus: boolean = null;

  @Input()
  set userSettings(settings: IUserSettings) {
    this._userSettings = settings;
  }

  get userSettings(): IUserSettings {
    return this._userSettings;
  }

  @Input()
  set tasks(tasks: ITask[]) {
    this._tasks = tasks;
  }

  get tasks(): ITask[] {
    const isCompleted = this.filterStatus;
    return this._tasks.filter(x => isCompleted === null || isCompleted === x.isCompleted);
  }

  @Output()
  removeTask: EventEmitter<number> = new EventEmitter<number>();

  @Output()
  completeTask: EventEmitter<number> = new EventEmitter<number>();

  @Output()
  refreshTable = new EventEmitter();

  constructor() {
  }

  ngOnInit() {
  }

  selectTask(id: number): void {
    this._currentTaskId = id;
  }

  useFilter(filterStatus) {
    this.filterStatus = filterStatus;
  }

  onRemoveTask(id: number) {
    this.removeTask.emit(id);
  }

  onCompleteTask(id: number) {
    this.completeTask.emit(id);
  }

  onRefresh() {
    this.refreshTable.emit(id);
  }
}
