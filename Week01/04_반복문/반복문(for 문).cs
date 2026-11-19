Console.Write("출력할 단을 입력하세요: ");
int dan = int.Parse(Console.ReadLine());

if (dan<2 || dan>9)
{
  Console.Write("잘못된 입력입니다.");
}
else
{
  for(int i = 1; i < 10; i++)
{
  Console.WriteLine($"{dan} x {i} = {dan*i}");
}
}