using Tyuiu.PolyakovaAS.Sprint4.Task2.V25.Lib;

Random rn = new Random();
int[] ar = new int[11];
for (int i = 0; i < ar.Length; i++)
{
    ar[i] = rn.Next(3, 9);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.Write("Массив: ");
foreach (int x in ar)
    Console.Write(x + " ");
Console.Write("\n\r");
DataService ds = new DataService();
int result = ds.Calculate(ar);
Console.WriteLine($"Произведение четных элементов массива = {result}");