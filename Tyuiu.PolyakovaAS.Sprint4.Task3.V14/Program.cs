

using Tyuiu.PolyakovaAS.Sprint4.Task3.V14.Lib;

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int[,] array = {
            {3, 2, 3, 3, 5},
            {2, 3, 3, 7, 3},
            {7, 5, 2, 7, 3},
            {4, 2, 7, 5, 2}, 
            {3, 5, 4, 2, 6}
        };
var result = ds.Calculate(array);
Console.WriteLine(result);
Console.ReadKey();