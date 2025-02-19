using IT_DEV_RISK.Category;
using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Models;

namespace IT_DEV_RISK.Tests
{
    public class ExpiredCategoryTests
    {
        [Fact]
        public void ExpiredCategory_TradeExpired_ReturnsExpired()
        {
            // Arrange
            var category = new ExpiredCategory();
            var referenceDate = new DateTime(2020, 12, 11);
            var trade = new Trade
            {
                Value = 400000,
                NextPaymentDate = new DateTime(2020, 07, 01),
                ClientSector = ClientSectorEnum.Public
            };

            // Act
            var result = category.Validate(referenceDate, trade);

            // Assert
            Assert.Equal("EXPIRED", result);
        }

        [Fact]
        public void ExpiredCategory_TradeNotExpired_ReturnsEmptyString()
        {
            // Arrange
            var category = new ExpiredCategory();
            var referenceDate = new DateTime(2020, 01, 01);
            var trade = new Trade
            {
                Value = 400000,
                NextPaymentDate = new DateTime(2020, 02, 01),
                ClientSector = ClientSectorEnum.Public
            };

            // Act
            var result = category.Validate(referenceDate, trade);

            // Assert
            Assert.Equal(string.Empty, result);
        }
    }
}
