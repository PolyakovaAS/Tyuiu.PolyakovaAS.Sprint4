using Tyuiu.PolyakovaAS.Sprint4.Task7.V3.Lib;

int n = 4;
int m = 2;
int[,] mtrx = new int[n, m];
string value = "27182818";
DataService ds = new DataService();

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int index = 0;

Console.WriteLine("Массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{value[index]} \t");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(n, m, value);
Console.WriteLine("Количество нечетных чисел в матрице = " + res);

Console.ReadLine();