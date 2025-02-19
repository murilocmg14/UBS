using IT_DEV_RISK.Interfaces;

namespace IT_DEV_RISK.Category
{
    public class ExpiredCategory : ICategory
    {
        private const int EXPIRED_DAYS_THRESHOLD = -30;

        public string Validate(DateTime referenceDate, ITrade trade)
        {
            if ((trade.NextPaymentDate - referenceDate).TotalDays <= EXPIRED_DAYS_THRESHOLD)
            {
                return "EXPIRED";
            }
            return string.Empty;
        }
    }
}
