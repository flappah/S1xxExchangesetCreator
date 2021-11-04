using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class S100_CatalogueMetadata : ComplexTypeBase, IS100_CatalogueMetadata
    {
        public string FileName { get; set; }
        public string FileLocation { get; set; }
        public string Scope { get; set; }
        public string VersionNumber { get; set; }
        public string IssueDate { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public string DigitalSignatureReferences { get; set; }
        public string DigitalSignatureValue { get; set; }

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
