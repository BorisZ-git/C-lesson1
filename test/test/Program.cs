using System;
// Boris Z
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
            //records variable(запись переменных)
            Console.WriteLine("Добрый день! Введите ваши ФИО");
            var name = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            var age = Console.ReadLine();
            Console.WriteLine("Ваш рост?");
            var height = Console.ReadLine();
            Console.WriteLine("Ваш вес?");
            var weight = Console.ReadLine();
            //show
            Console.WriteLine("Вывод переменных склеиванием:");
            //with glue, use \n for free space
            Console.WriteLine(name + " Вам " + age + " и Ваш рост "
                + height + " а вес равен " + weight + "\n");

            Console.WriteLine("Форматированный вывод переменных:");
            //Convert for formating write   
            double a = Convert.ToDouble(age);
            double h = Convert.ToDouble(height);
            //Convert in WriteLine
            Console.WriteLine("{0} Вам {1} Ваш вес {2:f1} а рост {3}",
                name, (int)a, Convert.ToDouble(weight), (int)h);

            // don't give programm close
            Console.ReadLine(); 
        }
    }
}
