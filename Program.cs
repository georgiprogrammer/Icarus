using System;
using System.Linq;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int damage = 1;
            int start = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Supernova")
            {
                string[] input = command.Split();
                string direction = input[0];
                int times = int.Parse(input[1]);
                switch (direction)
                {
                    case "left":
                        for (int i = 0; i < times; i++)
                        {
                            start--;
                            if (start < 0)
                            {
                                start = a.Length - 1;
                                damage++;
                            }
                            a[start] -= damage;
                        }
                        break;
                    case "right":
                        for (int i = 0; i < times; i++)
                        {
                            start++;
                            if (start > a.Length - 1)
                            {
                                start = a[0];
                                damage++;
                            }
                            a[start] -= damage;
                        }


                        break;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
