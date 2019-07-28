using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1
{
    abstract class Item
    {
        protected string name;
        protected int intel;
        protected int agil;
        protected int stren;
        public Item(string name, int intel, int agil, int stren)
        {
            this.name = name;
            this.intel = intel;
            this.agil = agil;
            this.stren = stren;
        }
        public override string ToString()
        {
            return "Name: " + name + "; Intelligence: " + intel + "; Agility: " + agil + "; Strenght: " + stren;
        }
    }
    class MagicStick : Item
    {
        public MagicStick(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Magic Stick";
            intel = 10;
            agil = 12;
            stren = 6;
        }
    }
    class WindLace : Item
    {
        public WindLace(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Wind Lace";
            intel = 8;
            agil = 14;
            stren = 9;
        }
    }
    class RingRegen : Item
    {
        public RingRegen(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Ring of Regen";
            intel = 6;
            agil = 15;
            stren = 10;
        }
    }
    class SageMask : Item
    {
        public SageMask(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Sage's Mask";
            intel = 13;
            agil = 10;
            stren = 7;
        }
    }
    class BootsSpeed : Item
    {
        public BootsSpeed(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Boots of Speed";
            intel = 7;
            agil = 15;
            stren = 8;
        }
    }
    class GlovesHaste : Item
    {
        public GlovesHaste(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Gloves of Haste";
            intel = 7;
            agil = 10;
            stren = 13;
        }
    }
    class Cloak : Item
    {
        public Cloak(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Cloak";
            intel = 10;
            agil = 13;
            stren = 4;
        }
    }
    class RingTarrasque : Item
    {
        public RingTarrasque(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Ring of Tarrasque";
            intel = 9;
            agil = 10;
            stren = 13;
        }
    }
    class RingHealth : Item
    {
        public RingHealth(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Ring of Health";
            intel = 10;
            agil = 12;
            stren = 9;
        }
    }
    class VoidStone : Item
    {
        public VoidStone(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Void Stone";
            intel = 7;
            agil = 15;
            stren = 11;
        }
    }
}