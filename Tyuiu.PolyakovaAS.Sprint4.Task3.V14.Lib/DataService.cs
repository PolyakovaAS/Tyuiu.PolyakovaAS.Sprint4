using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PolyakovaAS.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int maxInFourthRow = array[3, 0];

            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[3, j] > maxInFourthRow)
                {
                    maxInFourthRow = array[3, j];
                }
            }
            return maxInFourthRow;
        }
    }
}
