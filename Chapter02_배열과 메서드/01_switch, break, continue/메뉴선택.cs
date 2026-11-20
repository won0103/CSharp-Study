//메뉴 선택 프로그램

while (true)
{
  Console.WriteLine("=== 학습 관리 프로그램 ===");
  Console.Write("1. 학습 시작\n2. 복습하기\n0. 종료\n");
  Console.Write("메뉴 선택: ");

  int menuNumber = int.Parse(Console.ReadLine());

  switch (menuNumber)
  {
    case 1:
    Console.WriteLine("학습을 시작합니다.");
    continue;
    case 2:
    Console.WriteLine("복습을 시작합니다.");
    continue;
    case 0:
    Console.WriteLine("프로그램을 종료합니다.");
    break;
    default:
    Console.WriteLine("잘못된 메뉴입니다.");
    continue;
  }

  break;
}