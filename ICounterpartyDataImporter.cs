using System.Collections.Generic;

namespace RiskManagement
{
    public interface ICounterpartyDataImporter
    {
        IEnumerable<object> ImportCounterpartyData();
    }
}
