using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class brand
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public int Cardvalue { get; set; }

        public brand()
        { }


        public brand(string type, string name)
        {
            this.Type = type;
            this.Name = name;
            Cardvalue = value();
        }
        //传入数值更新
        public void update(brand a)
        {
            this.Type = a.Type;
            this.Name = a.Name;
            this.Cardvalue = a.Cardvalue;
        }


        //牌值计算
        public int value()
        {
            int a = 0;

            switch (Type)
            {
                case "方块":
                    a = 0;
                    break;
                case "梅花":
                    a = 13;
                    break;
                case "红桃":
                    a = 26;
                    break;
                case "黑桃":
                    a = 39;
                    break;
                case "小王":
                    a = 53;
                    break;
                case "大王":
                    a = 54;
                    break;
            }

            switch (Name)
            {
                case "A":
                    a += 1;
                    break;
                case "J":
                    a += 11;
                    break;
                case "Q":
                    a += 12;
                    break;
                case "K":
                    a += 13;
                    break;

                default:
                    if (Name != "")
                    {
                        a += int.Parse(Name);
                    }
                    break;
            }
            return a;
        }
    }
}
