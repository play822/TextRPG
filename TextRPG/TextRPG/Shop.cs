using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Shop
    {
        public void showItem(Item item, Player player)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[상점]");
                Console.WriteLine("[필요한 아이템을 얻을 수 있는 상점입니다.]");
                Console.WriteLine("\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine("[{0}G]", player.chinpo.gold);
                Console.WriteLine("\n");
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < item.Itemcount; ++i)
                    {
                        if (item.getitems(i).have)
                            {
                                Console.WriteLine("- {0} |{1} | {2} | [구매완료]", item.getitems(i).name, item.getitems(i).def, item.getitems(i).explanation);
                            }
                        else
                            {
                                Console.WriteLine("- {0} |{1} | {2} | {3}", item.getitems(i).name, item.getitems(i).def, item.getitems(i).explanation, item.getitems(i).gold);
                            }
                    }
                

                Console.WriteLine("\n\n");
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    showbyeItemlist(item, player);
                }
                else if (input == "0")
                {
                    return;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다");
                    input = Console.ReadLine();
                }
            }
        }

        public void showbyeItemlist(Item item, Player player)
        {
                Console.Clear();
                Console.WriteLine("[상점] - 아이템 구매");
                Console.WriteLine("[필요한 아이템을 얻을 수 있는 상점입니다.]");
                Console.WriteLine("\n");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine("[{0}G]", player.chinpo.gold);
                Console.WriteLine("\n");
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < item.Itemcount; ++i)
                {
                    if (item.getitems(i).have)
                    {
                        Console.WriteLine("{0}. {1} | {2} | {3} | [구매완료]", i+1,item.getitems(i).name, item.getitems(i).def, item.getitems(i).explanation);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1} | {2} | {3} | {4}", i+1,item.getitems(i).name, item.getitems(i).def, item.getitems(i).explanation, item.getitems(i).gold);
                    }
                }


                Console.WriteLine("\n\n");
                Console.WriteLine("0. 나가기");

                string input = Console.ReadLine();
                int index = int.Parse(input)-1;

                if (index >= 0 && index < 6)
                {
                    byeitem(item, player, index);
                }
                else if (input == "0")
                {
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다");
                    input = Console.ReadLine();
                }
        }

        public void byeitem(Item item, Player player, int index)
        {
            if (item.getitems(index).have)
            {
                Console.Clear();
                Console.WriteLine("이미 구매한 아이템 입니다.");
                Console.ReadLine();
            }
            else
            {
                if (player.chinpo.gold >= item.getitems(index).gold)
                {
                    item.sethaveitems(index);
                    player.Setgold(item.getitems(index).gold);
                    Console.WriteLine("아이템 구매 완료했습니다.");
                    Console.ReadLine();
                }
                else
                { 
                    Console.Clear(); 
                    Console.WriteLine(" Gold 가 부족합니다. ");
                    Console.ReadLine();
                }
            } 
        }
    }
}
