using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            


            Write("How many size in total: ");
            string sSize = ReadLine();
            int i = Convert.ToInt32(sSize);
            int[] score = new int[i];



           
            for (int a = 1; a < i + 1; a++)
            {

                Write("Please enter a size " + a + " from 0 to 100: ");
                string testArray = ReadLine();


                int g = Convert.ToInt32(testArray);

                int[] tests = new int[g];

                
                foreach (var item in tests)
                    Console.WriteLine(item);





            }

        }
    }
}