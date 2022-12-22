import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Room } from './interfaces/room';

@Injectable({
  providedIn: 'root'
})
export class RoomCalculatorService {

  private _url: string = "https://localhost:7289/api/RoomCalculator/";

  constructor(private http: HttpClient) { }

  calculateRoomSize = (length: number, width: number, height: number): Observable<Room> => {
    return this.http.get<any>(`${this._url}roomsizecalculator?length=${length}&width=${width}&height=${height}`);
  }

  roomhistory = (): Observable<Room[]> => { 
    return this.http.get<any>(`${this._url}roomhistory`);
  }

}