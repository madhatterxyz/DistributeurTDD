using DistributeurTDD.Domain;

namespace DistributeurTDD.Tests
{
    public class BeverageTests
    {
        [Fact]
        public void GetPrice_Expresso_ShouldReturn156()
        {
            //Arrange
            BeverageDomain domain = new BeverageDomain();
            //Act
            double actualResult = domain.GetPrice("Expresso");
            //Assert
            Assert.Equal(1.56, actualResult);
        }
    }
}