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
        public int weaponatt;
        public int weapondef;
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
                    chinpo.weaponatt = 0;
                    chinpo.weapondef = 0;
                    break;

                case 2:
                    chinpo.chad = "마법사";
                    chinpo.lv = 01;
                    chinpo.att = 10;
                    chinpo.def = 5;
                    chinpo.hp = 100;
                    chinpo.gold = 2500;
                    chinpo.weaponatt = 0;
                    chinpo.weapondef = 0;
                    break;
                case 3:
                    chinpo.chad = "궁수";
                    chinpo.lv = 01;
                    chinpo.att = 10;
                    chinpo.def = 5;
                    chinpo.hp = 100;
                    chinpo.gold = 2500;
                    chinpo.weaponatt = 0;
                    chinpo.weapondef = 0;
                    break;
            }
        }
        public void SystemOpen(Inventory inventory)
        {
            Setstatus(inventory.gethaveitems());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("LV: {0}", chinpo.lv);
                Console.WriteLine("Chad: {0}", chinpo.chad);
                Console.WriteLine("공격력: {0} ({1})", chinpo.att, chinpo.weaponatt);
                Console.WriteLine("방어력: {0} ({1})", chinpo.def, chinpo.weapondef);
                Console.WriteLine("체  력: {0}", chinpo.hp);
                Console.WriteLine("Gold: {0}\n", chinpo.gold);


                Console.WriteLine("[작용한 아이템]\n");

                inventory.seewearitem();

                Console.WriteLine("\n");

                Console.WriteLine("0. 나가기");


                string input = Console.ReadLine();

                if (input == "0")
                {
                    statusreturn();
                    return;
                }
            }
        }
        public void Setgold(int i)
        {
            chinpo.gold -= i;
        }

        public void Setstatus(List<ITEMINFO> itemstatus)
        {
          for(int i=0; i<itemstatus.Count; i++)
            {
                if(itemstatus[i].wear== true)
                {
                    if(itemstatus[i].weapon)
                    {
                        chinpo.att += itemstatus[i].def;
                        chinpo.weaponatt += itemstatus[i].def;
                    }
                    else
                    {
                        chinpo.def += itemstatus[i].def;
                        chinpo.weapondef += itemstatus[i].def;
                    }
                }
            }
            
        }

        public void statusreturn()
        {
            chinpo.lv = 01;
            chinpo.att = 10;
            chinpo.def = 5;
            chinpo.hp = 100;
            chinpo.gold = 2500;
            chinpo.weaponatt = 0;
            chinpo.weapondef = 0;
        }
    }
}
