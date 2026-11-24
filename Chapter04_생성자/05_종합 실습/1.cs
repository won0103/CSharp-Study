//교육센터 수강 등록 시스템
Console.WriteLine("=== 교육센터 수강 등록 시스템 ===");

Console.WriteLine("\n[등록 전 센터 현황]");
Student.PrintCenterInfo();

Student student1 = new Student("홍길동");
Student student2 = new Student("김철수", "엑셀 실무", 200000);
Student student3 = new Student("박민수", "C# 프로그래밍", 300000);
Student student4 = new Student("이영희");
Student student5 = new Student("김민수", -50000);

Console.WriteLine("\n[수강생 정보]");
student1.PrintStudentInfo();
student2.PrintStudentInfo();
student3.PrintStudentInfo();
student4.PrintStudentInfo();
student5.PrintStudentInfo();

Console.WriteLine("\n[등록 후 센터 현황]");
Student.PrintCenterInfo();

class Student
{
  public string Name;
  public string Course;
  public int Tuition;

  public static int Count = 0;
  public static int TuitionSum = 0;

  public Student(string name) : this(name, "컴퓨터 기초", 100000)
  {

  }
  public Student(string name, int tuition) : this(name, "컴퓨터 기초", tuition)
  {

  }
  public Student(string name, string course, int tuition)
  {
    Name = name;
    Course = course;
    if (tuition <= 0)
    {
      Tuition = 0;
    }
    else
    {
      Tuition = tuition;
    }
    TuitionSum += Tuition;
    Count++;
  }

  public static double CalculateAverage()
  {
    if (Count == 0)
    {
      return 0;
    }
    else
    {
      return (double)TuitionSum / Count;
    }
  }

  public void PrintStudentInfo()
  {
    Console.WriteLine($"{Name} / {Course} / {Tuition}원");
  }
  public static void PrintCenterInfo()
  {
    Console.WriteLine($"총 등록 인원: {Count}명");
    Console.WriteLine($"총 수강료: {TuitionSum}원");
    Console.WriteLine($"평균 수강료: {CalculateAverage()}원");
  }
}