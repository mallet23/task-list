import {Component} from '@angular/core';
import {TabState} from './tab-state';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  tabStates = TabState;

  currentTabState = TabState.TasksList;

  changeTab(tabState: TabState): void {
    this.currentTabState = tabState;
  }
}
