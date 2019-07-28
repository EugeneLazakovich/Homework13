using System;
using System.Collections.Generic;

namespace _13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new MagicStick("Magic Stick", 10, 12, 6));
            items.Add(new WindLace("Wind Lace", 8, 14, 9));
            items.Add(new RingRegen("Ring of Regen", 6, 15, 10));
            items.Add(new SageMask("Sage's Mask", 13, 10, 7));
            items.Add(new BootsSpeed("Boots of Speed", 7, 15, 8));
            items.Add(new GlovesHaste("Gloves of Haste", 7, 10, 13));
            items.Add(new Cloak("Cloak", 10, 13, 4));
            items.Add(new RingTarrasque("Ring of Tarrasque", 9, 10, 13));
            items.Add(new RingHealth("Ring of Health", 10, 12, 9));
            items.Add(new VoidStone("Void Stone", 7, 15, 11));

            int bagCapacity = 6;
            Random rnd = new Random();
            List<Item> getBag()
            {
                List<Item> bagList = new List<Item>();
                for (int i = 0; i < bagCapacity; i++)
                {
                    int rndNumb = rnd.Next(10);
                    bagList.Add(items[rndNumb]);
                }
                return bagList;
            }

            Dictionary<Hero, List<Item>> team1 = new Dictionary<Hero, List<Item>>();
            team1.Add(new Doom("Doom", 23, 14, 31), getBag());
            team1.Add(new Huskar("Huskar", 15, 16, 35), getBag());
            team1.Add(new Medusa("Medusa", 16, 33, 19), getBag());
            team1.Add(new Viper("Viper", 16, 29, 20), getBag());
            team1.Add(new Lich("Lich", 33, 18, 20), getBag());

            foreach(KeyValuePair<Hero, List<Item>> dd in team1)
            {
                Console.WriteLine(dd.Key);
                foreach(Item ddValue in dd.Value)
                {
                    Console.WriteLine("          " + ddValue);
                }
            }
        }
    }
}
