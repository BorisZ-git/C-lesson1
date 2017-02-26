using System;

//Boris Z
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
            Console.Write("Ваш ИМТ равен: {0:f1}", i);
            //interpretation IMT
            if (i <= 16) Console.WriteLine(" Выраженный дефицит массы тела");
            if (i <= 18 && i > 16) Console.WriteLine(" Недостаточная(дефицит) масса тела");
            if (i > 18 && i <= 25) Console.WriteLine(" Норма");
            if (i > 25 && i <= 30) Console.WriteLine(" Избыточная масса тела (предожирение)");
            if (i > 30 && i <= 35) Console.WriteLine(" Ожирение первой степени");
            if (i > 35 && i <= 40) Console.WriteLine(" Ожирение второй степени");
            if (i > 40 && i <= 45) Console.WriteLine(" Ожирение третьей степени (морбидное)");
            if (i > 45) Console.WriteLine(" Кто ты такой жир?");
            //don't give the window close before the see result
            Console.ReadLine();

        }
    }
}
