using RiskManagement;
using System.Linq;

namespace RiskManagement
{
    public class RiskAnalysisService
    {
        private readonly ITradeDataImporter tradeDataImporter;
        private readonly ICounterpartyDataImporter counterpartyDataImporter;
        private readonly IRiskCalculator riskCalculator;
        private readonly IReportGenerator reportGenerator;
        private readonly Merger merger;

        public RiskAnalysisService(ITradeDataImporter tradeDataImporter,
                                   ICounterpartyDataImporter counterpartyDataImporter,
                                   IRiskCalculator riskCalculator,
                                   IReportGenerator reportGenerator,
                                   Merger merger)
        {
            this.tradeDataImporter = tradeDataImporter;
            this.counterpartyDataImporter = counterpartyDataImporter;
            this.riskCalculator = riskCalculator;
            this.reportGenerator = reportGenerator;
            this.merger = merger;
        }

        public void AnalyzeRiskAndGenerateReport()
        {
            var tradeData = tradeDataImporter.ImportTradeData();
            var counterpartyData = counterpartyDataImporter.ImportCounterpartyData();
            if (!counterpartyData.Any() || !tradeData.Any())
            {
                // Handle the scenario where one or both datasets are empty
                return;
            }

            var mergedData = merger.MergeData(tradeData, counterpartyData);
            var riskReport = riskCalculator.CalculateRisk(mergedData);
            reportGenerator.GenerateReport(riskReport);
        }
    }
}
