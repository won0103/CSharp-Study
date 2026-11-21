//상품 재고 관리 프로그램

Product product1 = new Product();
product1.Name = "키보드";
product1.Stock = 10;

Product product2 = product1;
product2.Stock += 5;

Console.WriteLine("=== 상품 재고 관리 프로그램 ===\n");
Console.WriteLine("[참조 복사 후 재고 변경]");
Console.WriteLine($"첫 번째 변수 재고: {product1.Stock}");
Console.WriteLine($"두 번째 변수 재고: {product2.Stock}");
Console.WriteLine(ReferenceEquals(product1, product2));

product2 = new Product();
product2.Name = "마우스";
product2.Stock = 20;

Console.WriteLine("\n[두 번째 변수에 새 객체 생성]");
Console.WriteLine($"첫 번째 변수: {product1.Name} / {product1.Stock}");
Console.WriteLine($"두 번째 변수: {product2.Name} / {product2.Stock}");
Console.WriteLine(ReferenceEquals(product1, product2));

int originalStock = 10;
int copiedStock = originalStock;

copiedStock = 30;

Console.WriteLine("\n[값 형식 복사]");
Console.WriteLine($"원본 재고: {originalStock}");
Console.WriteLine($"복사한 재고: {copiedStock}");

class Product
{
  public string Name = "";
  public int Stock;
}