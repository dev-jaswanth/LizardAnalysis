using RiskManagement;
using System;

namespace RiskManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TdsXmlDataReader tdsXmlDataReader = new TdsXmlDataReader();
            RdsXmlDataReader rdsXmlDataReader = new RdsXmlDataReader();

            ITradeDataImporter tradeDataImporter = new XmlTradeDataImporter(tdsXmlDataReader);
            ICounterpartyDataImporter counterpartyDataImporter = new XmlCounterpartyDataImporter(rdsXmlDataReader);

            IRiskCalculator riskCalculator = new SimpleRiskCalculator();
            IReportGenerator reportGenerator = new ExcelReportGenerator();
            Merger merger = new Merger();

            RiskAnalysisService riskAnalysisService = new RiskAnalysisService(
                tradeDataImporter,
                counterpartyDataImporter,
                riskCalculator,
                reportGenerator,
                merger);

            riskAnalysisService.AnalyzeRiskAndGenerateReport();
        }
    }
}
