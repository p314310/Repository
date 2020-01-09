using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 0;

            Console.WriteLine("生成扑克");
            List<brand> a = RandomLicensing();
            Console.WriteLine("开始发牌...");


            //随机发牌系统
            for (int i = 0; i < a.Count(); i++)
            {
                int c = i + 1;
                Console.Write(c + ":");
                Console.Write(a[i].Type + a[i].Name);
                Console.Write("牌值:" + a[i].value());
                Console.WriteLine();
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("开始发牌...");
            List<Add> listUser = new List<Add>() {  //牌手进场
            new Add("A"),
            new Add("B"),
            new Add("C"),
            new Add("D")
              };
            //分配牌
            for (int i = 0; i < a.Count; i++)
            {
                listUser[q].c(a[i]);
                q++;
                if (q == 4)
                {
                    q = 0;
                }
            }




            for (int i = 0; i < listUser.Count; i++)  //四个玩家
            {
                listUser[i].sort();
            }

            foreach (var item in listUser)
            {
                item.Introduce();
            }

            Console.Read();

        }
        //扑克牌生成
        static List<brand> RandomLicensing()
        {
            List<brand> myCards = new List<brand>();//扑克牌集合
            string[] strType = { "红桃", "黑桃", "梅花", "方块" };
            string[] strNumber = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            brand[] OtherCard = { new brand("大王", ""), new brand("小王", "") };

            myCards.Add(OtherCard[0]);
            myCards.Add(OtherCard[1]);
            for (int i = 0; i < strType.Length; i++)
            {
                for (int t = 0; t < strNumber.Length; t++)
                {
                    brand p = new brand(strType[i], strNumber[t]);
                    myCards.Add(p);
                }
            }

            //洗牌
            List<brand> stackCard = new List<brand>();
            Random r = new Random(); //随机数生成器

            while (myCards.Count > 0) //元素转移，转移后移除扑克，新集合中见
            {
                int iIndex = r.Next(0, myCards.Count);
                stackCard.Add(myCards[iIndex]);
                myCards.RemoveAt(iIndex);
            }

            return stackCard;



        }
    }
}
