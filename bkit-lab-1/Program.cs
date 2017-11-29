using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double aCoefficient = 0;
            double bCoefficient = 0;
            double cCoefficient = 0;
            double x1 = 0;
            double x2 = 0;
            double discriminant = 0;

            Console.WriteLine("Это программа для решения квадратного уравнения.");

            RepeatA:
            Console.Write("Введите коэффициент A: ");
            try
            {
            	aCoefficient = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
            	Console.WriteLine("Вы ввели не число. " + e.Message);
            	Console.WriteLine("Подробное описание ошибки: " + e.StackTrace);
                goto RepeatA;
            }

            RepeatB:
            Console.Write("Введите коэффициент B: ");
            try
            {
                bCoefficient = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число. " + e.Message);
                Console.WriteLine("Подробное описание ошибки: " + e.StackTrace);
                goto RepeatB;
            }

            RepeatC:
            Console.Write("Введите коэффициент C: ");
            try
            {
                cCoefficient = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число. " + e.Message);
                Console.WriteLine("Подробное описание ошибки: " + e.StackTrace);
                goto RepeatC;
            }

            if (aCoefficient == 0 && bCoefficient == 0 && cCoefficient == 0)
            {
                Console.WriteLine("Данное уравнение и имеет бесконечно много решений.");
            }
            else if (aCoefficient == 0 && bCoefficient != 0 && cCoefficient != 0)
            {
                x1 = -cCoefficient / bCoefficient;
                Console.WriteLine("Корни уравнения: ", x1, " , ", x1);
            }
            else if (aCoefficient == 0 && bCoefficient == 0 && cCoefficient != 0)
            {
                Console.WriteLine("Данное уравнение не имеет корней.");
            }
            else
            {
                discriminant = (bCoefficient * bCoefficient) - (4 * aCoefficient * cCoefficient);
                if (discriminant < 0)
                {
                    double x1FirstHalf = 0;
                    double x1SecondHalf = 0;
                    double x2FirstHalf = 0;
                    double x2SecondHalf = 0;

                    discriminant = Math.Abs(discriminant);

                    x1FirstHalf = -bCoefficient / (2 * aCoefficient);
                    x2FirstHalf = -bCoefficient / (2 * aCoefficient);

                    x1SecondHalf = Math.Sqrt(discriminant) / (2 * aCoefficient);
                    x2SecondHalf = Math.Sqrt(discriminant) / (2 * aCoefficient);

                    Console.WriteLine(x1FirstHalf + "+" + x1SecondHalf + "i" + "   " + x2FirstHalf + "-" + x2SecondHalf + "i");
                }
                else if (discriminant == 0)
                {
                    x1 = (-cCoefficient + Math.Sqrt(discriminant)) / (2 * aCoefficient);
                    Console.WriteLine("Корни уравнения: " + x1 + " , " + x1);
                }
                else
                {
                    x1 = (-bCoefficient - Math.Sqrt(discriminant)) / (2 * aCoefficient);
                    x2 = (-bCoefficient + Math.Sqrt(discriminant)) / (2 * aCoefficient);
                    if (x1 > x2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Корни уравнения: " + x2 + " , " + x1);
                    }
                    else
                    {
                        Console.WriteLine("Корни уравнения: " + x1 + " , " + x2);
                    }
                }
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти.");
            Console.ReadKey();
            
        }
    }
}