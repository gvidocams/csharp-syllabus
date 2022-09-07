namespace Hierarchy.Tests
{
    [TestClass]
    public class VegetableTests
    {
        [TestMethod]
        public void CreateAValidVegetableInstance_ReturnsQuantityOfVegetables()
        {
            var Vegetable = new Vegetable(5);

            Vegetable.Quantity.Should().Be(5);
        }
    }
}