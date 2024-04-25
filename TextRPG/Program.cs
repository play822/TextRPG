using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;


namespace TextRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("직업을 정해주세요 :1, 전사, 2,마법사, 3.궁수");
            string input = Console.ReadLine();
            Player player = new Player(int.Parse(input));
            Item item = new Item();
            Inventory inventory = new Inventory(item);
            Shop shop = new Shop();
            while (true) 
            { 
              GameStart(player, inventory, item, shop); 
            }
        }

        static void GameStart(Player player, Inventory inventory, Item item, Shop shop)
        {
            Console.Clear();

            Console.WriteLine("\n\n");

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\r\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");

            Console.WriteLine("\n\n");

            Console.WriteLine("1. 상태 보기");

            Console.WriteLine("2. 인벤토리.");

            Console.WriteLine("3. 상점");

            Console.WriteLine("4. 종료");

            string Input = Console.ReadLine();

            switch (int.Parse(Input))
            {
                case 1:
                    player.SystemOpen(inventory);
                    break;
                    
                case 2:
                    inventory.haveItem(item);
                    break;
                        
                case 3:
                    shop.showItem(item, player);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default: Console.WriteLine("다시 선택해 주세요");
                    Console.Clear();
                    return;
            }
        }
        
    }
}
