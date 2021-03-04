using Microsoft.VisualStudio.TestTools.UnitTesting;
using Draw_And_Fill_Testing;

namespace Testing_Area
{
    [TestClass]
    public class FillTest
    {
        [TestMethod]
        public void CheckIfFilled()
        {
            //Arrange
            bool expectedResult = true;
            string[,] construct = new string[10, 10];

            //FillerChecker G = new FillerChecker(); 

            //Act
            bool actualResult = FillerChecker.Check(construct);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        
    }
}
