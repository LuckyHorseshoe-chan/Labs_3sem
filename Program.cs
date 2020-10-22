using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Волгина Анна Денисовна, ИУ5-33Б");
            double A, B, C;
            HashSet<double> roots = new HashSet<double>();
                try
                {
                    if(args.Length != 3)
                    {
                        A = Convert.ToDouble(Console.ReadLine());
                        B = Convert.ToDouble(Console.ReadLine());
                        C = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        A = Convert.ToDouble(args[0]);
                        B = Convert.ToDouble(args[1]);
                        C = Convert.ToDouble(args[2]);
                    }
                    double D = B * B - 4 * A * C;
                    if (D < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No roots");
                        Console.ResetColor();
                        return;
                    }
                    double x1 = (-B + Math.Sqrt(D)) / (2 * A), x2 = (-B - Math.Sqrt(D)) / (2 * A);
                    if (x1 >= 0)
                    {
                        roots.Add(Math.Sqrt(x1));
                        roots.Add(-Math.Sqrt(x1));
                    }
                    if (x2 >= 0)
                    {
                        roots.Add(Math.Sqrt(x2));
                        roots.Add(-Math.Sqrt(x2));
                    }
                    switch (roots.Count)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No roots");
                            Console.ResetColor();
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("One root: {0}", roots.ElementAt(0));
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Two roots: {0} {1}", roots.ElementAt(0), roots.ElementAt(1));
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Three roots: {0} {1} {2}", roots.ElementAt(0), roots.ElementAt(1), roots.ElementAt(2));
                            Console.ResetColor();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Four roots: {0} {1} {2} {3}", roots.ElementAt(0), roots.ElementAt(1), roots.ElementAt(2), roots.ElementAt(3));
                            Console.ResetColor();
                            break;
                    }
                    return;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Некорректный ввод");
                    Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Собственное исключение");
                    Console.WriteLine(e.Message);
                }
        }
    }
}
