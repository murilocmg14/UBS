using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_DEV_RISK
{
    public static class ReferenceDateHandler
    {
        public static DateTime AskReferenceDate()
        {
            while (true)
            {
                var referenceDateRaw = Console.ReadLine();

                if (DateTime.TryParseExact(referenceDateRaw, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
                {
                    return date;
                }

                Console.WriteLine("Warning: Wrong input for reference date, please try again.");
            }
        }
    }
}
