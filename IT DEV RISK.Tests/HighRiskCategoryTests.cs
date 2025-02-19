using IT_DEV_RISK.Category;
using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Models;

namespace IT_DEV_RISK.Tests
{
    public class HighRiskCategoryTests
    {
        [Fact]
        public void HighRiskCategory_TradeHighRisk_ReturnsHighRisk()
        {
            // Arrange
            var category = new HighRiskCategory();
            var referenceDate = new DateTime(2020, 12, 11);
            var trade = new Trade
            {
                Value = 2000000,
                NextPaymentDate = new DateTime(2025, 12, 29),
                ClientSector = ClientSectorEnum.Private
            };

            // Act
            var result = category.Validate(referenceDate, trade);

            // Assert
            Assert.Equal("HIGHRISK", result);
        }

        [Fact]
        public void HighRiskCategory_TradeHighRisk_ReturnsEmpty()
        {
            // Arrange
            var category = new HighRiskCategory();
            var referenceDate = new DateTime(2020, 12, 11);
            var trade = new Trade
            {
                Value = 999999,
                NextPaymentDate = new DateTime(2025, 12, 29),
                ClientSector = ClientSectorEnum.Private
            };

            // Act
            var result = category.Validate(referenceDate, trade);

            // Assert
            Assert.Equal("", result);
        }
    }
}