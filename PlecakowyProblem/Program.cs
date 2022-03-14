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
            Generator generator_mass = new Generator(10, 1);
            Console.WriteLine(generator_mass.ToString());
            Generator generator_val = new Generator(10, 2);
            Console.WriteLine(generator_val.ToString());
            Console.WriteLine(generator_val.numbers[0]);
            Console.ReadLine();
            int all = 0;
            for(int i = 1; i < generator_val.numbers.Count; i++)
            {
                all += (generator_mass.numbers[i]);
                
            }
            
            double total=(0.6*all);
            Vector<int>[] backpack;
            backpack = new Vector<int>[2];
        
            for(int i = 1; i<generator_val.numbers.Count; i++)
            {
                if(generator_mass.numbers[i]<total)
                    {
                        backpack[0,i]=generator_mass.numbers[i];
                        backpack[1][i]=generator_val.numbers[i];
                        
                        total=total - generator_mass.numbers[i];
                    }
                else 
                    Console.WriteLine();
            }
            
        }
    }
}
