import { BikeFactory } from '../factories/bike-factory';
import { CarFactory } from '../factories/car-factory';
import { randomNumbers } from '../utils/random-numbers';
import { Vehicle } from '../vehicle/vehicle';

export function randomCarAlgorithm(): Vehicle {
  const carFactory = new CarFactory();
  const car1 = carFactory.getVehicle('Porsche');
  const car2 = carFactory.getVehicle('Lamborghini');

  const bikeFactory = new BikeFactory();
  const bike1 = bikeFactory.getVehicle('Lander');
  const bike2 = bikeFactory.getVehicle('Crosser');

  const vehicles = [car1, car2, bike1, bike2];

  return vehicles[randomNumbers(vehicles.length)];
}
