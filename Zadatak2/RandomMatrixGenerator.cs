using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class RandomMatrixGenerator
    {
        private static RandomMatrixGenerator instance;
        
        public static RandomMatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomMatrixGenerator();
            }

            return instance;
        }

        public double[][] GenerateRandomMatrix(int numOfRows, int numOfColums)
        {
            double[][] matrix = new double[numOfRows][];

            for (int i = 0; i < numOfRows; i++)
            {
                matrix[i] = new double[numOfColums];

                for(int j=0; j < numOfColums; j++)
                {
                    matrix[i][j] = RandomGenerator.GetInstance().NextDouble();
                }
            }

            return matrix;
        }

    }
}
