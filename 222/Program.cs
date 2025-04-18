// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

List<string> inventory = new List<string>();  // 가변형 배열(리스트) / 선언 내 가방(인벤토리)에 아이템 이름을 저장하는 리스트
List<int> purchased = new List<int>(); // 상점에서 이미 구매한 아이템의 번호를 저장하는 리스트
int gold = 5500;
int atk = 3;
int def = 0;

int armor = 1000;
int armor2 = 400;
int armor3 = 3500;
int sorld = 600;
int axe = 1500;
int spear = 300;

int choice; //정수형 자료형 선언
bool check; //부우우울린 자료형 선언 (bool)



while (true)
{
    Console.Clear();
    Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
    Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다");

    Console.WriteLine();
    Console.WriteLine("1. 상태 보기");
    Console.WriteLine("2. 인벤토리");
    Console.WriteLine("3. 상점");

    Console.WriteLine();
    Console.Write("원하시는 행동을 입력해주세요: ");
    string input = Console.ReadLine();

    check = int.TryParse(input, out choice); //체크는 트루랑 펄스 확인. 트라이패스 인풋이 인트로 변환이되는지 확인 / 확인후 변환값을 넣어줌
    if (!check) //!부정 (위에 내용을 부정한다)
    {
        Console.WriteLine("잘못된 입력입니다.");
    }

    switch (choice)
    {
        case 1:
            
            Console.Clear();
            Console.WriteLine("상태보기 \n캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine("Lv. 01\nYeji( 전사 )");
            Console.WriteLine($"공격력:{atk}");
            Console.WriteLine($"방어력:{def}");
            Console.WriteLine("체력 : 100");
            Console.WriteLine($"Gold:{gold}");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            string back1 = Console.ReadLine(); //변수선언 (변수사용시 무조건 먼저써두기)
            if (back1 == "0") continue;
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("인벤토리 \n보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            if (inventory.Count == 0)
            {
                Console.WriteLine("보유 중인 아이템이 없습니다.");
            }
            else
            {
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{inventory[i]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.Write(">> ");

            string back2 = Console.ReadLine();
            if (back2 == "0") continue;
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine($"[보유 골드]\n{gold} G");
            Console.WriteLine("\n[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine($"- 수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다.{armor} G"); 
            Console.WriteLine($"- 무쇠 갑옷 | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. {armor2}G");
            Console.WriteLine($"- 스파르타의 갑옷 | 방어력 +15 | 전설의 갑옷입니다.  {armor3}G");
            Console.WriteLine($"- 낡은 검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검입니다. {sorld}G");
            Console.WriteLine($"- 청동 도끼 | 공격력 +5 | 어디선가 사용됐던 도끼입니다. {axe}G");
            Console.WriteLine($"- 스파르타의 창 | 공격력 +7 | 전설의 창입니다.  {spear}G");
            Console.WriteLine();

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.Write(">> ");


            string shopMenu = Console.ReadLine(); //변수선언
            if( shopMenu == "1")
            {
                Console.Clear();
                Console.WriteLine("상점 - 아이템 구매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine();
                Console.WriteLine("[보유 골드]");
                Console.WriteLine($"{gold}G");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine($"1 - 수련자 갑옷 | 방어력 +5 | 수련에 도움을 주는 갑옷입니다.{armor}G");
                Console.WriteLine($"2 - 무쇠 갑옷 | 방어력 +9 | 무쇠로 만들어져 튼튼한 갑옷입니다. {armor2}G");
                Console.WriteLine($"3 - 스파르타의 갑옷 | 방어력 +15 | 전설의 갑옷입니다.  {armor3}G");
                Console.WriteLine($"4 - 낡은 검 | 공격력 +2 | 쉽게 볼 수 있는 낡은 검입니다. {sorld}G");
                Console.WriteLine($"5 - 청동 도끼 | 공격력 +5 | 어디선가 사용됐던 도끼입니다. {axe}G");
                Console.WriteLine($"6 - 스파르타의 창 | 공격력 +7 | 전설의 창입니다.  {spear}G");
                Console.WriteLine();
                Console.WriteLine("0.나가기");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">>");



                string itemInput = Console.ReadLine();
                int itemNum = int.Parse(itemInput);

                if (itemNum == 0)
                {
                    continue;
                }
                else if(purchased.Contains(itemNum))  //purchased.맨위에 리스트 적은거,Contains 포함되어있니(itemNum)아이템순서가
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                }
                else if (itemNum == 1 && gold >= armor)
                {
                    inventory.Add("수련자 갑옷");
                    def += 5;
                    gold -= armor;
                    purchased.Add(1);
                    

                    Console.WriteLine("수련자 갑옷을 구매했습니다!");
                }
                else if (itemNum == 2 && gold >= armor)
                {
                    inventory.Add("무쇠 갑옷");
                    def += 5;
                    gold -= armor;
                    purchased.Add(2);


                    Console.WriteLine("수련자 갑옷을 구매했습니다!");
                }

            }

            string back3 = Console.ReadLine();
            if (back3 == "0") continue;
            break;

        default:
            Console.WriteLine("잘못된 입력입니다.");
            Console.ReadLine();
            continue;
    }
}
