import { ProductDecorator } from './product-decorator';

export class ProductStampDecorator extends ProductDecorator {
  getName(): string {
    return `${this.product.getName()} (estampada)`;
  }

  getPrice(): number {
    // So this product is enhanced because
    // of the stamp. The decorator added this feature
    // So the price will be 10 dollars more expensive
    return this.product.getPrice() + 10;
  }
}
