import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { RoomCalculatorService } from '../room-calculator.service';

@Component({
  selector: 'app-add-room',
  templateUrl: './add-room.component.html',
  styleUrls: ['./add-room.component.css']
})
export class AddRoomComponent implements OnInit {

  width: number = 0;
  length: number = 0;
  height: number = 0;

  constructor( private roomCalculatorService: RoomCalculatorService) { }

  ngOnInit(): void {
  }

  submit() {
    this.roomCalculatorService.calculateRoomSize(this.length, this.width, this.height).subscribe((data: any) => {
      console.log(data);
    });
  }

}
