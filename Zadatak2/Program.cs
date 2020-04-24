using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 5;
            int numberOfColumns = 3;

            double[][] matrix = RandomMatrixGenerator.GetInstance().GenerateRandomMatrix(numberOfRows, numberOfColumns);

            for(int i = 0; i < numberOfRows; i++)
            {
                for(int j=0; j< numberOfColumns; j++)
                {
                    Console.Write(matrix[i][j].ToString()+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
