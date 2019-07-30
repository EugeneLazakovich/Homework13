using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1
{
    class BagList
    {
        List<Item> items = new List<Item>();

        public BagList()
        {
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
                        
        }
        int bagCapacity = 6;
        Random rnd = new Random();
        public List<Item> getBag()
        {
            List<Item> bagList = new List<Item>();
            for (int i = 0; i < bagCapacity; i++)
            {
                int rndNumb = rnd.Next(10);
                bagList.Add(items[rndNumb]);
            }
            return bagList;
        }
    }
}
