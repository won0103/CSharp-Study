// 배송 주문 등록 시스템
Order order1 = new Order();
Order order2 = new Order("홍길동");
Order order3 = new Order("김철수", "키보드");
Order order4 = new Order("박민수", "마우스", 5);
Order order5 = new Order("이영희", "모니터", -3);

Console.WriteLine("=== 배송 주문 등록 시스템 ===\n");

order1.PrintInfo();
order2.PrintInfo();
order3.PrintInfo();
order4.PrintInfo();
order5.PrintInfo();
class Order
{
  public string CustomerName;
  public string ProductName;
  public int Quantity;

  public Order() : this("비회원", "상품 미지정", 1)
  {

  }
  public Order(string customerName) : this(customerName, "상품 미지정", 1)
  {

  }
  public Order(string customerName, string productName) : this(customerName, productName, 1)
  {

  }
  public Order(string customerName, string productName, int quantity)
  {
    this.CustomerName = customerName;
    this.ProductName = productName;
    this.Quantity = quantity;

    if (Quantity <= 0)
    {
      Quantity = 1;
    }
  }

  public void PrintInfo()
  {
    Console.WriteLine($"고객: {CustomerName} / 상품: {ProductName} / 수량: {Quantity}개");
  }
}