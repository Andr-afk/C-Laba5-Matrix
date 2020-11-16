using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix_development;


namespace TestMatrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MinValue()
        {
            Matrix a = new Matrix(2, 2);

            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 3;
            a[1, 1] = -1;

            Assert.AreEqual(-1, a.MinValue());
        }

        [TestMethod]
        public void Transp()
        {
            Matrix a = new Matrix(2, 2);

            a[0, 0] = 1;
            a[0, 1] = 2;
            a[1, 0] = 3;
            a[1, 1] = 4;

            Matrix T = new Matrix(2, 2);

            T[0, 0] = 1;
            T[0, 1] = 3;
            T[1, 0] = 2;
            T[1, 1] = 4;

            Assert.IsTrue(T == a.Transp());
        }

        [TestMethod]
        public void Equal()
        {
            Matrix a = new Matrix(2, 1);

            a[0, 0] = 4.543;
            a[1, 0] = 3.44;

            Matrix b = new Matrix(2, 1);

            b[0, 0] = 4.543;
            b[1, 0] = 3.44;

            Assert.IsTrue(b == a);
        }

        [TestMethod]
        public void Sum()
        {
            Matrix a = new Matrix(2, 4);

            a[0, 0] = 1;
            a[0, 1] = 3;
            a[0, 2] = 0;
            a[0, 3] = 2;
            a[1, 0] = 4;
            a[1, 1] = 1;
            a[1, 2] = 3;
            a[1, 3] = 1;

            Matrix b = new Matrix(2, 4);

            b[0, 0] = 4;
            b[0, 1] = -3;
            b[0, 2] = 2;
            b[0, 3] = -2;
            b[1, 0] = -3;
            b[1, 1] = 0;
            b[1, 2] = 4;
            b[1, 3] = 0;

            Matrix result = new Matrix(2, 4);

            result[0, 0] = 5;
            result[0, 1] = 0;
            result[0, 2] = 2;
            result[0, 3] = 0;
            result[1, 0] = 1;
            result[1, 1] = 1;
            result[1, 2] = 7;
            result[1, 3] = 1;
 
            Assert.IsTrue(result == a + b);
        }

        [TestMethod]
        public void Minus()
        {
            Matrix a = new Matrix(2, 4);

            a[0, 0] = 1;
            a[0, 1] = 3;
            a[0, 2] = 0;
            a[0, 3] = 2;
            a[1, 0] = 4;
            a[1, 1] = 1;
            a[1, 2] = 3;
            a[1, 3] = 1;

            Matrix b = new Matrix(2, 4);

            b[0, 0] = 4;
            b[0, 1] = -3;
            b[0, 2] = 2;
            b[0, 3] = -2;
            b[1, 0] = -3;
            b[1, 1] = 0;
            b[1, 2] = 4;
            b[1, 3] = 0;

            Matrix result = new Matrix(2, 4);

            result[0, 0] = -3;
            result[0, 1] = 6;
            result[0, 2] = -2;
            result[0, 3] = 4;
            result[1, 0] = 7;
            result[1, 1] = 1;
            result[1, 2] = -1;
            result[1, 3] = 1;

            Assert.IsTrue(result == a - b);
        }

        [TestMethod]
        public void Proisvedenie()
        {
            Matrix a = new Matrix(2, 2);

            a[0, 0] = 1;
            a[0, 1] = 3;
            a[1, 0] = 2;
            a[1, 1] = 9;

            Matrix b = new Matrix(2, 1);

            b[0, 0] = 2;
            b[1, 0] = 3;


            Matrix result = new Matrix(2, 1);

            result[0, 0] = 11;
            result[1, 0] = 31;


            Assert.IsTrue(result == a * b);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Constructor()
        {
            new Matrix(-1, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Indecsator()
        {
            Matrix a = new Matrix(1, 1);

            a[0, 0] = 9;
            a[1, 0] = 4;
        }


    }
}
