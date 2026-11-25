//상품 가격 관리 프로그램
Console.WriteLine("=== 상품 가격 관리 프로그램 ===");

Product product1 = new Product("키보드", 100000);

Console.WriteLine("\n[초기 상품 정보]");
product1.PrintProductInfo();

Console.WriteLine("\n[할인율 20% 적용]");
product1.DiscountRate = 20;
product1.PrintProductInfo();

Console.WriteLine("\n[잘못된 가격 및 할인율 입력]");
product1.Price = -50000;
product1.DiscountRate = 70;
product1.PrintProductInfo();

Console.WriteLine("\n[판매 가격 변경]");
product1.Price = 120000;
product1.PrintProductInfo();

Console.WriteLine("\n[할인율 50% 적용]");
product1.DiscountRate = 50;
product1.PrintProductInfo();


class Product
{
  private string _productName;
  private int _price;
  private int _discountRate = 0;

  public string ProductName { get; }

  public int Price
  {
    get
    {
      return _price;
    }
    set
    {
      if (value >= 0)
      {
        _price = value;
      }
    }
  }
  public int DiscountRate
  {
    get
    {
      return _discountRate;
    }
    set
    {
      if (value >= 0 && value <= 50)
      {
        _discountRate = value;
      }
    }
  }

  public Product(string productName, int price)
  {
    this._productName = productName;
    Price = price;
  }
  public double CalculateDiscount()
  {
    return _price - (_price * (_discountRate / 100.0));
  }
  public void PrintProductInfo()
  {
    Console.WriteLine($"상품명: {_productName}");
    Console.WriteLine($"판매 가격: {_price}원");
    Console.WriteLine($"할인율: {_discountRate}%");
    Console.WriteLine($"최종 가격: {CalculateDiscount()}원");
  }

}