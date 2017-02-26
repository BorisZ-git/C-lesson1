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

        }
        public void Print (string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
    }
}
