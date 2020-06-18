import { OrderService } from './order.service';
import { TestBed, getTestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

describe('Person Service', () => {
  let injector: TestBed;
  let service: OrderService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [OrderService]
    });

    injector = getTestBed();
    service = injector.get(OrderService);
  });

  it('should get all orders => get more than 0 items', () => {
      let orderCount = service.getOrders();
      expect(orderCount).toBeGreaterThan(0);
    });

  it('should get order for known id / get 1 item', () => {
      let orderCount = service.getOrder(1234);
      expect(orderCount).toEqual(1);
    });
});
