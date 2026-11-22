//상품 할인 계산 프로그램
Product product = new Product();

product.Name = "키보드";
product.Price = 100000;

Console.WriteLine("=== 상품 할인 계산 프로그램 ===\n");

Console.WriteLine($"상품명: {product.Name}");
Console.WriteLine($"원래 가격: {product.Price}");

Console.WriteLine("\n[할인율 적용]");
Console.WriteLine($"10% 할인: {product.CalculateDiscount(0.1)}원");

Console.WriteLine("\n[고정 금액 할인]");
Console.WriteLine($"20000원 할인: {product.CalculateDiscount(20000)}원");

Console.WriteLine("\n[복합 할인]");
Console.WriteLine($"10% + 5000원 할인: {product.CalculateDiscount(0.1, 5000)}원");

class Product
{
  public string Name = "";
  public int Price;

  public double CalculateDiscount(double discountRate)
  {
    double result = Price - Price * discountRate;
    return result;
  }

  public int CalculateDiscount(int discountAmount)
  {
    int result = Price - discountAmount;

    if (result < 0)
    {
      result = 0;
    }

    return result;
  }

  public double CalculateDiscount(double discountRate, int additionalDiscount)
  {
    double result = CalculateDiscount(discountRate) - additionalDiscount;

    if (result < 0)
    {
      result = 0;
    }

    return result;
  }
}