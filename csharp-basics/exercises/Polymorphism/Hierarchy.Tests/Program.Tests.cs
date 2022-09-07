using Hierarchy;

namespace Hierarchy.Tests
{
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void FormatAnimal_PassValidMouse_ReturnsMouseInstance()
        {
            var Mouse = Program.FormatAnimal("Mouse Micey 1 House 12");

            Mouse.Should().BeEquivalentTo(new Mouse("Mouse", "Micey", 1, "House", 12));
        }

        [TestMethod]
        public void FormatAnimal_PassValidZebra_ReturnsZebraInstance()
        {
            var Zebra = Program.FormatAnimal("Zebra Marty 200 Africa 20");

            Zebra.Should().BeEquivalentTo(new Zebra("Zebra", "Marty", 200, "Africa", 20));
        }

        [TestMethod]
        public void FormatAnimal_PassValidTiger_ReturnsTigerInstance()
        {
            var Tiger = Program.FormatAnimal("Tiger Claw 200 Africa 20");

            Tiger.Should().BeEquivalentTo(new Tiger("Tiger", "Claw", 200, "Africa", 20));
        }

        [TestMethod]
        public void FormatAnimal_PassValidCat_ReturnsCatInstance()
        {
            var Cat = Program.FormatAnimal("Cat Mickey Persian 12 House 25");

            Cat.Should().BeEquivalentTo(new Cat("Cat", "Mickey", "Persian", 12, "House", 25));
        }

        [TestMethod]
        public void FormatAnimal_PassInvalidAnimal_ThrowsNotSupportedAnimalException()
        {
            Action act = () => Program.FormatAnimal("Girrafe Necky 12 House 25");

            act.Should().Throw<NotSupportedAnimalException>()
                .WithMessage("Not supported animal type: Girrafe");
        }

        [TestMethod]
        public void FormatFood_PassAValidVegetable_ReturnsVegetableInstance()
        {
            var Vegetable = Program.FormatFood("Vegetable 12");

            Vegetable.Should().BeEquivalentTo(new Vegetable(12));
        }

        [TestMethod]
        public void FormatFood_PassAValidMeat_ReturnsMeatInstance()
        {
            var Meat = Program.FormatFood("Meat 12");

            Meat.Should().BeEquivalentTo(new Meat(12));
        }

        [TestMethod]
        public void FormatFood_PassInvalidFood_ThrowsInvalidFoodException()
        {
            Action act = () => Program.FormatFood("NotAFood 64");

            act.Should().Throw<InvalidFoodException>()
                .WithMessage("Cannot declare a food type with this name: NotAFood");
        }
    }
}
