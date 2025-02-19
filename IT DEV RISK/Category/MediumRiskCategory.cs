using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Interfaces;

namespace IT_DEV_RISK.Category
{
    public class MediumRiskCategory : ICategory
    {
        private const double MEDIUM_RISK_THRESHOLD = 1000000;

        public string Validate(DateTime referenceDate, ITrade trade)
        {
            if (trade.Value > MEDIUM_RISK_THRESHOLD && trade.ClientSector == ClientSectorEnum.Public)
            {
                return "MEDIUMRISK";
            }
            return string.Empty;
        }
    }
}
