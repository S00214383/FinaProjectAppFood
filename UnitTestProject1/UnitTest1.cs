using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinaProjectAppFood;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Dish_Rate()
        {
            //arrange
            Countries c1 = new Countries() {CountryName = "Brazil", TraditionalDish = "Feijoada" , Continent = "South America" , Rate = 5};
            int expectedRate = 10;


            //act
            c1.RateDish(4);


            //assert
            Assert.AreEqual(expectedRate, c1.Rate);
        }
    }
}
