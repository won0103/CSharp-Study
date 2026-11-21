//학생 성적 관리 프로그램

int[] scores = { 85, 92, 76, 58, 94 };
int studentCount = 0;

//평균 점수 계산
double CalculateAverage(int[] scores)
{
  double sum = 0;
  double avg;

  foreach (int score in scores)
  {
    sum += score;
  }

  avg = sum / scores.Length;

  return avg;
}

//최고 점수 찾기
int FindHighest(int[] scores)
{
  int highest = scores[0];

  foreach (int score in scores)
  {
    if (highest < score)
    {
      highest = score;
    }

  }
  return highest;
}

//합격자 수 계산
int CountPassed(int[] scores)
{
  int count = 0;

  foreach (int score in scores)
  {
    if (score >= 60)
    {
      count++;
    }
  }

  return count;
}

//최저 점수 찾기
int FindLowest(int[] scores)
{
  int lowest = scores[0];

  foreach (int score in scores)
  {
    if (lowest > score)
    {
      lowest = score;
    }

  }
  return lowest;
}

//평균 이상 학생 수 계산
int CountAboveAverage(int[] scores, double average)
{
  int countAboveAverage = 0;

  foreach (int score in scores)
  {
    if (score >= average)
    {
      countAboveAverage++;
    }
  }

  return countAboveAverage;
}

//출력
Console.WriteLine("=== 학생 성적 관리 프로그램 ===\n");
Console.WriteLine("[전체 학생 점수]");

foreach (int score in scores)
{
  studentCount++;
  Console.WriteLine($"{studentCount}번 학생: {score}점");
}

double average = CalculateAverage(scores);

Console.WriteLine("\n[성적 통계]");
Console.WriteLine($"평균 점수: {average}점");
Console.WriteLine($"최고 점수: {FindHighest(scores)}점");
Console.WriteLine($"최저 점수: {FindLowest(scores)}점");
Console.WriteLine($"합격자 수: {CountPassed(scores)}명");
Console.WriteLine($"불합격자 수: {scores.Length - CountPassed(scores)}명");
Console.WriteLine($"평균 이상 수: {CountAboveAverage(scores, average)}명");
