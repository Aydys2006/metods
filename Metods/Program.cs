namespace Metods
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Здравствуйте!!!");
            bool done = false;
            while (!done)
            {
                Console.WriteLine("1) Игра: Угадай число.");
                Console.WriteLine("2) Таблица умножения.");
                Console.WriteLine("3) Все делители числа.");
                Console.WriteLine("4) Выход.");
                Console.Write("Введите комманду: ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Random();
                        break;
                    case 2:
                        tab();
                        break;
                    case 3:
                        del();
                        break;
                    case 4:
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Выбрана комманда которой нет.");
                        break;

                }
            }
        }

        static void Random()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("В этой игре вам надо найти рандомное число которое загадывает копьюер.");
            Console.WriteLine("Игра началась!!!");
            Random a = new Random();
            int b = a.Next(1, 100);
            bool done = false;
            while (!done)
            {
                Console.Write("Введите число: ");
                int c = int.Parse(Console.ReadLine());
                if (b < c)
                {
                    Console.WriteLine("Надо меньше.");
                }
                else if (b > c)
                {
                    Console.WriteLine("Надо больше.");
                }
                else
                {
                    Console.WriteLine("Правильно!!!!");
                    done = true;
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }

        static void tab()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            int[,] arr = new int[10, 10];
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.Write("x/y |\t");
            for (int i = 0; i < arr1.Length; ++i)
            {
                Console.Write(arr1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("---------------------------------------------------------------------");
            Console.WriteLine();

            for (int i = 1; i < arr.GetLength(0); ++i)
            {
                for (int j = 1; j < arr.GetLength(1); ++j)
                {

                    int sum = i * j;
                    if (i == j)
                    {
                        arr[i, j] = sum;
                        Console.Write(arr[i, j] + "\t");
                    }
                    else if (i > j)
                    {
                        arr[i, j] = sum;
                        Console.Write(arr[i, j] + "\t");
                    }
                    else if (i < j)
                    {
                        arr[i, j] = sum;
                        Console.Write(arr[i, j] + "\t");
                    }

                }
                Console.WriteLine("\n\n");
            }


            
            Console.WriteLine("---------------------------------------------------------------------");

        }

        static void del()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Введите число: ");
            int ivan = int.Parse(Console.ReadLine());
            for (int aidys = 1; aidys <= ivan; aidys++)
            {
                if (ivan % aidys == 0) Console.WriteLine("{0} ", aidys);
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}