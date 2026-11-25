Student student = new Student();

student.Score = 80;
Console.WriteLine(student.Score);

student.Score = 150;
Console.WriteLine(student.Score);

student.Score = 95;
Console.WriteLine(student.Score);

class Student
{
  private int _score;

  public int Score
  {
    get
    {
      return _score;
    }
    set
    {
      if (value >= 0 && value <= 100)
      {
        _score = value;
      }
    }
  }
}