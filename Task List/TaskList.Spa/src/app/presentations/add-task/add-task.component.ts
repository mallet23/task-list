import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {ITask} from '../../models/task.model';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent implements OnInit {

  constructor() {
  }

  ngOnInit() {
    this.task = {
      name: '',
      description: '',
      priority: 1,
      createdDate: undefined,
      dueDate: undefined,
      isCompleted: false,
    };
  }

  @Output()
  addedTask: EventEmitter<ITask> = new EventEmitter<ITask>();

  task: ITask;

  onAddTask(): void {
    this.task.createdDate = new Date();
    this.addedTask.emit(this.task);
  }
}
