
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Add
    {
        public List<brand> listCard = new List<brand>();//扑克集合
        public string Name { get; set; }

        public Add(string a)
        {
            this.Name = a;
        }
        public void c(brand a)
        {
            listCard.Add(a);
        }
        public void Reset()//重置
        {
            listCard.Clear();
        }
        public void Introduce()
        {
            string strCards = "";

            for (int i = 0; i < listCard.Count; i++)
            {
                if (i == 0)
                {
                    strCards += listCard[i].Type + listCard[i].Name;
                }
                else
                {
                    strCards += ", " + listCard[i].Type + listCard[i].Name;
                }
            }
            Console.WriteLine("\r\n--------------------------------------------");
            Console.Write("我是{0}，", Name);
            Console.Write("我手中的扑克牌有{0}张:\r\n{1}\r\n", listCard.Count, strCards);
        }
        public void sort()
        {
            brand temporary = new brand();

            for (int y = 0; y < listCard.Count - 1; y++)
            {
                for (int c = 0; c < listCard.Count - 1 - y; c++)
                {
                    if (listCard[c].Cardvalue < listCard[c + 1].Cardvalue)
                    {
                        temporary.update(listCard[c + 1]);
                        listCard[c + 1].update(listCard[c]);
                        listCard[c].update(temporary);
                    }
                }
            }
        }
    }
}