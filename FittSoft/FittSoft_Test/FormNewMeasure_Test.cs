using FittSoft;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FittSoft_Test
{

    class FormNewMeasure_Test
    {
        [
         TestCase("asd", false),
         TestCase("", false),
         TestCase(" ", false),
         TestCase("2020-11-14", true),
         TestCase("2020.11.14", true)
        ]
        public void TestValidateDate(string date, bool expectedResult)
        {
            // Arrange
            var formNewMeasure = new FormNewMeasure();

            // Act
            var actualResult = formNewMeasure.ValidateDate(date);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
         TestCase("asd", false),
         TestCase("", false),
         TestCase(" ", false),
         TestCase("11", true),
         TestCase("11,4", true),
         TestCase("11.4", false)
        ]
        public void TestValidateWeight(string dec, bool expectedResult)
        {
            // Arrange
            var formNewMeasure = new FormNewMeasure();

            // Act
            var actualResult = formNewMeasure.ValidateWeight(dec);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [
         TestCase("asd", false),
         TestCase("", true),
         TestCase(" ", false),
         TestCase("11", true),
         TestCase("11,4", true),
         TestCase("100", false),
         TestCase("11.4", false)
        ]
        public void TestValidateBodyfat(string bodyfat, bool expectedResult)
        {
            // Arrange
            var formNewMeasure = new FormNewMeasure();

            // Act
            var actualResult = formNewMeasure.ValidateBodyfat(bodyfat);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
