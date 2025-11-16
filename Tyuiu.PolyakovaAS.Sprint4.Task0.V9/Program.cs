using Tyuiu.PolyakovaAS.Sprint4.Task0.V9.Lib;
int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

Console.Write("Массив: { ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1) Console.Write(", ");
}
Console.WriteLine(" }");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.GetSumEvenArrEl(array);

Console.WriteLine($"Сумма четных элементов массива = {result}");

Console.ReadLine();