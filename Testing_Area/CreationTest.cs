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
        [TestMethod]
        public void IsMade()
        {
            //Arrange
            string[,] expectedResult = new string[10, 10];
            for (int x = 0; x < 10; x++)
            {

                for (int y = 0; y < 10; y++)
                {
                    if (x==0 || x== 9)
                    {
                        expectedResult[x, y] = "B";
                    }
                    else if (y == 0 || y==9)
                    {
                        expectedResult[x, y] = "B";
                    }
                    else
                    {
                        expectedResult[x, y] = " ";
                    }
                }
            }
            
            Canvas P = new Canvas(10);

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
