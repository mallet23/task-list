export interface ITask {
  name: string;
  description: string;
  priority: number;
  createdDate: Date;
  dueDate: Date;
  isCompleted: boolean;
}
