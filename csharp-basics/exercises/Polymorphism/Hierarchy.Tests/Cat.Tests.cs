namespace Hierarchy.Tests
{
    [TestClass]
    public class CatTests
    {
        private Cat _cat;

        [TestInitialize]
        public void Setup()
        {
            _cat = new Cat("Cat", "Mia", "Persian", 7, "Latvia", 12);
        }

        [TestMethod]
        public void MakeSound_MakesMouseSpecificSound()
        {
            _cat.MakeSound().Should().Be("Meeeeooooooowwww");
        }

        [TestMethod]
        public void Eat_EatsAVegetable()
        {
            // Arrange
            var Vegetable = new Vegetable(2);

            // Act & Assert
            _cat.Eat(Vegetable).Should().Be("Chomp chomp");
        }

        [TestMethod]
        public void Eat_EatsMeat()
        {
            // Arrange
            var Meat = new Meat(2);

            // Act & Assert
            _cat.Eat(Meat).Should().Be("Chomp chomp");
        }

        [TestMethod]
        public void Display_ShouldDisplayCatInfo()
        {
            _cat.Display().Should().Be("Animal type: Cat | Name: Mia | Cat breed: Persian | Weight: 7 | Living region: Latvia | Food eaten: 12");
        }
    }
}