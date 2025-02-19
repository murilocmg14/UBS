using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Models;
using System.Globalization;

namespace IT_DEV_RISK.Handlers
{
    public class TradeHandler
    {
        private List<Trade> Trades { get; set; } = [];

        public List<Trade> AskForOperations()
        {
            var nOperations = AskQuantityOperation();
            while (Trades.Count < nOperations)
            {
                AskForOperation();
            }
            return Trades;
        }

        private int AskQuantityOperation()
        {
            int nOperations;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out nOperations) && nOperations > 0)
                    return nOperations;
                Console.WriteLine("Warning: Wrong value for number of operations, insert again");
            }
        }

        private void AskForOperation()
        {
            try
            {
                var tradeRawText = Console.ReadLine()?.Trim() ?? "";

                if (string.IsNullOrEmpty(tradeRawText))
                {
                    Console.WriteLine("Warning: Wrong input for operation, insert again");
                    return;
                }

                var tradeArray = tradeRawText.Split(" ");
                var trade = new Trade()
                {
                    Value = int.Parse(tradeArray[0]),
                    ClientSector = Enum.Parse<ClientSectorEnum>(tradeArray[1]),
                    NextPaymentDate = DateTime.ParseExact(tradeArray[2], "MM/dd/yyyy", CultureInfo.InvariantCulture),
                };

                Trades.Add(trade);
            }
            catch (Exception)
            {
                Console.WriteLine("Warning: Wrong input for operation, insert again");
            }
        }
    }
}
