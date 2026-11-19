Console.Write("출력할 단을 입력하세요: ");
int dan = int.Parse(Console.ReadLine());

int count = 1;

if (dan<2 || dan>9)
{
  Console.Write("잘못된 입력입니다.");
}
else
{
  while (count < 10)
{
  Console.WriteLine($"{dan} x {count} = {dan*count}");
  count++;
}
}
