import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ToDoListItem } from '../models/to-do-list-item';
import { HttpClient, HttpHeaders } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class ToDoListService {
  backendUrl:string = 'https://localhost:44378'

  constructor(private http:HttpClient) { }

  getToDoListItems(): Observable<ToDoListItem[]>{
    const endpoint:string = `${this.backendUrl}/todolist/gettodo`
    return this.http.get<ToDoListItem[]>(endpoint);
  }
}
