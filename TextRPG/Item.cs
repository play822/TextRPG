using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{

    public struct ITEMINFO
    {
        public string name;
        public int def;
        public string explanation;
        public int gold;
        public bool wear;
        public bool have;
        public bool weapon;
    }

    internal class Item
    {
        public ITEMINFO tem = new ITEMINFO();
        ITEMINFO[] items = new ITEMINFO[5];
        int itemcount;
        public int Itemcount { get { return itemcount; } set { itemcount = value; } }
        public Item()
        {
            itemcount = 5;
            for (int i = 0; i < itemcount; i++)
            {
                switch (i)
                {
                    case 0:
                        tem.name = "수련자 갑옷";
                        tem.def = 5;
                        tem.gold = 1000;
                        tem.explanation = "수련에 도움을 주는 갑옷입니다";
                        tem.wear = false;
                        tem.have = false;
                        tem.weapon = false;
                        items[i] = tem;
                        break;
                    case 1:
                        tem.name = "무쇠갑옷";
                        tem.def = 9;
                        tem.gold = 1800;
                        tem.explanation = "무쇠로 만들어져 튼튼한 갑옷입니다.";
                        tem.wear = false;
                        tem.have = false;
                        tem.weapon = false;
                        items[i] = tem;
                        break;
                    case 2:
                        tem.name = "스파르타 갑옷";
                        tem.def = 15;
                        tem.gold = 3500;
                        tem.explanation = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
                        tem.wear = false;
                        tem.have = false;
                        tem.weapon = false;
                        items[i] = tem;
                        break;
                    case 3:
                        tem.name = "낡은 검";
                        tem.def = 2;
                        tem.gold = 600;
                        tem.explanation = "쉽게 볼 수 있는 낡은 검 입니다.";
                        tem.wear = false;
                        tem.have = false;
                        tem.weapon = true;
                        items[i] = tem;
                        break;
                    case 4:
                        tem.name = "청동 도끼";
                        tem.def = 5;
                        tem.gold = 1500;
                        tem.explanation = " 어디선가 사용됐던거 같은 도끼입니다.";
                        tem.wear = false;
                        tem.have = false;
                        tem.weapon = true;
                        items[i] = tem;
                        break;
                    case 5:
                        tem.name = "스파르타 창";
                        tem.def = 7;
                        tem.gold = 2700;
                        tem.explanation = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
                        tem.wear = false;
                        tem.have = false;
                        tem.weapon = true;
                        items[i] = tem;
                        break;
                }
            }
        }
        public ITEMINFO getitems(int i)
        {
                return items[i];
        }
        public void sethaveitems(int i)
        {
            items[i].have = !items[i].have;
        }

    }
}
