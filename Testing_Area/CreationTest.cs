using Draw_And_Fill_Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Testing_Area
{
    [TestClass]
    public class CreationTest
    {
        //This is to test for whether or not we get to draw a square on the canvas.
        [TestMethod]
        public void IsMade()
        {
            //Arrange
            int K = 10;

            string[,] expectedResult = new string[K, K];
            for (int x = 0; x < K; x++)
            {

                for (int y = 0; y < K; y++)
                {
                    if (x==0 || x== K-1)
                    {
                        expectedResult[x, y] = "B";
                    }
                    else if (y == 0 || y==K-1)
                    {
                        expectedResult[x, y] = "B";
                    }
                    else
                    {
                        expectedResult[x, y] = " ";
                    }
                }
            }
            
            Canvas P = new Canvas(K);

            //Act
            P.Draw();
            bool actualResult = expectedResult.Cast<string>().SequenceEqual(P.Drawing.Cast<string>());

            //Assert
            //Assert.AreEqual(expectedResult, P.Drawing);
            //Assert.IsTrue(Enumerable.SequenceEqual<string[,]>(expectedResult.Cast<string[,]>(), P.Drawing.Cast<string[,]>()));

            Assert.AreEqual(true, actualResult);
                
        }
    }
}
