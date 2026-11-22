// /실습 문제: 은행 계좌 관리 프로그램
BankAccount account1 = new BankAccount();
BankAccount account2 = new BankAccount();

account1.Owner = "홍길동";
account1.AccountNumber = "100-123";
account1.Balance = 100000;

account2.Owner = "김철수";
account2.AccountNumber = "200-456";
account2.Balance = 200000;

account1.Deposit(30000);
account2.Deposit(50000);

Console.WriteLine("=== 은행 계좌 관리 프로그램 ===");
Console.WriteLine("\n[첫 번째 계좌]");
account1.PrintInfo();
Console.WriteLine("\n[두 번째 계좌]");
account2.PrintInfo();

class BankAccount
{
  public string Owner = "";
  public string AccountNumber = "";
  public int Balance;

  //입금
  public void Deposit(int amount)
  {
    if (amount > 0)
    {
      Balance += amount;
    }
  }
  //계좌 정보 출력
  public void PrintInfo()
  {
    Console.WriteLine($"소유자: {Owner}");
    Console.WriteLine($"계좌번호: {AccountNumber}");
    Console.WriteLine($"잔액: {Balance}원");
  }
}