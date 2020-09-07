using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> sums = new Queue<int>();
            Random rand = new Random();
            int maxSums = 10;
            int score = 0;

            for (int i = 0; i < maxSums; i++)
            {
                sums.Enqueue(rand.Next(100, 1000));
            }

            while (sums.Count > 0)
            {
                score += sums.Peek();

                Console.WriteLine("У покупателя товар на сумму " + sums.Dequeue());
                Console.WriteLine($"на счету {score} денег ");
                Console.WriteLine("Для обслуживания следующего покупателя нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"вы заработали {score} денег ");
            Console.WriteLine("Рабочий день окончен. Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
