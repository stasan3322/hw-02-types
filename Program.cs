Console.WriteLine("Введите номер месяца");
string value = Console.ReadLine();
int.TryParse(value, out int x);
if(x!=0)
{
    switch (x) 
    {
        case 1:
            Console.WriteLine("Январь 31 день");
            break;
        case 2:
            Console.WriteLine("Ферваль 28 дней");
            break;
        case 3:
            Console.WriteLine("Март 31 день");
            break;
        case 4:
            Console.WriteLine("Апрель 30 дней");
            break;
        case 5:
            Console.WriteLine("Май 31 день");
            break;
        case 6:
            Console.WriteLine("Июнь 30 дней");
            break;
        case 7:
            Console.WriteLine("Июль 31 день");
            break;
        case 8:
            Console.WriteLine("Август 31 дней");
            break;
        case 9:
            Console.WriteLine("Сентябрь 30 дней");
            break;
        case 10:
            Console.WriteLine("Октябрь 31 день");
            break;
        case 11:
            Console.WriteLine("Ноябрь 30 дней");
            break;
        case 12:
            Console.WriteLine("Декабрь 31 дней");
            break;
    }
    if (x == 12 || x >= 1 && x <= 2)
    {
        Console.WriteLine("Сезон года-зима");
    }
    else if (x >= 3 && x <= 5)
    {
        Console.WriteLine("Сезон года-весна");
    }
    else if (x >= 6 && x <= 8) 
    {
        Console.WriteLine("Сезон года-лето");
    }
    else if (x >= 9 && x <= 11)
    {
        Console.WriteLine("Сезон года-осень");
    }
    else
    {
        Console.WriteLine("Некорректные данные");
    }
}

