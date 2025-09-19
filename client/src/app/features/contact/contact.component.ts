import { CommonModule } from '@angular/common';
import { Component, inject, signal, WritableSignal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { SnackbarService } from '../../core/services/snackbar.service';

@Component({
  selector: 'app-contact',
  imports: [CommonModule, FormsModule],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.scss',
})
export class ContactComponent {
  name: WritableSignal<string> = signal('');
  email: WritableSignal<string> = signal('');
  subject: WritableSignal<string> = signal('');
  message: WritableSignal<string> = signal('');

  private snackBar = inject(SnackbarService);

  onSubmit(): void {
    return this.snackBar.success('Thank you for reaching out, your message has been sent');
  }
}
