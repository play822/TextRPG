using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextRPG
{
    internal class Inventory
    {
        List<ITEMINFO> haveitemsList = new List<ITEMINFO>();

        public Inventory(Item item)
        {
 
        }
        public void haveItem(Item item)
        {
            sethaveitems(item);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("\n");
                if (haveitemsList.Count != 0)
                {
                   for(int i=0;  i< haveitemsList.Count; ++i)
                    {
                        if (haveitemsList[i].wear == true)
                        {
                            string setwear = "[E]";
                            Console.WriteLine("{0}. {1}{2}  |{3}|{4}", i + 1, setwear, haveitemsList[i].name, haveitemsList[i].def, haveitemsList[i].explanation); 
                        }
                        else
                        {
                            Console.WriteLine("{0}. {1}     |{2}| {3}", i + 1, haveitemsList[i].name, haveitemsList[i].def, haveitemsList[i].explanation); 
                        }

                    }
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("1. 장착 관리");
                Console.WriteLine("0. 나가기");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    if (haveitemsList.Count == 0)
                    {
                        Console.WriteLine("아이템이 없어서 선택 불가능 합니다.");
                        Console.ReadLine();
                    }
                    else 
                    {
                        haveItemadministration();
                    }
                }
                else if (input == "0")
                {
                    return;
                }
            }
        }

        public void haveItemadministration()
        {
            Console.Clear();
            Console.WriteLine("[아이템 목록] - 장착 관리자");
            Console.WriteLine("\n");
            if (haveitemsList.Count != 0)
            {
                for (int i = 0; i < haveitemsList.Count; ++i)
                {
                    if (haveitemsList[i].wear == true)
                    {
                        string setwear = "[E]";
                        Console.WriteLine("{0}. {1}{2}  |{3}|{4}", i+1, setwear, haveitemsList[i].name, haveitemsList[i].def, haveitemsList[i].explanation); 
                    }
                    else
                    {
                        Console.WriteLine("{0}. {1}     |{2}| {3}", i+1, haveitemsList[i].name, haveitemsList[i].def, haveitemsList[i].explanation); 
                    }

                }
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("0. 나가기");

            string input = Console.ReadLine();
            int setindex = int.Parse(input)-1;


            if(int.Parse(input) > haveitemsList.Count)
            {
                Console.Clear() ;
                Console.WriteLine("잘못된 입력입니다");
                input = Console.ReadLine();
                return;
            }
            else if (input == "0")
            {
                return;
            }
            ToggleWear(setindex);
        }

        public void sethaveitems(Item item)
        {
            for (int i = 0; i < item.Itemcount; i++)
            {
                var currentItem = item.getitems(i);
                if (currentItem.have && !haveitemsList.Any(h => h.name == currentItem.name))
                {
                    haveitemsList.Add(currentItem);
                }
            }
        }

        public ITEMINFO gethaveitems(int index)
        {
            return haveitemsList[index];
        }
        public List<ITEMINFO> gethaveitems()
        {
            return haveitemsList;
        }
        public void seewearitem()
        {
            if (haveitemsList.Count != 0)
            {
                for (int i = 0; i < haveitemsList.Count; ++i)
                {
                    if (haveitemsList[i].wear == true)
                    {
                        string setwear = "[E]";
                        Console.WriteLine("{0}|{1}|{2}",haveitemsList[i].name, haveitemsList[i].def, haveitemsList[i].explanation);
                    }

                }
            }
        }
        public void ToggleWear(int index)
        {
            ITEMINFO wear = haveitemsList[index];
            wear.wear = !wear.wear;
            haveitemsList[index] = wear;
        }
    }
}
