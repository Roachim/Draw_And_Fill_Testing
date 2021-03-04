using Microsoft.VisualStudio.TestTools.UnitTesting;
using Draw_And_Fill_Testing;

namespace Testing_Area
{
    
    [TestClass]
    public class FillTest
    {
        //This test was made with the idea that the class fillerChecker would be able to check if color had been added to the insides of the square.
        //this test is therefore only here to test if true is returned.
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
