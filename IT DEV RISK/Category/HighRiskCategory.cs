using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Interfaces;

namespace IT_DEV_RISK.Category
{
    public class HighRiskCategory : ICategory
    {
        private const double HIGH_RISK_THRESHOLD = 1000000;

        public string Validate(DateTime referenceDate, ITrade trade)
        {
            if (trade.Value > HIGH_RISK_THRESHOLD && trade.ClientSector == ClientSectorEnum.Private)
            {
                return "HIGHRISK";
            }
            return string.Empty;
        }
    }
}
