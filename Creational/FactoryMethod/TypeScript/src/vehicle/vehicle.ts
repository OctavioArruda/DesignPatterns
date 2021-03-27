// Interface storing actions that the objects will have
export interface Vehicle {
  pickUp(customerName: string): void;
  stop(): void;
}
