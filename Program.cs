using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Snowmen
    {
        string name;
        double mass = 10;
        

        public Snowmen (string _name, int _mass) ////massi ei pea siia panema, kuna massil on väärtus juba
        {
            name = _name;
            mass = _mass;
        }

        public string Name
        {
            get { return name; } ///set-i ole, et ei saaks seda hiljem ümber nimetada
           
        }
        public double Mass
        {
            get { return mass; }
        }

        public void Melting(int temperature)
        {

            if (temperature >= 0)
            {
                mass -= mass * 20 / 100; ////mass = mass - (mass *0,2)
                Console.WriteLine("Help, I am melting!");
            }
    
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Snowmen snowman = new Snowmen("Elga", 10);

            Console.WriteLine($"Hello, I am {snowman.Name}");
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                
                int temperature = rnd.Next(-5, 11); 
                snowman.Melting(temperature);
                Console.WriteLine(temperature);
            }
            Console.WriteLine($"{snowman.Name} final mass is {snowman.Mass} kg.");
            Console.ReadLine();
        }
    }
}
