
using System.Collections.Generic;

namespace RiskManagement
{
    public class XmlTradeDataImporter : ITradeDataImporter
    {
        private readonly TdsXmlDataReader tdsXmlDataReader;

        public XmlTradeDataImporter(TdsXmlDataReader tdsXmlDataReader)
        {
            this.tdsXmlDataReader = tdsXmlDataReader;
        }

        public IEnumerable<object> ImportTradeData()
        {
            return tdsXmlDataReader.ReadTradeData();
        }
    }
}
