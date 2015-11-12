using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    class Program
    {

        static List<int> MinMaxList(List<int> numbers)
        {
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            List<int> res = new List<int>();
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            res.Add(min);
            res.Add(max);

            return res;
        }

        static int prosek(List<int> numbers)
        {
            int vkupno = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                vkupno += numbers[i];
            }
            vkupno = vkupno / numbers.Count();
            return vkupno;
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random random = new Random();

            Console.WriteLine("1 ---> Za racno vnesuvanje na vrednosti");
            Console.WriteLine("2 ---> Za avtomatsko generiranje na vrednosti");
            Console.Write("Vnes: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int N;
            Console.WriteLine();
            
            if (menu == 1)
            {
                Console.WriteLine("Izbravte racno vnesuvanje");
                Console.WriteLine("Vnesete broj na clenovi");
                Console.Write("Vnes: ");
                N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    Console.Write("Vnes na {0} clen: ", i);
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }
            }
            else if (menu == 2)
            {
                Console.WriteLine("Izbravte avtomatsko vnesuvanje");
                Console.WriteLine("Vnesete broj na clenovi");
                Console.Write("Vnes: ");
                N = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 0; i < N; i++)
                {
                    numbers.Add(random.Next(0, 1000));
                }
            }
            else
            {
                Console.WriteLine("Netocen vnes");
            }

            int vkupno = prosek(numbers);
            List<int> mini = MinMaxList(numbers);
            Console.WriteLine();
           // Console.WriteLine("Sredna vrednost = {0}", numbers.Average());
            Console.WriteLine("Sredna vrednost = {0}", vkupno);
            Console.WriteLine();
            //Console.WriteLine("Min = {0} Max = {1}", numbers.Min(), numbers.Max());
            Console.WriteLine("Min = {0} Max = {1}", mini[0], mini[1]);
            Console.Read();
        }
    }
}
