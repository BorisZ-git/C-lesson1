using System;
// Boris Zn
/*
 *  Написать программу “Анкета”.
 *   Последовательно задаются вопросы (имя, фамилия, возраст,  рост, вес). 
 *   В результате вся информация выводится в одну строчку. 
    а) используя  склеивание;  б) используя форматированный вывод
 */

namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добрый день! Введите ваши ФИО");
            var name = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            var age = Console.ReadLine();
            Console.WriteLine("Ваш вес?");
            var weight = Console.ReadLine();
            Console.WriteLine(name + " Вам " + age + " и Ваш вес равен " + weight);

            Console.ReadLine(); // don't give programm close
        }
    }
}
