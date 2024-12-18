import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'Socio Meet';
  http = inject(HttpClient);
  users: any;

  ngOnInit() {
    this.http.get('https://localhost:5001/api/users').subscribe({
      next: (users) => this.users = users,
      error: (err) => console.error(err),
      complete: () => console.log('done')
    })
  }
}
