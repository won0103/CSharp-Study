//직원 관리 시스템

Console.WriteLine("=== 직원 관리 시스템 ===");

Console.WriteLine("\n[직원 생성 전]");
Employee.PrintCompanyInfo();


Employee employee1 = new Employee("홍길동", 3000000);
Employee employee2 = new Employee("김철수", 3500000);
Employee employee3 = new Employee("박민수", 4000000);

Console.WriteLine("\n[직원 정보]");
employee1.PrintEmployeeInfo();
employee2.PrintEmployeeInfo();
employee3.PrintEmployeeInfo();

Console.WriteLine("\n[회사 정보]");
Employee.PrintCompanyInfo();

class Employee
{
  public string Name;
  public int Salary;
  public static int Count = 0;
  public static int TotalSalary = 0;

  public Employee(string name, int salary)
  {
    this.Name = name;
    this.Salary = salary;

    Count++;
    TotalSalary += salary;
  }

  public void PrintEmployeeInfo()
  {
    Console.WriteLine($"{Name}: {Salary}원");
  }

  public static double CalculateAverage()
  {
    if (Count == 0)
    {
      return 0;
    }
    else
    {
      return (double)TotalSalary / Count;
    }

  }
  public static void PrintCompanyInfo()
  {
    Console.WriteLine($"총 직원 수: {Count}명");
    Console.WriteLine($"전체 월급 합계: {TotalSalary}원");
    Console.WriteLine($"평균 월급: {Employee.CalculateAverage()}원");
  }
}