using IT_DEV_RISK.Enums;
using IT_DEV_RISK.Interfaces;

namespace IT_DEV_RISK.Models
{
    public class Trade : ITrade
    {
        public double Value { get; set; }

        public ClientSectorEnum ClientSector { get; set; }

        public DateTime NextPaymentDate { get; set; }
    }
}
