using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class _2ndvariant

    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    int num2 = int.Parse(Console.ReadLine());

                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Ошибка: деление на ноль!");
                    }

                    Console.WriteLine($"Результат деления {num1} на {num2} равен: {num1 / num2}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число!");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }


}

