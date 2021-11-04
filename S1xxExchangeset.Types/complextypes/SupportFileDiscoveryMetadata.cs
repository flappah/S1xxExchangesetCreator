using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class SupportFileDiscoveryMetadata : ComplexTypeBase, ISupportFileDiscoveryMetadata
    {
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string Purpose { get; set; }
        public string EditionNumber { get; set; }
        public string IssueDate { get; set; }
        public ISupportFileSpecification SupportFileSpecification { get; set; }
        public string DataType { get; set; }

        public override XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public override void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public override void WriteXml(XmlWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
