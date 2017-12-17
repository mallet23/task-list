import {Component, Input, OnInit} from '@angular/core';
import {ITask} from '../../../models/task.model';

@Component({
  selector: 'app-task-details',
  templateUrl: './task-details.component.html',
  styleUrls: ['./task-details.component.css']
})
export class TaskDetailsComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  @Input()
  task: ITask;

}
