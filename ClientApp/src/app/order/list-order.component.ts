import { Component, OnInit, Inject } from '@angular/core';
import { trigger, transition, animate, style } from '@angular/animations'

import { Order } from '../models/order.model';
import { OrderService } from './order.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-list-order',
  templateUrl: './list-order.component.html',
  styleUrls: ['./list-order.component.css'],
  animations: [
    trigger('slideInOut', [
      transition(':enter', [
        style({ transform: 'translateX(100%)' }),
        animate('500ms ease-in', style({ transform: 'translateX(0%)' }))
      ]),
      transition(':leave', [
        style({ transform: 'translateX(0%)' }),
        animate('500ms ease-out', style({ transform: 'translateX(100%)' }))
      ])
    ])
  ]

})
export class ListOrderComponent implements OnInit {
  private orders: Order[];
  private selectedOrderId: number = 0;
  private selectedOrder: Order;

  constructor(private orderService: OrderService, @Inject('USER') private user: string) {
  }

  ngOnInit() {
    this.refresh();
  }

  refresh() {
    this.orders = null;
    this.selectedOrderId = 0;
    this.selectedOrder = null;
    this.orderService.getOrders()
      .subscribe(orders => this.orders = orders);
  }

  selectOrder(orderId: number) {
    this.orderService.getOrder(orderId)
      .subscribe(order => this.selectedOrder = order);
    this.selectedOrderId = orderId;
  }

  closeDetailedView() {
    this.selectedOrderId = 0;
    this.selectedOrder = null;
  }
}
