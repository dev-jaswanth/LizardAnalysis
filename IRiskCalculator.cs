using System.Collections.Generic;

namespace RiskManagement
{
    public interface IRiskCalculator
    {
        object CalculateRisk(IEnumerable<object> tradeData);
    }
}
