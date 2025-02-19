using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using IT_DEV_RISK.Handlers;
using IT_DEV_RISK.Interfaces;
using IT_DEV_RISK.Models;
using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Category;
using Xunit;

namespace IT_DEV_RISK.Tests
{
    public class ValidateHandlerTests
    {
        [Fact]
        public void ValidateHandler_ShouldPrintExpectedCategories()
        {
            // Arrange
            var categories = new List<ICategory>
            {
                new ExpiredCategory(),
                new HighRiskCategory(),
                new MediumRiskCategory()
            };

            DateTime referenceDate = DateTime.ParseExact("12/11/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture);

            var trades = new List<Trade>
            {
                new Trade
                {
                    Value = 2000000,
                    ClientSector = ClientSectorEnum.Private,
                    NextPaymentDate = DateTime.ParseExact("12/29/2025", "MM/dd/yyyy", CultureInfo.InvariantCulture)
                },
                new Trade
                {
                    Value = 400000,
                    ClientSector = ClientSectorEnum.Public,
                    NextPaymentDate = DateTime.ParseExact("07/01/2020", "MM/dd/yyyy", CultureInfo.InvariantCulture)
                },
                new Trade
                {
                    Value = 5000000,
                    ClientSector = ClientSectorEnum.Public,
                    NextPaymentDate = DateTime.ParseExact("01/02/2024", "MM/dd/yyyy", CultureInfo.InvariantCulture)
                },
                new Trade
                {
                    Value = 3000000,
                    ClientSector = ClientSectorEnum.Public,
                    NextPaymentDate = DateTime.ParseExact("10/26/2023", "MM/dd/yyyy", CultureInfo.InvariantCulture)
                }
            };

            var expectedOutput = string.Join(Environment.NewLine, new[]
            {
                "HIGHRISK",
                "EXPIRED",
                "MEDIUMRISK",
                "MEDIUMRISK"
            });

            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            ValidateHandler.Validate(categories, referenceDate, trades);

            // Assert
            var actualOutput = sw.ToString().Trim();
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
