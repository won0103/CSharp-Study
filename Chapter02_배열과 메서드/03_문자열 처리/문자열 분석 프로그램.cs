//문자열 분석 프로그램

Console.WriteLine("=== 문자열 분석 프로그램 ===");
Console.WriteLine();
Console.Write("문자열 입력: ");
string str = Console.ReadLine();
str = str.Trim();

Console.WriteLine($"공백 제거: {str}");
Console.WriteLine($"문자열 길이: {str.Length}");
Console.WriteLine($"대문자 변환: {str.ToUpper()}");
Console.WriteLine($"소문자 변환: {str.ToLower()}");
Console.WriteLine($"CSharp 포함 여부: {str.Contains("CSharp")}");

int aCount = 0;
int spaceCount = 0;

foreach (char ch in str.ToLower())
{
  if (ch == 'a')
  {
    aCount++;
  }
  if (ch == ' ')
  {
    spaceCount++;
  }
}

Console.WriteLine($"a의 개수: {aCount}");
Console.WriteLine($"공백 개수: {spaceCount}");
