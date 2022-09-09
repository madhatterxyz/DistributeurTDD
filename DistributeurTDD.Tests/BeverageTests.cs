using DistributeurTDD.Domain;

namespace DistributeurTDD.Tests
{
    public class BeverageTests
    {
        [Theory]
        [InlineData("Expresso",1.56)]
        [InlineData("Allong�", 1.82)]
        [InlineData("Capuccino", 3.51)]
        [InlineData("Chocolat",5.33)]
        [InlineData("Th�", 3.12)]
        public void GetPrice_ValidBeverage_ShouldReturnCalculatedPrice(string beverageName,double expectedCalculatedPrice)
        {
            //Arrange
            RecipeDomain domain = new RecipeDomain();
            //Act
            double actualResult = domain.GetPrice(beverageName);
            //Assert
            Assert.Equal(expectedCalculatedPrice, actualResult,2);
        }
        [Fact]
        public void GetPrice_InvalidBeverage_ShouldReturnNotImplementedException()
        {
            //Arrange
            RecipeDomain domain = new RecipeDomain();
            //Act & Assert
            Assert.Throws<NotImplementedException>(()=>domain.GetPrice("unknown"));
        }
    }
}