using TDDManifesto;

namespace TDDManifesto.Test
{
    public class TestKata1
    {
        private Kata1 kata1;

        [SetUp]
        public void Setup()
        {
            kata1 = new Kata1();
        }

        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(101)]
        [TestCase(-1501)]
        [TestCase(0)]
        public void WhenProvidedWithNumberReturnString(int number)
        {
            // Arrange
            var control = number.ToString();

            // Act
            var value = kata1.FizzBuzz(number);

            // Assert
            Assert.That(value, Is.TypeOf<string>());
            Assert.That(value, Is.EqualTo(control));
            Assert.That(number, Is.EqualTo(int.Parse(value)));
        }

        [TestCase(3)]
        [TestCase(-3)]
        [TestCase(6)]
        [TestCase(93)]
        public void WhenProvidedWithMultipleOfThreeReturnFizz(int number)
        {
            // Arrange
            var control = number.ToString();
            var expected = "Fizz";

            // Act
            var value = kata1.FizzBuzz(number);

            // Assert
            Assert.That(value, Is.TypeOf<string>());
            Assert.That(value, Is.EqualTo(expected));
            Assert.That(value, Is.Not.EqualTo(control));
        }

        [TestCase(5)]
        [TestCase(-5)]
        [TestCase(10)]
        [TestCase(20)]
        public void WhenProvidedWithMultipleOfFiveReturnBuzz(int number)
        {
            // Arrange
            var control = number.ToString();
            var expected = "Buzz";

            // Act
            var value = kata1.FizzBuzz(number);

            // Assert
            Assert.That(value, Is.TypeOf<string>());
            Assert.That(value, Is.EqualTo(expected));
            Assert.That(value, Is.Not.EqualTo(control));
        }

        [TestCase(15)]
        [TestCase(-15)]
        [TestCase(30)]
        [TestCase(90)]
        public void WhenProvidedWithMultipleOfFiveAndFiveReturnFizzBuzz(int number)
        {
            // Arrange
            var control = number.ToString();
            var expected = "FizzBuzz";

            // Act
            var value = kata1.FizzBuzz(number);

            // Assert
            Assert.That(value, Is.TypeOf<string>());
            Assert.That(value, Is.EqualTo(expected));
            Assert.That(value, Is.Not.EqualTo(control));
        }
    }
}