import {Component, OnInit} from '@angular/core';
import {ITask} from '../../models/task.model';

@Component({
  selector: 'app-tasks-list',
  templateUrl: './tasks-list.component.html',
  styleUrls: ['./tasks-list.component.css']
})
export class TasksListComponent implements OnInit {

  constructor() {
  }

  ngOnInit() {
  }

  _tasks: ITask[] = [
    {
      name: 'name 1',
      description: 'description 1',
      priority: 1,
      createdDate: new Date(),
      dueDate: new Date(),
      isCompleted: true
    },
    {
      name: 'name 2',
      description: 'description 2',
      priority: 2,
      createdDate: new Date(),
      dueDate: new Date(),
      isCompleted: false
    }
  ];

  get tasks(): ITask[]{
    const isCompleted = this.filterStatus;
    return this._tasks.filter(x => isCompleted === null || isCompleted === x.isCompleted);
  }

  currentTask: ITask;

  filterStatus: boolean = null;

  selectTask(task: ITask): void {
    this.currentTask = task;
  }

  useFilter(filterStatus){
    this.filterStatus = filterStatus;
  }
}
