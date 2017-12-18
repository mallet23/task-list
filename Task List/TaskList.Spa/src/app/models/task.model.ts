export interface ITask {
  id: number;
  name: string;
  description: string;
  priority: number;
  createdDate: Date;
  dueDate: Date;
  isCompleted: boolean;
}
