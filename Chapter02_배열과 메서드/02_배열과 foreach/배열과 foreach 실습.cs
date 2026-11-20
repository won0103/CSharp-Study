//학생 점수 관리 프로그램

int[] scores = { 80, 90, 75, 95, 63 };

int sum = 0;
int countAbove80 = 0;

Console.WriteLine("=== 학생 점수 관리 프로그램 ===");
Console.WriteLine();
Console.Write("학생 점수: ");

int highScore = scores[0];
int lowScore = scores[0];

foreach (int score in scores)
{
  if (score > highScore)
  {
    highScore = score;
  }

  if (score < lowScore)
  {
    lowScore = score;
  }

  if (score >= 80)
  {
   countAbove80++; 
  }
  sum += score;

  Console.Write($"{score} ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"총점: {sum}점");
Console.WriteLine($"평균: {(double)sum/scores.Length}점");
Console.WriteLine($"80점 이상 학생: {countAbove80}명");
Console.WriteLine($"최고 점수: {highScore}점");
Console.WriteLine($"최저 점수: {lowScore}점");
