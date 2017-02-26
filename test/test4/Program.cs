using System;
/* Boris Z
 * Написать программу обмена значениями двух переменных
 *   а) с использованием третьей переменной;
 *   б) *без использования третьей переменной.
 *   */  

namespace test4
{
    class Program
    {
        //use method for show answer
        static void Print(double a, double b)
        {
            Console.WriteLine("Первая переменная = {0} Вторая переменная = {1}", a, b);
        }
        //use rule of incapsulasion
        static void Do(double a,double b)
        {
            do
            {
                //record variable for choose options(записываем ответ пользователя для выбора способа)
                int UserChoose = int.Parse(Console.ReadLine());
                //option first
                if (UserChoose == 1)
                {
                    //use third variable for change value(используем третию переменную для перезаписи)
                    double c = a; a = b; b = c;
                    Print(a, b);
                    //exit cycle(выходим из цикла)
                    break;
                }
                //second option
                if (UserChoose == 2)
                {
                    // sum for save value(складываем значения в одну переменную)
                    a = a + b;
                    // get value a in variable b (получаем из суммы значение a в b) 
                    b = a - b;
                    // get value b in variable a (получаем из суммы значение b в a)
                    a = a - b;
                    Print(a, b);
                    //exit cycle(выходим из цикла)
                    break;
                }
                //option third
                if (UserChoose == 3)
                {
                    // convert to int beacuse this only for int value
                    // (конвертируем в инт потому что этот метод только для целочисленных)
                    int a1 = Convert.ToInt32(a); int b1 = Convert.ToInt32(b);

                    a1 ^= b1; // a1 = a1 ^ b1;
                    b1 ^= a1; // b1 = b1 ^ a1;
                    a1 ^= b1; // a1 = a1 ^ b1;
                    Print(a1, b1);

                    //exit cycle(выходим из цикла)
                    break;
                }
                else Console.Write("Необходимо ввести число: 1, 2 или 3");

            } while (true);
        }
        static void Main()
        {
            //Hello
            Console.WriteLine("Привет! Эта программа меняет значения двух переменных");
            //records variables(записываем переменные)
            Console.Write("Введите первую переменную: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую переменную: "); double b = double.Parse(Console.ReadLine());
            //choose how we will change value of variables(выбор способа замены значений)
            Console.WriteLine("Как хотите, чтобы мы поменяли переменные:");
            Console.WriteLine("\t1.С использованием третьей переменной.\t"
                + "2.Без третьей переменной\t3.Без третьей переменной логически");
            Console.Write("Для выбора введите соответствующую методу цифру: ");
            //use cycle for right answer(используем цикл для реализации правильного ответа)            
            Do(a,b);
            Console.ReadLine();
        }
    }
}
