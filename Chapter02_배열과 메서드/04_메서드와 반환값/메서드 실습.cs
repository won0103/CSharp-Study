// //메서드를 활용한 사칙연산 계산기

// Add()	두 수의 합 반환
// Subtract()	두 수의 차 반환
// Multiply()	두 수의 곱 반환
// Divide()	두 수의 나눗셈 결과 반환

int Add(int a, int b)
{
  return (a + b);
}

int Subtract(int a, int b)
{
  return (a - b);
}

int Multiply(int a, int b)
{
  return (a * b);
}

double Divide(double a, double b)
{
  return (a / b);
}

int Modulo(int a, int b)
{
  return (a % b);
}

Console.WriteLine("=== 사칙연산 계산기 ===");
Console.Write("\n첫 번째 숫자: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("\n두 번째 숫자: ");
int secondNum = int.Parse(Console.ReadLine());

int sum = Add(firstNum, secondNum);
int difference = Subtract(firstNum, secondNum);
int product = Multiply(firstNum, secondNum);

Console.WriteLine($"덧셈: {sum}");
Console.WriteLine($"뺄셈: {difference}");
Console.WriteLine($"곱셈: {product}");

if (secondNum == 0)
{
  Console.WriteLine("0으로 나눌 수 없습니다.");
}
else
{
  double quotient = Divide(firstNum, secondNum);
  int remainder = Modulo(firstNum, secondNum);

  Console.WriteLine($"나눗셈: {quotient}");
  Console.WriteLine($"나머지: {remainder}");
}
