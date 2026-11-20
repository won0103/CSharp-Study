Console.Write("첫 번째 정수: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("두 번째 정수: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"덧셈: {a + b}");
Console.WriteLine($"뺄셈: {a - b}");
Console.WriteLine($"곱셈: {a * b}");
Console.WriteLine($"나눗셈: {(double)a / b}");
Console.WriteLine($"나머지: {a % b}");
