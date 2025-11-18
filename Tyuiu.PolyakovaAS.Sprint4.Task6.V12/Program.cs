using Tyuiu.PolyakovaAS.Sprint4.Task6.V12.Lib;

DataService ds = new DataService();
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

var coun = new string[] { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };

Console.WriteLine("Исходный массив:");
for (int i = 0; i <= coun.Length - 1; i++)
{
    Console.WriteLine(coun[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Слова длинна которых = 7:");

string[] res = ds.Calculate(coun);
for (int i = 0; i <= res.Length - 1; i++)
{
    Console.Write($"{res[i]} \t");
}

Console.ReadKey();