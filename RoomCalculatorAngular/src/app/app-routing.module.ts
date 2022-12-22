import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddRoomComponent } from './add-room/add-room.component';
import { RoomHistoryComponent } from './room-history/room-history.component';

const routes: Routes = [
  { path: 'roomhistory', component: RoomHistoryComponent },
  { path: 'addroom', component: AddRoomComponent },
  { path: '', redirectTo: '/roomhistory', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
