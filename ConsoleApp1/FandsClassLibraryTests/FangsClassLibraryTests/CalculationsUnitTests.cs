using System;


namespace FangsClassLibraryTests
{
    [TestFixture]
    public class CalculationsUnitTests
    {
        [Test]
        public void DoubleANumberTests()
        {
            var test = 1;
            var result = Calculations.DoubleANumber(test);

            Assert.That(result, Is.EqualTo(2));

            test = 2;
            result = Calculations.DoubleANumber(test);

            Assert.That(result, Is.EqualTo(4));

            var testDouble = 2.4d;
            var resultDouble = Calculations.DoubleANumber(testDouble);

            Assert.That(resultDouble, Is.EqualTo(2.8f));
        }

        [Test]
        public void GetCelsiusFromFarenheitTest()
        {
            var farenheitTemp = 100d;
            var expectedApproximateCelsius = 38d;

            var result = Calculations.GetCelsiusFromFarenheit(farenheitTemp);
            result = Math.Round(result, 0);

            Assert.That(result, Is.EqualTo(expectedApproximateCelsius));

        }

        [Test]
        public void GetFarenheitFromCelsiusTest()
        {
            var farenheitTemp = 100d;
            var celsiusTemp = 38d;

            var result = Calculations.GetFarenheitFromCelsius(celsiusTemp);
            result = Math.Round(result, 0);

            Assert.That(result, Is.EqualTo(farenheitTemp));
            
        }

        [Test]
        public void AgeInDogYearsTest()
        {
            var humanAge = 10;
            var dogAge = 70;

            var result = Calculations.AgeInDogYears(humanAge);

            Assert.That(result, Is.EqualTo(dogAge));
        }
    }
}
