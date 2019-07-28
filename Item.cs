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
            
        }
    }
    class WindLace : Item
    {
        public WindLace(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class RingRegen : Item
    {
        public RingRegen(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class SageMask : Item
    {
        public SageMask(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class BootsSpeed : Item
    {
        public BootsSpeed(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class GlovesHaste : Item
    {
        public GlovesHaste(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class Cloak : Item
    {
        public Cloak(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class RingTarrasque : Item
    {
        public RingTarrasque(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class RingHealth : Item
    {
        public RingHealth(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class VoidStone : Item
    {
        public VoidStone(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
}