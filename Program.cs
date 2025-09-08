namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
           {
    //double a = 10;
    //double b = 3;
    //double c = a / b;
    //Console.WriteLine(c);
    //double x = 10 / 3;
    //Console.WriteLine(x);
    //int x1 = 4;
    //int y1 = ++x1;
    //Console.WriteLine($"x1 - {x1}, y1 - {y1}");

    //int x2 = 4;
    //int y2 = x2++;
    //Console.WriteLine($"x1 - {x2}, y1 - {y2}");

    //int x = 1;
    //Console.WriteLine(x++ + ++x);

    //int x = 1;
    //Console.WriteLine(10 / 5 + 2 );

    //bool x1 = (5 > 6) || (4 < 7);
    //bool x1 = (5 > 6) && (4 < 7);

    //double number = 4.31321312;
    //Console.WriteLine($"{number:F1}");

    /*int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0)
    {
        Console.WriteLine("+");
    }
    else
    {
        Console.WriteLine("-");
    }*/


    /*int x = 3;
    int y = 4;
    int z = (x > y) ? (x + y) : (y - x); */

    /*Console.WriteLine("Введите вашу игру: ");
    string a = Console.ReadLine();
    switch (a)
    {
        case "Дота2":
            Console.WriteLine("ваша игра Дота2");
            break;
        case "Валорант":
            Console.WriteLine("Ваша игра Валорант");
            break;
        case "Майнкрафт":
            Console.WriteLine("Ваша игра майнкрафт");
            break;
        default:
            Console.WriteLine("Игра не найдена");
            break;  
    } */

    /*   ЗАДАЧИ #1
            Console.Write("Введите число: ");
            int namder = Convert.ToInt32(Console.ReadLine());

            if (namder % 2 == 0)
            {
                Console.WriteLine($"Число {namder} четное");
            }
            else
            {
                Console.WriteLine($"Число {namder} нечетное");
            } */


    /*   #2
    Console.Write("Введите пароль: ");
    string a = Console.ReadLine();

    Console.Write("Подтвердите пароль: ");
    string b = Console.ReadLine();

    if (a == b)
    {
        Console.WriteLine("Пароль принят");
    }
    else
    {
        Console.WriteLine("Пароль не принят");
    } */

    /*    #3
    Console.Write("Введите четырехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int a = number / 1000;
    int b = (number / 100) % 10;
    int c = (number / 10) % 10;
    int d = number % 10;

    if (a + d == b + c) 
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    } */

    /*    #4
    Console.Write("Введите ваш возраст: ");
    int namder = Convert.ToInt32(Console.ReadLine());

    if (namder >= 18)
    {
        Console.WriteLine("Доступ разрешен");
    }
    else
    {
        Console.WriteLine("Доступ запрещен");
    }
} */

    /*    #5
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a < b)
    {
        Console.WriteLine($"Наименьшее число: {a}");
    }
    else
    {
        Console.WriteLine($"Наименьшее число: {b}");
    }
    */

    /*    #6
    string a = Console.ReadLine();
    int a1 = Convert.ToInt32(a);

    Console.Write("Введите целое число: ");
    string b = Console.ReadLine();
    int b1 = Convert.ToInt32(b);

    Console.Write("Введите операцию (+, -, *, /): ");
    string c = Console.ReadLine();

    if (c == "+")
    {
        Console.WriteLine($"{a1} + {b1} = {a1 + b1}");
    }
    else if (c == "-")
    {
        Console.WriteLine($"{a1} - {b1} = {a1 - b1}");
    }
    else if (c == "*")
    {
        Console.WriteLine($"{a1} * {b1} = {a1 * b1}");
    }
    else if (c == "/")
    {
        if (b1 != 0)
        {
            Console.WriteLine($"{a1} / {b1} = {a1 / b1}");
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль!");
        }
    } */

    /*    #7
    int a = Convert.ToInt32(Console.ReadLine());

    switch (a)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;

        case 2:
            Console.WriteLine("Вторник");
            break;

        case 3:
            Console.WriteLine("Среда");
            break;

        case 4:
            Console.WriteLine("Четверг");
            break;

        case 5:
            Console.WriteLine("Пятница");
            break;

        case 6:
            Console.WriteLine("Суббота");
            break;

        case 7:
            Console.WriteLine("Воскресенье");
            break;
    }  */

    /*    #8
    Console.Write("Введите целое число: ");
    string a = Console.ReadLine();
    int a1 = Convert.ToInt32(a);

    Console.Write("Введите целое число: ");
    string b = Console.ReadLine();
    int b1 = Convert.ToInt32(b);

    Console.Write("Введите операцию (+, -, *, /): ");
    string c = Console.ReadLine(); 

    switch (c)
    {
        case "+":
            Console.WriteLine($"{a1} + {b1} = {a1 + b1}");
            break;

        case "-":
            Console.WriteLine($"{a1} - {b1} = {a1 - b1}");
            break;

        case "*":
            Console.WriteLine($"{a1} * {b1} = {a1 * b1}");
            break;

        case "/":
            if (b1 != 0)
            {
                Console.WriteLine($"{a1} / {b1} = {a1 / b1}");
            }
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            break;
    } */

    /*    #9
    Console.WriteLine("1 - Легкий уровень");
    Console.WriteLine("2 - Средний уровень");
    Console.WriteLine("3 - Сложный уровень");
    Console.Write("Выберите уровень сложности (1-3): ");

    int level = Convert.ToInt32(Console.ReadLine());

    switch (level)
    {
        case 1:
            Console.WriteLine("Вы выбрали: Легкий уровень");
            Console.WriteLine("Описание: Подходит для новичков. Меньше врагов, больше здоровья.");
            break;

        case 2:
            Console.WriteLine("Вы выбрали: Средний уровень");
            Console.WriteLine("Описание: Баланс между сложностью и проходимостью. Рекомендуется для опытных игроков.");
            break;

        case 3:
            Console.WriteLine("Вы выбрали: Сложный уровень");
            Console.WriteLine("Описание: Только для экспертов. Много врагов, ограниченное здоровье, высокая сложность.");
            break;
    } */
            } 
        }
    }
//     #10
//namespace Program1 // - названи пространства
//{
//    internal class Program // класс программы
//    {
//        static int health = 100; // - здоровье нашего персонажа
//        static void Main(string[] args) // - Само пространство для кода
//        {
//            Console.WriteLine($"Здоровье персонажа: {health}"); // - Вывод здоровья перса
//            TakeDamage(30);// - нанесённый урон персонажу
//        }
//        static void TakeDamage(int damage)// - пространство для нанесения урона персонажу
//        {
//        health -= damage; // - здоровье - урон по персонажу
//        Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}."); // вывод сколько хп у персонажа
//        }
//    }
//}

