import { ProductCustomizationDecorator } from './product/product-customization-decorator';
import { ProductDecorator } from './product/product-decorator';
import { ProductStampDecorator } from './product/product-stamp-decorator';
import { TShirt } from './product/t-shirt';

const tshirt = new TShirt();
console.log(tshirt.getName());
console.log(`The price of a regular t-shirt: ${tshirt.getPrice()}`);
const decoratedTshirt = new ProductDecorator(tshirt);
console.log(decoratedTshirt.getName());
console.log(
  `The price of a regular decorated t-shirt ${decoratedTshirt.getPrice()}`,
);
/* We got the same behavior either for tshirt or the decorated
   tshirt */
const decoratedTshirtWithStamp = new ProductStampDecorator(tshirt);
console.log(decoratedTshirtWithStamp.getName());
console.log(
  `The price of a decorated t-shirt with a stamp ${decoratedTshirtWithStamp.getPrice()}`,
);

const decoratedTshirtWithTwoStamps = new ProductStampDecorator(
  decoratedTshirtWithStamp,
);
console.log(decoratedTshirtWithTwoStamps.getName());
console.log(
  `The price of a decorated t-shirt with two stamps ${decoratedTshirtWithTwoStamps.getPrice()}`,
);

const customizedTshirt = new ProductCustomizationDecorator(tshirt);
console.log(customizedTshirt.getName());
console.log(
  `The price of a decorated customized t-shirt ${customizedTshirt.getPrice()}`,
);
