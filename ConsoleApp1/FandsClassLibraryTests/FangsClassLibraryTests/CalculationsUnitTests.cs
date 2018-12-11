using System;
using Nunit.Framework;
using FangsClassLibrary;


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

            var testFloat = 2.4f;
            result = Calculations.DoubleANumber(testFloat);

            Assert.That(result, Is.EqualTo(2.8f));
        }

        [Test]
        public void GetCelsiusFromFarenheitTest()
        {
            var farenheitTemp = 100f;
            var expectedApproximateCelsius = 38;

            float result = Calculations.GetCelsiusFromFarenheit(farenheitTemp);
            result = Math.Round(result, 0);

            Assert.That(result, Is.EqualTo(expectedApproximateCelsius));

        }

        [Test]
        public void GetFarenheitFromCelsiusTest()
        {
            var farenheitTemp = 100f;
            var celsiusTemp = 38;

            float result = Calculations.GetFarenheitFromCelsius(celsiusTemp);
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
