using IT_DEV_RISK.Interfaces;
using IT_DEV_RISK.Models;

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
