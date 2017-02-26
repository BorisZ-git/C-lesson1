using System;
/* Boris Z
 *  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 *  б) *Сделайте задание, только вывод организуйте в центре экрана 
 *  в) **Сделайте задание  б с использованием собственных методов 
 *  (например, Print(string ms, int  x,int y) 
 *  */ 

namespace test5
{
    class Program
    {
        //create method(создаем метод принимая нужные для реализации элементы)
        static void Print(string Name, string SecondName, string City, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Приятно познакомиться {0}!Ваша фамилия {1},Вы проживаете в городе {2}"
    , Name, SecondName, City);
        }
        static void Main()
        {
            //Hello
            Console.WriteLine("Добро пожаловать! Эта программа выведит на экран введенные данные");
            //record name(записываем переменную имя)
            Console.Write("Ваше имя: "); string Name = Console.ReadLine();
            //record second name(записываем фамилию)
            Console.Write("Ваша фамилия: "); string SecondName = Console.ReadLine();
            //record city(записываем город)
            Console.Write("Город в котором проживаете: "); string City = Console.ReadLine();
            //show on screen(просто выводим)
            Console.WriteLine("Приятно познакомиться {0}!Ваша фамилия {1},Вы проживаете в городе {2}"
                , Name, SecondName, City);            
            //set cursor to centre(задаем позицию на экране)
            Console.SetCursorPosition(25, 7);
            //show on cursor position(пишет на заданной позиции)
            Console.WriteLine("Приятно познакомиться {0}!Ваша фамилия {1},Вы проживаете в городе {2}"
    , Name, SecondName, City);
            //use method(используем написанный метод передавая ему данные)
            Print(Name,SecondName,City, 25, 17);
            //don't give window close
            Console.ReadKey();            
        }
    }
}
