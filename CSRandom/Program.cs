using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CSRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, lowes, highes;
            int triesCount = 5;
            int numberUser;
            Random rand = new Random();
            Console.WriteLine("!!! Угадайте  число !!!");
            Enter:
            Console.Write("Введите нижнее число диапазона: ");
            lowes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите верхнее число диапазона: ");
            highes = Convert.ToInt32(Console.ReadLine());
            if(lowes >= highes)
            {
                Console.Clear();
                Console.WriteLine("!!! Угадайте  число !!!\nВведен неправильный диапазон. Попробуйте еще раз.");
                goto Enter;
            }
            number = rand.Next(lowes, highes);
            Console.WriteLine($"У вас всего {triesCount} попыток" + "\nИгра началась.");
            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("\nВаше число: ");
                numberUser = Convert.ToInt32(Console.ReadLine());
                if (numberUser == number)
                {
                    Console.WriteLine("Вы угадали число! Поздравляем!\nИгра закончена!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Вы не угадали. ");
                    if (i < triesCount - 1)
                    {
                        Console.Write("Попробуйте еще раз! У вас осталось попыток: " + (triesCount - i - 1));
                    }
                    else
                    {
                        Console.WriteLine("Попыток не осталось.\nИгра закончена! ");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
