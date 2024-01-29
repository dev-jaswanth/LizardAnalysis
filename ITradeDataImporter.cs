using System.Collections.Generic;

namespace RiskManagement
{
    public interface ITradeDataImporter
    {
        IEnumerable<object> ImportTradeData();
    }
}
