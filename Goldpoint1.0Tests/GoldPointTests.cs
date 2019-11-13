using Microsoft.VisualStudio.TestTools.UnitTesting;
using Goldpoint1._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goldpoint1._0.Tests
{
    [TestClass()]
    public class GoldPointTests
    {
        [TestMethod()]
        public void GoldPointTest()
        {
             
             double[] numbers = new double[10];
             int[] socer = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//new int [10];
             double Sum = 0, min, temp, max;
             int i=5, j;
             int maxno=0, minno=0;
             min = max = Math.Abs(numbers[i] - Sum * 0.0618);
            for ( i = 0; i < 10; i++)
            {
                j = i;
                temp = Math.Abs(numbers[i] - Sum * 0.0618);
                if (temp < min)
                {
                    min = temp;
                    minno = i;
                }
                if (temp > max)
                {
                    max = temp;
                    maxno = i;
                }
                //max = Math.Abs(numbers[i] - Sum * 0.618);
            }
            socer[minno] = socer[minno] + 2;
            socer[maxno] = socer[maxno] - 1;

        }
    }
}