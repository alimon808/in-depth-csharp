using System;
using System.Collections.Generic;

namespace CSharp.Collections
{
    public class BasicMultiDimensionalArray
    {
        public float[,] Temperature2D()
        {
            float[,] tempGrid = new float[4, 3];
            for (int x = tempGrid.GetLowerBound(0); x <= tempGrid.GetUpperBound(0); x++)
            {
                for (int y = tempGrid.GetLowerBound(1); y <= tempGrid.GetUpperBound(1); y++)
                {
                    tempGrid[x, y] = x + 10 * y;
                }
            }

            return tempGrid;
        }

        public float[][] TemperatureJagged()
        {
            float[][] tempGrid = new float[4][];
            for (int x = 0; x < 4; x++)
            {
                tempGrid[x] = new float[3];
                for (int y = 0; y < 3; y++)
                {
                    tempGrid[x][y] = x + 10 * y;
                }
            }

            return tempGrid;
        }
    }
}
