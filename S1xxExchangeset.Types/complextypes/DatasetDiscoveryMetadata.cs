using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class DatasetDiscoveryMetadata : ComplexTypeBase, IDatasetDiscoveryMetadata
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public string DataProtection { get; set; }
        public IClassification Classification { get; set; }
        public string Purpose { get; set; }
        public ISpecificUsage SpecificUsage { get; set; }
        public string EditionNumber { get; set; }
        public string UpdateApplicationDate { get; set; }
        public string IssueDate { get; set; }
        public IProductSpecification ProductSpecification { get; set; }
        public IProducingAgency ProducingAgency {get;set;}
        public string MaximumDisplayScale { get; set; }
        public string MinimumDisplayScale { get; set; }
        public string HorizontalDatumReference { get; set; }
        public string HorizontalDatumValue { get; set; }
        public string VerticalDatum { get; set; }
        public string SoundingDatum { get; set; }
        public string DataType { get; set; }
        public string DataTypeVersion { get; set; }
        public IDataCoverage DataCoverage { get; set; }
        public string Comment { get; set; }
        public IS100_19115DatasetMetadata S100_19115DatasetMetadata { get; set; }

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
