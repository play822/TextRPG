using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    struct CHINFO
    {
        public string chad;
        public int lv;
        public int att;
        public int def;
        public int hp;
        public int gold;
    }
    internal class Player
    {
        public CHINFO chinpo = new CHINFO();
        public Player(int chnum)
        {
            switch (chnum)
            {
                case 1:
                    chinpo.chad = "전사";
                    chinpo.lv = 01;
                    chinpo.att = 10;
                    chinpo.def = 5;
                    chinpo.hp = 100;
                    chinpo.gold = 2500;
                    break;

                case 2:
                    chinpo.chad = "마법사";
                    chinpo.lv = 01;
                    chinpo.att = 10;
                    chinpo.def = 5;
                    chinpo.hp = 100;
                    chinpo.gold = 2500;
                    break;
                case 3:
                    chinpo.chad = "궁수";
                    chinpo.lv = 01;
                    chinpo.att = 10;
                    chinpo.def = 5;
                    chinpo.hp = 100;
                    chinpo.gold = 2500;
                    break;
            }
        }
        public void SystemOpen(Inventory inventory)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("LV: {0}", chinpo.lv);
                Console.WriteLine("Chad: {0}", chinpo.chad);
                Console.WriteLine("공격력: {0}", chinpo.att);
                Console.WriteLine("방어력: {0}", chinpo.def);
                Console.WriteLine("체  력: {0}", chinpo.hp);
                Console.WriteLine("Gold: {0}", chinpo.gold);


                Console.WriteLine("[작용한 아이템]");

                inventory.seewearitem();

                Console.WriteLine("0. 나가기");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    return;
                }
            }
        }
        public void Setgold(int i)
        {
            chinpo.gold -= i;
        }
    }
}
