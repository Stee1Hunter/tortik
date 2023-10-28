using System;

tortik();
static void tortik()
{
    ConsoleKeyInfo key;
    int pos;
    pos = 1;
    int pos2;
    pos2 = 1;
    int a;
    a = 0;
    int b;
    b = 0;
    int c;
    c = 0;
    int d;
    d = 0;
    int f;
    f = 0;
    int g;
    g = 0;
    while (true)
    {
          key = Console.ReadKey();
        
        if (key.Key == ConsoleKey.UpArrow)
        {
            pos--;
            if (pos <= 0)
            {
                pos = 7;
            }
        }
        if (key.Key == ConsoleKey.DownArrow)
        {
            pos++;
            if (pos > 7)
            {
                pos = 1;
            }

        }
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Выберите пункт: ");
        Console.SetCursorPosition(0, pos);
        Console.WriteLine("->");
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("1. форма");
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("2. размер");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("3. вкус");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("4. количество коржей");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("5. глазурь");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("6. декор");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("7. купить и выйти");
        if (key.Key == ConsoleKey.Enter && pos == 1)
        {
            while (true)
            {
                ConsoleKeyInfo key2 = Console.ReadKey(); 
                if (key2.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    if (pos2 <= 0)
                    {
                        pos2 = 3;
                    }
                }
                if (key2.Key == ConsoleKey.DownArrow)
                {
                    pos2++;
                    if (pos2 > 3)
                    {
                        pos2 = 1;
                    }

                }
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите пункт: ");
                Console.SetCursorPosition(0, pos2);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. квадрат 500 рублей");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. круг 700 рублей");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("3. элипс 900 рублей");
                Console.WriteLine("Нажмите 2 раза на Escape, чтобы выйти в основное меню");
                if (key2.Key == ConsoleKey.Enter && pos2 == 1)
                {
                    a = 500;
                   
                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 2)
                {
                    a = 700;
                    
                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 3)
                {
                    a = 900;
                    
                }
                if (key2.Key == ConsoleKey.Escape)
                {
                    break;

                }
            }

        }
        if (key.Key == ConsoleKey.Enter && pos == 2)
        {
            
            while (true)
            {
                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    if (pos2 <= 0)
                    {
                        pos2 = 3;
                    }
                }
                if (key2.Key == ConsoleKey.DownArrow)
                {
                    pos2++;
                    if (pos2 > 3)
                    {
                        pos2 = 1;
                    }

                }
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите пункт: ");
                Console.SetCursorPosition(0, pos2);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. S 200 рублей");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. M 300 рублей");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("3. L 500 рублей");
                Console.WriteLine("Нажмите 2 раза на Escape, чтобы выйти в основное меню");
                if (key2.Key == ConsoleKey.Enter && pos2 == 1)
                {
                    b = 200;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 2)
                {
                    b = 300;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 3)
                {
                    b = 500;

                }
                if (key2.Key == ConsoleKey.Escape)
                {
                    break;

                }
            }

            
        }
        if (key.Key == ConsoleKey.Enter && pos == 3)
        {
            while (true)
            {
                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    if (pos2 <= 0)
                    {
                        pos2 = 3;
                    }
                }
                if (key2.Key == ConsoleKey.DownArrow)
                {
                    pos2++;
                    if (pos2 > 3)
                    {
                        pos2 = 1;
                    }

                }
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите пункт: ");
                Console.SetCursorPosition(0, pos2);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. клубничный 400 рублей");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. карамельный 400 рублей");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("3. шоколадный 350 рублей");
                Console.WriteLine("Нажмите 2 раза на Escape, чтобы выйти в основное меню");
                if (key2.Key == ConsoleKey.Enter && pos2 == 1)
                {
                    c = 400;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 2)
                {
                    c = 400;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 3)
                {
                    c = 350;

                }
                if (key2.Key == ConsoleKey.Escape)
                {
                    break;

                }
            }
        }
        if (key.Key == ConsoleKey.Enter && pos == 4)
        {
            while (true)
            {
                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    if (pos2 <= 0)
                    {
                        pos2 = 3;
                    }
                }
                if (key2.Key == ConsoleKey.DownArrow)
                {
                    pos2++;
                    if (pos2 > 3)
                    {
                        pos2 = 1;
                    }

                }
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите пункт: ");
                Console.SetCursorPosition(0, pos2);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. 1 корж 200 рублей");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. 2 коржа 300 рублей");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("3. 3 коржа 500 рублей");
                Console.WriteLine("Нажмите 2 раза на Escape, чтобы выйти в основное меню");
                if (key2.Key == ConsoleKey.Enter && pos2 == 1)
                {
                    d = 200;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 2)
                {
                    d = 300;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 3)
                {
                    d = 500;

                }
                if (key2.Key == ConsoleKey.Escape)
                {
                    break;

                }
            }
        }
        if (key.Key == ConsoleKey.Enter && pos == 5)
        {
            while (true)
            {
                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    if (pos2 <= 0)
                    {
                        pos2 = 3;
                    }
                }
                if (key2.Key == ConsoleKey.DownArrow)
                {
                    pos2++;
                    if (pos2 > 3)
                    {
                        pos2 = 1;
                    }

                }
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите пункт: ");
                Console.SetCursorPosition(0, pos2);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. крем 300 рублей");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. творожный сыр 400 рублей");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("3. заварной крем 450 рублей");
                Console.WriteLine("Нажмите 2 раза на Escape, чтобы выйти в основное меню");
                if (key2.Key == ConsoleKey.Enter && pos2 == 1)
                {
                    f = 300;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 2)
                {
                    f = 400;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 3)
                {
                    f = 450;

                }
                if (key2.Key == ConsoleKey.Escape)
                {
                    break;

                }
            }
        }
        if (key.Key == ConsoleKey.Enter && pos == 6)
        {
            while (true)
            {
                ConsoleKeyInfo key2 = Console.ReadKey();
                if (key2.Key == ConsoleKey.UpArrow)
                {
                    pos2--;
                    if (pos2 <= 0)
                    {
                        pos2 = 3;
                    }
                }
                if (key2.Key == ConsoleKey.DownArrow)
                {
                    pos2++;
                    if (pos2 > 3)
                    {
                        pos2 = 1;
                    }

                }
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Выберите пункт: ");
                Console.SetCursorPosition(0, pos2);
                Console.WriteLine("->");
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("1. ягоды 200 рублей");
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("2. мастика 400 рублей");
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("3. шоколадная фигура 600 рублей");
                Console.WriteLine("Нажмите 2 раза на Escape, чтобы выйти в основное меню") ;
                if (key2.Key == ConsoleKey.Enter && pos2 == 1)
                {
                    g = 200;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 2)
                {
                    g = 400;

                }
                if (key2.Key == ConsoleKey.Enter && pos2 == 3)
                {
                    g = 600;

                }
                if (key2.Key == ConsoleKey.Escape)
                {
                    break;

                }
            }
        }
        if (key.Key == ConsoleKey.Enter && pos == 7)
        {
            Console.WriteLine("Вы заплатите:");
            Console.WriteLine(a+b+c+d+f+g);
            break;
        }    
    }
    
}
