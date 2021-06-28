using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(HighAndLow1("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }


        public static string HighAndLow1(string numbers)
        {
            var mpla = numbers.Split();
            var ampla = mpla.Select(int.Parse);
            return mpla.Max() + " " + mpla.Min();
            
        }
        public static string HighAndLow(string numbers)
        {
            string[] text = numbers.Split(' ');
            int[] array = new int[text.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(text[i]);
            }
            return string.Format($"{array.Max()} {array.Min()}");
        }
    }
}
