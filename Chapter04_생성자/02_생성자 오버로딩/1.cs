//도서 등록 시스템
Book book1 = new Book();
Book book2 = new Book("C# 입문");
Book book3 = new Book("자료구조", "김개발");
Book book4 = new Book("알고리즘", "이코딩", 450);
Book book5 = new Book(300);

Console.WriteLine("=== 도서 등록 시스템 ===\n");

book1.PrintInfo();
book2.PrintInfo();
book3.PrintInfo();
book4.PrintInfo();
book5.PrintInfo();

class Book
{
  public string Title;
  public string Author;
  public int Pages;

  public Book()
  {
    Title = "미정";
    Author = "미상";
    Pages = 0;
  }
  public Book(string title)
  {
    Title = title;
    Author = "미상";
    Pages = 0;
  }
  public Book(int pages)
  {
    Title = "미정";
    Author = "미상";
    Pages = pages;
  }
  public Book(string title, string author)
  {
    Title = title;
    Author = author;
    Pages = 0;
  }
  public Book(string title, string author, int pages)
  {
    Title = title;
    Author = author;
    Pages = pages;
  }

  public void PrintInfo()
  {
    Console.WriteLine($"제목: {Title} / 저자: {Author} / 페이지: {Pages}쪽");
  }
}