using RiskManagement;
using System.Collections.Generic;

namespace RiskManagement
{
        public class XmlCounterpartyDataImporter : ICounterpartyDataImporter
        {
            private readonly RdsXmlDataReader rdsXmlDataReader;

            public XmlCounterpartyDataImporter(RdsXmlDataReader rdsXmlDataReader)
            {
                this.rdsXmlDataReader = rdsXmlDataReader;
            }

            public IEnumerable<object> ImportCounterpartyData()
            {
                return rdsXmlDataReader.ReadCounterpartyData();
            }
        }
    }

