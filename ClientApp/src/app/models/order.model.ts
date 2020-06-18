import { Provider } from "./provider.model";
import { Patient } from "./patient.model";
import { OrderItem } from "./orderitem.model";

export class Order {
  id: number;
  date: Date;
  provider: Provider;
  patient: Patient;
  items: OrderItem[];
}
