using Tyuiu.PolyakovaAS.Sprint4.Task1.V1.Lib;

DataService ds = new DataService();
Console.WriteLine("Введите количество элементов в массиве:");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
for (int i = 0; i < lenght; i++)
{
    Console.WriteLine($"Введите значение элемента массива под номером {i + 1}:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Получившийся массив:");
foreach (int element in array)
{
    Console.WriteLine(element);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine($"Сумма чётных элементов массива: {ds.Calculate(array)}");
Console.ReadKey();