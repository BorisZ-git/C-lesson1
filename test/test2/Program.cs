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
            //Hello
            Console.WriteLine("Привет! Эта программа поможет тебе высчитать твой ИМТ");
            //records variables(запись переменнных)
            Console.Write("Введите рост в см: ");
            //1m = 100cm
            double h = double.Parse(Console.ReadLine())/100;
            Console.Write("Введите ваш в вес в килограммах: ");
            double m = double.Parse(Console.ReadLine());
            //count
            double i = m / (h * h);
            //show IMT
            Console.WriteLine("Ваш ИМТ равен: {0:f1}", i);
            //don't give the window close before the see result
            Console.ReadLine();

        }
    }
}
