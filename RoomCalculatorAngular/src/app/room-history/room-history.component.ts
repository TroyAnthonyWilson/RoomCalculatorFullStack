import { Component, OnInit } from '@angular/core';
import { Room } from '../interfaces/room';
import { RoomCalculatorService } from '../room-calculator.service';

@Component({
  selector: 'app-room-history',
  templateUrl: './room-history.component.html',
  styleUrls: ['./room-history.component.css']
})
export class RoomHistoryComponent implements OnInit {

  Rooms: Room[] = [];

  constructor(private roomCalculatorService: RoomCalculatorService) { }

  ngOnInit(): void {
    this.roomhistory();
  }

  roomhistory = () => {
    this.roomCalculatorService.roomhistory().subscribe((data: any) => {
      this.Rooms = data;
    });
  }

 AverageRoomSize = () => {
      let total = 0;
      this.Rooms.forEach((room) => {
        total += room.size;
      });
      return total / this.Rooms.length;
    }

    AverageRoomWidth = () => {
      let total = 0;
      this.Rooms.forEach((room) => {
        total += room.width;
      });
      return total / this.Rooms.length;
    }

    AverageRoomLength = () => {
      let total = 0;
      this.Rooms.forEach((room) => {
        total += room.length;
      });
      return total / this.Rooms.length;
    }

    AverageRoomHeight() {
      let total = 0;
      this.Rooms.forEach((room) => {
        total += room.height;
      });
      return total / this.Rooms.length;
    }

    AverageRoomPerimeter()
    {
      let total = 0;
      this.Rooms.forEach((room) => {
        total += room.perimeter;
      });
      return total / this.Rooms.length;
    }

    AverageRoomSurfaceArea()
    {
      let total = 0;
      this.Rooms.forEach((room) => {
        total += room.surfaceArea;
      }
      );
      return total / this.Rooms.length;
    }

    AverageRoomVolume()
    {
      let total = 0;
      this.Rooms.forEach((room) => {
        total += room.volume;
      }
      );
      return total / this.Rooms.length;
    }

    roomclassification(size: number)
    {
      if (size < 250)
      {
        return "Small";
      }
      else if (size < 650)
      {
        return "Medium";
      }
      else if (size >= 650)
      {
        return "Large";
      }
      return "Unknown";
    }
}