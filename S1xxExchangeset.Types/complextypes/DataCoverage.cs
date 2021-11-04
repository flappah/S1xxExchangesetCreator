using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class DataCoverage : ComplexTypeBase, IDataCoverage
    {
        public IBoundingBox BoundingBox { get; set; }
        public string BoundingPolygon { get; set; }
        public string OptimumDisplayScale { get; set; }
        public string MaximumDisplayScale { get; set; }
        public string MinimumDisplayScale { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return (BoundingBox == null || BoundingBox.IsEmpty);
            }
        }

        public override XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public override void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Write XML to XmlWriter 
        /// </summary>
        /// <param name="writer">writer to write XML to</param>
        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement(NamespacePrefix, "datasetDiscoveryMetadata", Namespace);

            //public IBoundingBox BoundingBox { get; set; }
            if (BoundingBox != null && BoundingBox.IsEmpty == false)
            {
                BoundingBox.Namespace = Namespace;
                BoundingBox.NamespacePrefix = NamespacePrefix;
                BoundingBox.WriteXml(writer);
            }

            //public string BoundingPolygon { get; set; }
            if (String.IsNullOrEmpty(BoundingPolygon))
            {
                writer.WriteAttributeString("gco", "nilReason", @"http://www.isotc211.org/2005/gco", "unknown");
            }
            else
            {
                // TODO: Make GML Polygon serializer from input string
            }
            
            //public string OptimumDisplayScale { get; set; }
            if (!String.IsNullOrEmpty(OptimumDisplayScale))
            {
                writer.WriteStartElement(NamespacePrefix, "optimumDisplayScale", Namespace);
                writer.WriteString(OptimumDisplayScale);
                writer.WriteEndElement();
            }

            //public string MaximumDisplayScale { get; set; }
            if (!String.IsNullOrEmpty(MaximumDisplayScale))
            {
                writer.WriteStartElement(NamespacePrefix, "maximumDisplayScale", Namespace);
                writer.WriteString(MaximumDisplayScale);
                writer.WriteEndElement();
            }

            //public string MinimumDisplayScale { get; set; }
            if (!String.IsNullOrEmpty(MinimumDisplayScale))
            {
                writer.WriteStartElement(NamespacePrefix, "minimumDisplayScale", Namespace);
                writer.WriteString(MinimumDisplayScale);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
