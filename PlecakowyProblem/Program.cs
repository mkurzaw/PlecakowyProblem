using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seed=0;
            int num = 0;
            Generator generator_mass = new Generator(num, seed);
            Console.WriteLine(generator_mass.ToString());
            Generator generator_val = new Generator(num, seed);
            Console.WriteLine(generator_val.ToString());
            //Console.WriteLine(generator_val.numbers[0]);
            //Console.ReadLine();
            int all = 0;
            for(int i = 1; i < generator_val.numbers.Count; i++)
            {
                all += (generator_mass.numbers[i]);
                
            }
            
            double total=(0.6*all);
            int[] X=new int[10];
            int mass=0;
            int value=0;

            
            for (int i = 1; i<generator_val.numbers.Count; i++)
            {
                if (generator_mass.numbers[i] < total)
                {
                    X[i] = 1;
                    mass = generator_mass.numbers[i] + mass;
                    value = generator_val.numbers[i] + value;


                    total = total - generator_mass.numbers[i];
                }
                else
                    X[i] = 0;
            }
             Console.WriteLine("Masa: "+ mass);
             Console.WriteLine("Wartosc: "+ value);
           
        }
    }
}
