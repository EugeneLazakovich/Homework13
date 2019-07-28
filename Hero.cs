using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1
{   
    abstract class Hero
    {
        protected string name;
        protected int intel;
        protected int agil;
        protected int stren;
        public Hero(string name, int intel, int agil, int stren)
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
    class Doom : Hero
    {
        public Doom(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }       
    }
    class Huskar : Hero
    {
        public Huskar(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
           
        }
    }
    class Medusa : Hero
    {
        public Medusa(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class Viper : Hero
    {
        public Viper(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
    class Lich : Hero
    {
        public Lich(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            
        }
    }
}
