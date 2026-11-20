//랜덤 숫자 맞추기
Console.WriteLine("=== 숫자 맞히기 게임 ===");
Console.WriteLine("1부터 100 사이의 숫자를 맞혀보세요!");

int count = 0;
int answer = Random.Shared.Next(1,101);

while (true)
{
  Console.Write("숫자 입력: ");
  int number = int.Parse(Console.ReadLine());

  if(number > 100 || number < 1)
  {
    Console.WriteLine("1부터 100 사이의 숫자를 입력해주세요.");
  }
  else
  {
      count++;
      
      if(number != answer)
  {
    if (number < answer)
    {
      Console.WriteLine("UP!");
    }
    else
    {
      Console.WriteLine("DOWN!");
    }
  }
  else
  {
    Console.WriteLine("정답입니다!");
    Console.WriteLine($"총 시도 횟수: {count}회");
    break;
  }
  }
}
