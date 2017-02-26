using System;

/*Boris Z
 * а) Написать программу,
 *  которая подсчитывает расстояние между точками
 *   с координатами x1, y1  и x2,y2 
 *   по формуле r=Math.Sqrt(Math.Pow(x2­x1,2)+Math.Pow(y2­y1,2).
 *    Вывести результат  используя спецификатор формата .2f (с двумя знаками после запятой);   
б) *Выполните предыдущее задание оформив вычисления расстояния между точками в виде  метода;
*/
namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello
            Console.WriteLine("Привет!Это программа поможет высчитать растояние между двумя точками.");
            //records variables(записываем переменные)
            Console.WriteLine("Введите координаты для первой точки");
            Console.Write("Для оси x: "); double x1 = double.Parse(Console.ReadLine());
            Console.Write("Для оси y: "); double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты для второй точки");
            Console.Write("Для оси x: ");  double x2 = double.Parse(Console.ReadLine());
            Console.Write("Для оси y: "); double y2 = double.Parse(Console.ReadLine());
            //count and show (высчитываем и сразу выводим)
            Console.WriteLine("Расстояние между двумя точками {0:f2} чего-то там\n" 
                , Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))); //use \n for free space
            //realize count use method (реализуем подсчет с помощью метода)
            Console.WriteLine("Сейчас мы сделаем теже рассчеты,"
                + "только в программе это будет реализованно с помощью метода");
            Console.WriteLine("{0:f2}", Count(x1, x2, y1, y2));
            //don't give window close before we see result(до нажатия клавиши висит окно)
            Console.ReadKey();
        }
        //realize method (реализуем метод)
        static public double Count(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
