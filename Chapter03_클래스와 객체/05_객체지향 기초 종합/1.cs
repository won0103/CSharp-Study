//실습 문제: 상품 재고 관리 시스템

using System.Runtime;

Product product1 = new Product();
product1.Name = "키보드";
product1.Stock = 20;

Product product2 = new Product();
product2.Name = "마우스";
product2.Stock = 10;

Console.WriteLine("=== 상품 재고 관리 시스템 ===");
Console.WriteLine("\n[초기 재고]");
product1.PrintInfo();
product2.PrintInfo();

Console.WriteLine("\n[일반 재고 추가]");
product1.AddStock(5);
product1.PrintInfo();

Console.WriteLine("\n[보너스 재고 추가]");
product1.AddStock(5, 2);
product1.PrintInfo();

if (product1.TransferStock(product2, 12))
{
  Console.WriteLine("재고 이동 성공!");
}
else
{
  Console.WriteLine("재고 이동 실패!");
}
product1.PrintInfo();
product2.PrintInfo();


if (product1.TransferStock(product2, 50))
{
  Console.WriteLine("재고 이동 성공!");
}
else
{
  Console.WriteLine("재고 이동 실패!");
}
product1.PrintInfo();
product2.PrintInfo();

Product product3 = product1;
product3.AddStock(3);

Console.WriteLine("\n[참조형 확인]");
Console.WriteLine($"product1 재고: {product1.Stock}개");
Console.WriteLine($"product3 재고: {product3.Stock}개");
Console.WriteLine($"같은 객체인가? {ReferenceEquals(product1, product3)}");


class Product
{
  public string Name = "";
  public int Stock;

  public void AddStock(int amount)
  {
    if (amount > 0)
    {
      Stock += amount;
    }
  }

  public void AddStock(int amount, int bonus)
  {
    if (amount > 0 && bonus >= 0)
    {
      AddStock(amount);
      Stock += bonus;
    }
  }

  public bool TransferStock(Product target, int amount)
  {
    bool success;

    Console.WriteLine($"\n[재고 {amount}개 이동]");

    if (Stock >= amount && amount > 0)
    {
      Stock -= amount;
      target.AddStock(amount);
      success = true;
    }
    else
    {
      success = false;
    }

    return success;
  }

  public void PrintInfo()
  {
    Console.WriteLine($"{Name}: {Stock}개");
  }
}