import { Injectable, Inject } from "@angular/core";
import { Order } from "../models/order.model";
import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class OrderService  {
  private httpClient: HttpClient;
  private baseUrl: string;

  constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.httpClient = httpClient;
    this.baseUrl = baseUrl;
  }

  getOrders(): Observable<Order[]> {
    return this.httpClient.get<Order[]>(`${this.baseUrl}api/order`)
      .pipe(catchError(this.handleError));
  }
  
  getOrder(id: number): Observable<Order> {
    return this.httpClient.get<Order>(`${this.baseUrl}api/order/${id}`)
      .pipe(catchError(this.handleError));
  }

  private handleError(errorResponse: HttpErrorResponse): Observable<any> {
    if (errorResponse.error instanceof ErrorEvent) {
      console.error('Client side error:', errorResponse.error.message);
    }
    else {
      console.error('Server side error:', errorResponse);
    }
    return new Observable(null);
  }
}

