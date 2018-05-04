import { Component, OnInit, Input } from '@angular/core';
import { UserDTO } from '../../Models/UserDTO';
@Component({
  selector: 'app-member-details',
  templateUrl: './member-details.component.html',
  styleUrls: ['./member-details.component.css']
})
export class MemberDetailsComponent implements OnInit {
  @Input() member: UserDTO;
  constructor() { }

  ngOnInit() {
  }

}
