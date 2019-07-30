using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1
{
    class HeroList : ICloneable
    {
        Dictionary<Hero, List<Item>> team1 = new Dictionary<Hero, List<Item>>();
        public HeroList()
        {
            team1.Add(new Doom("Doom", 23, 14, 31), new BagList().getBag());
            team1.Add(new Huskar("Huskar", 15, 16, 35), new BagList().getBag());
            team1.Add(new Medusa("Medusa", 16, 33, 19), new BagList().getBag());
            team1.Add(new Viper("Viper", 16, 29, 20), new BagList().getBag());
            team1.Add(new Lich("Lich", 33, 18, 20), new BagList().getBag());
        }
        public HeroList(Dictionary<Hero, List<Item>> team2)
        {
            team1 = team2;
        }
        public override string ToString()
        {
            string result = "";
            foreach (KeyValuePair<Hero, List<Item>> dd in team1)
            {
                Console.WriteLine(dd.Key);
                foreach (Item ddValue in dd.Value)
                {
                    Console.WriteLine("          " + ddValue);
                }
            }
            return result;
        }
        public object Clone()
        {
            List<Item> cloneList = new List<Item>();
            Dictionary<Hero, List<Item>> clonDic = new Dictionary<Hero, List<Item>>();


            foreach (KeyValuePair<Hero, List<Item>> dd in team1)
            {
                foreach (Item d in dd.Value)
                {
                    cloneList.Add(d);
                }
                clonDic.Add(dd.Key, dd.Value);
            }
            HeroList clonCollection = new HeroList(clonDic);

            return clonCollection;
        }
    }
}
