Console.WriteLine("Введите значение: ");
var someproperty = Console.ReadLine();
if (string.IsNullOrEmpty(someproperty) ||
    string.IsNullOrWhiteSpace(someproperty))
{
    Console.WriteLine("Неверное значение");
    Environment.Exit(1);
}

if (int.TryParse(someproperty, out int x))
{
    Console.WriteLine("int x ={0}", x);
}
else
{
    Console.WriteLine($"Для приведения числа {someproperty} к типу int число не может быть больше {int.MaxValue} и меньше{int.MinValue}");
}

if (long.TryParse(someproperty, out long y))
{
    Console.WriteLine("long y={0}", y);
}
else
{
    Console.WriteLine($"Для приведение числа {someproperty} к типу long число не может быть больше {long.MaxValue} и меньше  {long.MinValue}" );
}

if (sbyte.TryParse(someproperty, out sbyte z))
{
    Console.WriteLine("sbyte z={0}", z);
}
else
{
    Console.WriteLine($"Для приведение числа {someproperty} к типу sbyte число не может быть больше {sbyte.MaxValue} и меньше  {sbyte.MinValue}");
}

if (short.TryParse(someproperty, out short a))
{
    Console.WriteLine("short a={0}", a);
}
else
{
    Console.WriteLine($"Для приведение числа {someproperty} к типу short число не может быть больше {short.MaxValue} и меньше  {short.MinValue}");
}
if (byte.TryParse(someproperty, out byte b))
{
    Console.WriteLine("byte b={0}", b);
}
else
{
    Console.WriteLine($"Для приведение числа {someproperty} к типу byte число не может быть больше {byte.MaxValue} и меньше  {byte.MinValue}");
}
if (ushort.TryParse(someproperty, out ushort c))
{
    Console.WriteLine("ushort c={0}", c);
}
else
{
    Console.WriteLine($"Для приведение числа {someproperty} к типу ushort число не может быть больше {ushort.MaxValue} и меньше  {ushort.MinValue}");
}
if (uint.TryParse(someproperty, out uint d))
{
    Console.WriteLine("uint d={0}", d);
}
else
{
    Console.WriteLine($"Для приведение числа {someproperty} к типу uint число не может быть больше {uint.MaxValue} и меньше  {uint.MinValue}");
}
if (ulong.TryParse(someproperty, out ulong e))
{
    Console.WriteLine("ulong e={0}", e);
}
else
{
    Console.WriteLine($"Для приведение числа {someproperty} к типу ulong число не может быть больше {ulong.MaxValue} и меньше  {ulong.MinValue}");
}


    
    
