//은행 계좌 간 송금 프로그램
bool success;
BankAccount account1 = new BankAccount();
BankAccount account2 = new BankAccount();

account1.Owner = "홍길동";
account1.Balance = 100000;

account2.Owner = "김철수";
account2.Balance = 50000;

Console.WriteLine("=== 은행 계좌 송금 프로그램 ===\n");
Console.WriteLine("[초기 계좌 정보]");
account1.PrintInfo();
account2.PrintInfo();

success = account1.TransferTo(account2, 30000);
Console.WriteLine("\n30000원 송금");
if (success)
{
  Console.WriteLine("송금 성공!\n");
}
else
{
  Console.WriteLine("송금 실패!\n");
}
account1.PrintInfo();
account2.PrintInfo();

success = account1.TransferTo(account2, 100000);
Console.WriteLine("\n100000원 송금");
if (success)
{
  Console.WriteLine("송금 성공!\n");
}
else
{
  Console.WriteLine("송금 실패!\n");
}
account1.PrintInfo();
account2.PrintInfo();


class BankAccount
{
  public string Owner = "";
  public int Balance;

  public void Deposit(int amount)
  {
    if (amount > 0)
    {
      Balance += amount;
    }
  }
  public bool Withdraw(int amount)
  {
    bool withdrawSuccess;

    if (amount > 0 && Balance >= amount)
    {
      Balance -= amount;
      withdrawSuccess = true;
    }
    else
    {
      withdrawSuccess = false;
    }

    return withdrawSuccess;
  }
  public bool TransferTo(BankAccount target, int amount)
  {
    bool transferToSuccess;

    if (Withdraw(amount))
    {
      target.Deposit(amount);
      transferToSuccess = true;
    }
    else
    {
      transferToSuccess = false;
    }
    return transferToSuccess;
  }
  public void PrintInfo()
  {
    Console.WriteLine($"{Owner}: {Balance}원");
  }
}