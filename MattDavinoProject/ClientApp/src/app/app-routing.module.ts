
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './register/register.component'
import { HomeComponent } from './home/home.component'
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './services/auth.service';
import { UserService } from './services/user.service';
import { MemberListComponent } from './member/member-list/member-list.component';
import { MemberCardComponent } from './member/member-card/member-card.component';
import { FriendsListComponent } from './friends-list/friends-list.component';
import { MessagesComponent } from './messages/messages.component';
import { MemberDetailsEditComponent } from './member/member-details-edit/member-details-edit.component';
import { MemberDetailsComponent } from './member/member-details/member-details.component'


const routes: Routes = [
  { path: 'details', component: MemberDetailsComponent },
  { path: 'edit', component: MemberDetailsEditComponent },
  { path: 'messages', component: MessagesComponent },
  { path: 'friendslist', component: FriendsListComponent },
  { path: 'memberlist', component: MemberListComponent },
  { path: 'membercard', component: MemberCardComponent },
  { path: 'friendslist', component: FriendsListComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'home', component: HomeComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
