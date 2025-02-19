using IT_DEV_RISK.Interfaces;

namespace IT_DEV_RISK.Category
{
    public class ExpiredCategory : ICategory
    {
        public string Validate(DateTime referenceDate, ITrade trade)
        {
            if ((trade.NextPaymentDate - referenceDate).TotalDays <= -30)
            {
                return "EXPIRED";
            }
            return string.Empty;
        }
    }
}
