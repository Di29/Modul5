using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
           
            ReadLine();
        }

        private static void Task2()
        {
            Random rand = new Random();

            int sizeOfArray = 0;

            WriteLine("Введите размер массива: ");
            string text = ReadLine();
            bool isParsed = int.TryParse(text, out sizeOfArray);
            
            int[] mas = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                mas[i] = rand.Next(0, 50);
                Write(mas[i] + "\t");
            }

            Write("\n" + "Введите индекс массива: ");
            int index;
            while (!int.TryParse(ReadLine(), out index))
            {
                Clear();
                WriteLine("Ошибка ввода! Введите целое число: ");
            }
            try
            {
                WriteLine(mas[index]);
            }
            catch (IndexOutOfRangeException exeption)
            {
                WriteLine(exeption.Message);
            }
            finally
            {
                WriteLine("Обработка завершена !");
            }
        }

        private static void Task1()
        {
            int divident = 0;
            WriteLine("Введите делимое число: ");
            string text = ReadLine();
            bool isParsed = int.TryParse(text, out divident);

            int divisor = 0;
            WriteLine("Введите делитель: ");
            string text2 = ReadLine();
            bool isParsed2 = int.TryParse(text2, out divisor);

            try
            {
                WriteLine(Division(divident, divisor));
            }
            catch (ArgumentNullException exepction)
            {
                WriteLine(exepction.Message);
            }
            catch (ArgumentException exepction)
            {
                WriteLine(exepction.Message);
            }
        }

        private static double Division(double divident, double divisor)
        {

            if (divident == 0)
            {
                throw new ArgumentNullException();
            }
            else if (divisor == 0)
            {
                throw new ArgumentException();
            }
            WriteLine("Ответ:");
            return divident / divisor;
        }
    }
}
