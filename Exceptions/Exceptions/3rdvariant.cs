using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class FunctionCalculator
    {
        public void CalculateFunction(int k, double N)
        {
            try
            {
                for (double x = 0; x <= k; x += 0.1)
                {
                    double result = 1 / (x - N);
                    Console.WriteLine($"При x = {x}, f(x) = {result}");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на 0.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: выход за пределы диапазона.");
            }
            finally
            {
                Console.WriteLine("Выполнение программы завершено.");
            }
        }
    }
}
