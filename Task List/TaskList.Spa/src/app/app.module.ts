import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { AddTaskComponent } from './presentations/add-task/add-task.component';
import { TasksListComponent } from './presentations/tasks-list/tasks-list.component';
import { UserSettingsComponent } from './presentations/user-settings/user-settings.component';
import { TabSwitcherComponent } from './presentations/tab-switcher/tab-switcher.component';
import { TaskDetailsComponent } from './presentations/tasks-list/task-details/task-details.component';


@NgModule({
  declarations: [
    AppComponent,
    AddTaskComponent,
    TasksListComponent,
    UserSettingsComponent,
    TabSwitcherComponent,
    TaskDetailsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
