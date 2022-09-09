using DistributeurTDD.Domain;

namespace DistributeurTDD.Tests
{
    public class BeverageTests
    {
        [Fact]
        public void GetPrice_Expresso_ShouldReturn156()
        {
            //Arrange
            RecipeDomain domain = new RecipeDomain();
            //Act
            double actualResult = domain.GetPrice("Expresso");
            //Assert
            Assert.Equal(1.56, actualResult);
        }
        [Fact]
        public void GetPrice_Allong�_ShouldReturn182()
        {
            //Arrange
            RecipeDomain domain = new RecipeDomain();
            //Act
            double actualResult = domain.GetPrice("Allong�");
            //Assert
            Assert.Equal(1.82, actualResult,2);
        }
    }
}