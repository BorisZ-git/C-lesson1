using System;
//Boris Zn
/*
 * Ввести вес и рост человека.
 *  Расчитать и вывести индекс массы тела(ИМТ) по формуле  I=m/(h*h);
 *   где m ­масса тела в килограммах, h ­ рост в метрах
 *     *Интерпритировать показания ИМТ​.
 */
namespace test2
{
    class Program
    {
        static void Main()
        {
            //records variables(записываем переменные)
            Console.WriteLine("Добрый день! Программа поможет Вам вывести вашу ИМТ");
            Console.WriteLine("Введите ваш рост в см");
            string height = Console.ReadLine();
            Console.WriteLine("Ваш вес в килограммах");
            string weight = Console.ReadLine();
            // set cm to m(приводим см к метрам)
            // m = 100 cm 
            double h = (Convert.ToInt32(height)) / 100;

        }
    }
}
