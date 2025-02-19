using IT_DEV_RISK.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_DEV_RISK.Interfaces
{
    public interface ITrade
    {
        double Value { get; } //indica o valor da operação em dólar
        ClientSectorEnum ClientSector { get; } //Indica o setor do cliente, que pode ser "Public" ou "Private"
        DateTime NextPaymentDate { get; } //Indica a expectativa da data do próximo pagamento do cliente ao
    }
}
