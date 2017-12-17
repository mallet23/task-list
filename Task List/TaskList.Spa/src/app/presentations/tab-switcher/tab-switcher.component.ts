import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {TabState} from '../../tab-state';


@Component({
  selector: 'app-tab-switcher',
  templateUrl: './tab-switcher.component.html',
  styleUrls: ['./tab-switcher.component.css']
})
export class TabSwitcherComponent implements OnInit {
  tabStates = TabState;
  constructor() {
  }

  ngOnInit() {
  }

  @Output()
  tabPressed: EventEmitter<TabState> = new EventEmitter<TabState>();

  @Input()
  currentTabState: TabState = TabState.TasksList;

  changeTab(tab: TabState): void {
    this.currentTabState = tab;
    this.tabPressed.emit(tab);
  }
}
