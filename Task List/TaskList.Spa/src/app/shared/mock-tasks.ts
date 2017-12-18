import {ITask} from '../models/task.model';

export const TasksMock: ITask[] = [
  {
    id: 1,
    name: 'name 1',
    description: 'description 1',
    priority: 1,
    createdDate: new Date(),
    dueDate: new Date(),
    isCompleted: true
  },
  {
    id: 2,
    name: 'name 2',
    description: 'description 2',
    priority: 2,
    createdDate: new Date('December 13, 2017 11:13:00'),
    dueDate: new Date(),
    isCompleted: false
  },
  {
    id: 3,
    name: 'name 3',
    description: 'description 3',
    priority: 3,
    createdDate: new Date('Jule 1, 2017 11:50:00'),
    dueDate: new Date(),
    isCompleted: false
  }
];
