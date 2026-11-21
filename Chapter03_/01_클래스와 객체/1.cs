Student student1 = new Student();

student1.Name = "홍길동";
student1.Age = 20;
student1.Score = 90;

student1.PrintInfo();

class Student
{
  public string Name = "";
  public int Age;
  public int Score;

  public void PrintInfo()
  {
    Console.WriteLine($"이름: {Name}");
    Console.WriteLine($"나이: {Age}");
    Console.WriteLine($"점수: {Score}");
  }

}