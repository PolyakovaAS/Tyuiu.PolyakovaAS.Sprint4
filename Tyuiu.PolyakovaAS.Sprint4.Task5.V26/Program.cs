using Tyuiu.PolyakovaAS.Sprint4.Task5.V26.Lib;

DataService ds = new DataService();
Random rnd = new Random();
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
Console.WriteLine("***************************************************************************");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = rnd.Next(-4, 5);
    }
}
Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int[,] res = ds.Calculate(matrix);

Console.WriteLine("Массив, где положительные элементы заменены на 1: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{res[i, j]} \t");
    }
    Console.WriteLine();
}

Console.ReadKey();