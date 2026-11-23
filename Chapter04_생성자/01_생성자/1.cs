//학생 정보 관리 프로그램
Student student1 = new Student("홍길동", 80);
Student student2 = new Student("김철수", 95);

Console.WriteLine("=== 학생 정보 관리 프로그램 ===");
Console.WriteLine("\n[초기 학생 정보]");
student1.PrintInfo();
student2.PrintInfo();

Console.WriteLine("\n[점수 추가 후]");
student1.AddScore(15);
student2.AddScore(10);
student1.PrintInfo();
student2.PrintInfo();

Console.WriteLine("\n[잘못된 점수 추가]");
student1.AddScore(-5);
student1.PrintInfo();

class Student
{
  public string Name;
  public int Score;

  public Student(string name, int score)
  {
    if (score < 0 || score > 100)
    {
      score = 0;
    }

    Name = name;
    Score = score;
  }

  public void AddScore(int amount)
  {
    if (amount > 0)
    {
      Score += amount;
      if (Score > 100)
      {
        Score = 100;
      }
    }
  }
  public void PrintInfo()
  {
    Console.WriteLine($"{Name}: {Score}점");
  }
}