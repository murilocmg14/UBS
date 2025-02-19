using IT_DEV_RISK.Interfaces;
using IT_DEV_RISK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_DEV_RISK.Handlers
{
    public static class ValidateHandler
    {
        public static void Validate(List<ICategory> categories, DateTime referenceDate, List<Trade> trades)
        {
            foreach (var trade in trades)
            {
                foreach (var category in categories)
                {
                    var result = category.Validate(referenceDate, trade);
                    if (string.IsNullOrEmpty(result))
                        continue;

                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}
