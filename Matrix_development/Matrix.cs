using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_development
{
    public class Matrix
    {
        protected double[,] innerData;
        
        public Matrix(int size_i, int size_j)
        {
            if (size_i <= 0 || size_j <= 0) throw new Exception("Число столбцов и строк должно быть больше 0!");

            this.innerData = new double[size_i, size_j];
        }


        public double this[int i, int j]
        {

            get
            {
                checkIndex(i, j);
                return innerData[i, j];
            }

            set
            {
                checkIndex(i, j);
                innerData[i, j] = value;
            }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            int rows = a.innerData.GetLength(0);
            int columns = a.innerData.GetLength(1);

            if(!isSizeEqual(a, b)) throw new Exception("Матрицы с разной размерностью нельзя складывать");

            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            int rows = a.innerData.GetLength(0);
            int columns = a.innerData.GetLength(1);

            if (!isSizeEqual(a, b)) throw new Exception("Матрицы с разной размерностью нельзя складывать");

            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.innerData.GetLength(1) != b.innerData.GetLength(0)) throw new Exception("Невозможно умножить матрицы!");

            Matrix result = new Matrix(b.innerData.GetLength(0), b.innerData.GetLength(1));

            for (int i = 0; i < a.innerData.GetLength(0); i++)
            {
                for(int j = 0; j < b.innerData.GetLength(1); j++)
                {
                    for(int k = 0; k < b.innerData.GetLength(0); k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }


        public static bool operator ==(Matrix a, Matrix b)
        {
            if (!isSizeEqual(a, b)) return false;

            for (int i = 0; i < a.innerData.GetLength(0); i++)
            {
                for (int j = 0; j < a.innerData.GetLength(1); j++)
                {
                    if (a[i, j] != b[i, j]) return false;
                }
            }

            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public Matrix Transp()
        {
            Matrix result = new Matrix(this.innerData.GetLength(1), this.innerData.GetLength(0));

            for (int i = 0; i < this.innerData.GetLength(0); i++)
            {
                for (int j = 0; j < this.innerData.GetLength(1); j++)
                {
                    result[j, i] = this.innerData[i, j];
                }
            }

            return result;
        }

        public double MinValue()
        {
            double minValue = this.innerData[0, 0];

            for (int i = 0; i < this.innerData.GetLength(0); i++)
            {
                for (int j = 0; j < this.innerData.GetLength(1); j++)
                {
                    if (this.innerData[i, j] < minValue) minValue = this.innerData[i, j];
                }
            }

            return minValue;
        }

        private void checkIndex(int i, int j)
        {
            if (i > innerData.GetLength(0) - 1) throw new Exception("Недопустимый индекс: " + i);
            if (j > innerData.GetLength(1) - 1) throw new Exception("Недопустимый индекс: " + j);
        }

        private static bool isSizeEqual(Matrix a, Matrix b)
        {
            if (a.innerData.GetLength(0) != b.innerData.GetLength(0) || a.innerData.GetLength(1) != b.innerData.GetLength(1)) return false;

            return true;
        }

        public override string ToString()
        {
            string result = "";

            int rows = innerData.GetLength(0);
            int columns = innerData.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += string.Format("{0} \t", innerData[i, j]);
                }
                result += "\n";
            }

            return result;
        }
    }
}
