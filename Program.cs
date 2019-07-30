using System;
using System.Collections;
using System.Collections.Generic;

namespace _13._1
{    
    class Program 
    {
        static void Main(string[] args)
        {
            HeroList team1 = new HeroList();
            Console.WriteLine(team1.ToString());
            Console.WriteLine("----------------------------------");
            HeroList team2 = (HeroList)team1.Clone();
            Console.WriteLine(team2.ToString());            
        }        
    }
}
