namespace Hierarchy.Tests
{
    [TestClass]
    public class TigerTests
    {
        private Tiger _tiger;

        [TestInitialize]
        public void Setup()
        {
            _tiger = new Tiger("Tiger", "GenericBigCatName", 20, "Africa", 12);
        }

        [TestMethod]
        public void MakeSound_MakeTigerSpecificSound()
        {
            _tiger.MakeSound().Should().Be("Rawr");
        }

        [TestMethod]
        public void Eat_EatsAVegetable()
        {
            // Arrange
            var Vegetable = new Vegetable(2);

            // Act & Assert
            _tiger.Eat(Vegetable).Should().Be("Tiger doesn't eat that type of food");
        }

        [TestMethod]
        public void Eat_EatsMeat()
        {
            // Arrange
            var Meat = new Meat(2);

            // Act & Assert
            _tiger.Eat(Meat).Should().Be("Chomp chomp");
        }

        [TestMethod]
        public void Display_DisplayTigerSpecificInfo()
        {
            _tiger.Display().Should().Be("Animal type: Tiger | Name: GenericBigCatName | Weight: 20 | Living region: Africa | Food eaten: 12");
        }
    }
}
