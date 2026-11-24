//은행 계좌 관리 시스템
BankAccount account1 = new BankAccount("홍길동", 100000);

Console.WriteLine("=== 은행 계좌 관리 시스템 ===");
Console.WriteLine("\n[초기 계좌 정보]");
account1.PrintInfo();

Console.WriteLine($"\n[50000원 입금]");
PrintResult(account1.Deposit(50000), "입금");
account1.PrintInfo();

Console.WriteLine("\n[30000원 출금]");
PrintResult(account1.Withdrawal(30000), "출금");
account1.PrintInfo();

Console.WriteLine("\n[200000원 출금]");
PrintResult(account1.Withdrawal(200000), "출금");
account1.PrintInfo();

Console.WriteLine("\n[-10000원 입금]");
PrintResult(account1.Deposit(-10000), "입금");
account1.PrintInfo();

Console.WriteLine("\n[120000원 출금]");
PrintResult(account1.Withdrawal(120000), "출금");
account1.PrintInfo();

Console.WriteLine("\n[잘못된 초기 잔액]");
BankAccount account2 = new BankAccount("김철수", -5000);
account2.PrintInfo();

void PrintResult(bool success, string action)
{
  if (success)
  {
    Console.WriteLine($"{action} 성공!");
  }
  else
  {
    Console.WriteLine($"{action} 실패!");
  }
}

class BankAccount
{
  private string Name;
  private int Balance;

  public BankAccount(string name, int balance)
  {
    if (balance < 0)
    {
      balance = 0;
    }

    this.Name = name;
    this.Balance = balance;
    //this 적어야함? 이름 다르게 대문자 소문자 했는데
  }

  public void PrintInfo()
  {
    Console.WriteLine($"{Name}: {Balance}원");
  }

  public bool Deposit(int money)
  {
    if (money <= 0)
    {
      return false;
    }
    else
    {
      Balance += money;
      return true;
    }
  }

  public bool Withdrawal(int money)
  {
    if (money > 0 && Balance >= money)
    {
      Balance -= money;
      return true;
    }
    else
    {
      return false;
    }
  }
}