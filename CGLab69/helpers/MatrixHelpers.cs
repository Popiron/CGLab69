using System;
using System.Collections.Generic;
using System.Text;

namespace CGLab69.helpers
{
    class MatrixHelpers
    {
        static public double[,] multiply(double[,] x, double[,] y)
        {
            int rowsX = x.GetLength(0);
            int rowsY = y.GetLength(0);

            int colsX = x.GetLength(1);
            int colsY = y.GetLength(1);
            
            if (colsX != rowsY)
            {
                throw new ArgumentException();
            }
            
            double t;
            double[,] res = new double[rowsX, colsY];

            for (int i = 0; i < rowsX; i++)
            {
                for (int j = 0; j < colsY; j++)
                {
                    t = 0;
                    for (int k = 0; k < colsX; k++)
                    {
                        t += x[i, k] * y[k, j];
                    }
                    res[i, j] = t;
                }
            }
            return res;
            
        }
    }
}
