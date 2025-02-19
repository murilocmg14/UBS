using IT_DEV_RISK.Category;
using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Models;

namespace IT_DEV_RISK.Tests
{
    public class MediumRiskCategoryTests
    {
        [Fact]
        public void MediumRiskCategory_TradeMediumRisk_ReturnsMediumRisk()
        {
            // Arrange
            var category = new MediumRiskCategory();
            var referenceDate = new DateTime(2020, 12, 11);
            var trade = new Trade
            {
                Value = 5000000,
                NextPaymentDate = new DateTime(2024, 01, 02),
                ClientSector = ClientSectorEnum.Public
            };

            // Act
            var result = category.Validate(referenceDate, trade);

            // Assert
            Assert.Equal("MEDIUMRISK", result);
        }

        [Fact]
        public void MediumRiskCategory_TradeMediumRisk_ReturnsEmpty()
        {
            // Arrange
            var category = new MediumRiskCategory();
            var referenceDate = new DateTime(2020, 12, 11);
            var trade = new Trade
            {
                Value = 999999,
                NextPaymentDate = new DateTime(2024, 01, 02),
                ClientSector = ClientSectorEnum.Public
            };

            // Act
            var result = category.Validate(referenceDate, trade);

            // Assert
            Assert.Equal(string.Empty, result);
        }
    }
}
