using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_DEV_RISK.Category
{
    public class MediumRiskCategory : ICategory
    {
        public string Validate(DateTime referenceDate, ITrade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == ClientSectorEnum.Public)
            {
                return "MEDIUMRISK";
            }
            return string.Empty;
        }
    }
}
