import { BikeFactory } from './factories/bike-factory';
import { CarFactory } from './factories/car-factory';
import { Car } from './vehicle/car';

/* Sem utilizar Factory Method: */
const fusca = new Car('Fusca');

fusca.pickUp('Maya');
fusca.stop();
/* Se alguma coisa for mudada na classe Car, todos os locais onde o new está sendo
usado será quebrado. */

const celta = new Car('Celta');

celta.pickUp('Orakio');
celta.stop();

/* Utilizando Factory Method */
const carFactory = new CarFactory();
const fuscaComFactory = carFactory.getVehicle('Novo fusca com factory');
fuscaComFactory.pickUp('Chaz');
fuscaComFactory.stop();

const bikeFactory = new BikeFactory();
const newBike = bikeFactory.getVehicle('Nova bicicleta com factory');
newBike.pickUp('Noah');
newBike.stop();
