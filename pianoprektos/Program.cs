using System.Globalization;
using System.Text;

namespace pianoprektos
{
    internal class Program
    {
        private const int Vremya = 200;

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Переключение между октавами 1,5,6,7 \n 0 - выход");
                int Octavaemae = Convert.ToInt32(Console.ReadLine());
                if (Octavaemae == 0)
                {
                    Console.WriteLine("\n Пока! Думаю, еще сыграем!");
                    break;
                }
                if (Octavaemae == 1)
                {
                    Console.WriteLine("1 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] firstOctava = new int[] { 327, 346, 388, 367, 412, 436, 462, 490, 519, 550, 582, 617 };
                    octava1(firstOctava);
                }
                if (Octavaemae == 5)
                {
                    Console.WriteLine("\n5 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] fiveOctava = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                    octava1(fiveOctava);
                }
                else if (Octavaemae == 6)
                {
                    Console.WriteLine("\n6 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] sixOctava = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                    octava1(sixOctava);
                }
                else if (Octavaemae == 7)
                {
                    Console.WriteLine("\n7 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] sevenOctava = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                    octava1(sevenOctava);
                }
            }
        }
        static void octava1(int[] notki)
        {
            while (true)
            {
                ConsoleKeyInfo piano = Console.ReadKey();

                if (piano.Key == ConsoleKey.Q)
                {
                    Console.Beep(notki[0], Vremya);
                }
                else if (piano.Key == ConsoleKey.W)
                {
                    Console.Beep(notki[1], Vremya);
                }
                else if (piano.Key == ConsoleKey.E)
                {
                    Console.Beep(notki[2], Vremya);
                }
                else if (piano.Key == ConsoleKey.R)
                {
                    Console.Beep(notki[3], Vremya);
                }
                else if (piano.Key == ConsoleKey.T)
                {
                    Console.Beep(notki[4], Vremya);
                }
                else if (piano.Key == ConsoleKey.Y)
                {
                    Console.Beep(notki[5], Vremya);
                }
                else if (piano.Key == ConsoleKey.U)
                {
                    Console.Beep(notki[6], Vremya);
                }
                else if (piano.Key == ConsoleKey.I)
                {
                    Console.Beep(notki[7], Vremya);
                }
                else if (piano.Key == ConsoleKey.O)
                {
                    Console.Beep(notki[8], Vremya);
                }
                else if (piano.Key == ConsoleKey.P)
                {
                    Console.Beep(notki[9], Vremya);
                }
                else if (piano.Key == ConsoleKey.A)
                {
                    Console.Beep(notki[10], Vremya);
                }
                else if (piano.Key == ConsoleKey.S)
                {
                    Console.Beep(notki[11], Vremya);
                }
                else if (piano.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\n1 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] firstOctava = new int[] { 327, 346, 388, 367, 412, 436, 462, 490, 519, 550, 582, 617 };
                    octava1(firstOctava);
                }
                else if (piano.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("\n5 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] fiveOctava = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                    octava1(fiveOctava);
                }
                else if (piano.Key == ConsoleKey.D6)
                {
                    Console.WriteLine("\n6 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] sixOctava = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                    octava1(sixOctava);
                }
                else if (piano.Key == ConsoleKey.D7)
                {
                    Console.WriteLine("\n7 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                    int[] sevenOctava = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                    octava1(sevenOctava);
                }
                else if (piano.Key == ConsoleKey.D0)
                {
                    break;
                }
            }

        }
    }
}