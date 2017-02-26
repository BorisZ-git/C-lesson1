using System;
/* Boris Z
 * Создайте класс с методами, которые могут пригодиться в вашей учебе(Print, Pause). 
*/
namespace test6
{

    class Program
    {
        static void Main()
        {
            //C этими логическими операторами вообще ни чего не понятно.
            // ^ | & !
            // как они вообще числа могут сравнивать и получать какой-то результат. =)))
            int a = 123;
            int b = 876;
            a ^= b;
            Print(a.ToString());
            b ^= a;
            Print(b.ToString());
            a ^= b;
            Print(a.ToString());

            Pause();
        }
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Pause()
        {
            Console.WriteLine("Нажмите любую клавишу для закрытия окна");
            Console.ReadLine();
        }

    }
}
