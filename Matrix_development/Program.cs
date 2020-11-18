using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_development
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] array = { { 1, 2, 3 }, { 3, 4, 5 } };
            Matrix a = new Matrix(array);
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                }
            }
        }
    }
}
