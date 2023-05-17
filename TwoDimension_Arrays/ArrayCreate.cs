using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimension_Arrays
{
    internal class ArrayCreate
    {
        protected int rows, columns;
        internal int posCellCount = 0;
        protected float posCellSum = 0;
        internal float posCellMean = 0;
        internal int[,] arrayOut;
        protected int R
        {
            get { return rows; }
            set { rows = value; }
        }
        protected int C
        {
            get { return columns; }
            set { columns = value; }
        }
        public ArrayCreate (int rows,
                            int columns)
        {
            this.rows = R;
            this.columns = C;
            arrayOut = ArrayFill(rows, columns);
            CountPositiveCells(arrayOut, rows, columns,
                ref posCellCount, ref posCellSum);
            if (posCellCount == 0)
            {
                posCellMean = 0;
            }
            else
            {
                posCellMean = posCellSum / posCellCount;
            }
            
        }
        public static int[,] ArrayFill(int rows, int columns)
        {
            int[,] array = new int[rows, columns];
            Random randomizer = new();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = randomizer.Next(-50, 50);
                }
            }
            return array;
        }
        public static void CountPositiveCells(int[,] arrayOut, int rows,
            int columns, ref int posCellCount,ref float posCellSum)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arrayOut[i,j] > 0)
                    {
                        posCellSum += arrayOut[i,j];
                        posCellCount += 1;
                    }
                }
            }
        }

    }
}
