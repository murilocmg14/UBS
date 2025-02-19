using IT_DEV_RISK.Interfaces;
using IT_DEV_RISK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
