import { Component, OnInit } from '@angular/core';
import { ToDoListItem } from 'src/app/models/to-do-list-item';
import { ToDoListService } from 'src/app/services/to-do-list.service';

@Component({
  selector: 'to-do-list-table',
  templateUrl: './to-do-list-table.component.html',
  styleUrls: ['./to-do-list-table.component.css']
})
export class ToDoListTableComponent implements OnInit {
  public toDoListItems: ToDoListItem[];

  constructor(private toDoListService:ToDoListService) { }

  ngOnInit() {
    this.toDoListService.getToDoListItems().subscribe( toDoListItems =>{
      this.toDoListItems = toDoListItems;
    });
  }

}
