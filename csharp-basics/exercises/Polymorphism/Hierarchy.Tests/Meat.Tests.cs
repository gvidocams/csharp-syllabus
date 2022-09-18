namespace Hierarchy.Tests
{
    [TestClass]
    public class MeatTests
    {
        [TestMethod]
        public void CreateAValidMeatInstance_ReturnsQuantityOfMeats()
        {
            var Meat = new Meat(5);

            Meat.Quantity.Should().Be(5);
        }
    }
}
