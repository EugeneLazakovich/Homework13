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
            name = "Doom";
            intel = 23;
            agil = 14;
            stren = 31;
        }
    }
    class Huskar : Hero
    {
        public Huskar(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Huskar";
            intel = 15;
            agil = 16;
            stren = 35;
        }
    }
    class Medusa : Hero
    {
        public Medusa(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Medusa";
            intel = 16;
            agil = 33;
            stren = 19;
        }
    }
    class Viper : Hero
    {
        public Viper(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Viper";
            intel = 16;
            agil = 29;
            stren = 20;
        }
    }
    class Lich : Hero
    {
        public Lich(string name, int intel, int agil, int stren) : base(name, intel, agil, stren)
        {
            name = "Lich";
            intel = 33;
            agil = 18;
            stren = 20;
        }
    }
}
