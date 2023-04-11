using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class Program
    {

        public class Animal
        {
            public double weight;
            public double height;
            public void Info()
            {
                Console.WriteLine("height" + height + "weight" + weight);
            }

        }

        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.weight = 1.0;
            Dog.height = 4.0;
            Animal Cat = new Animal();
            Cat.weight = 1.0;
            Cat.height = 5.0;

            Dog.Info();
            Cat.Info();
        }
    }
}