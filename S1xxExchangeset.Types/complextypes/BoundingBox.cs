using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class BoundingBox : ComplexTypeBase, IBoundingBox
    {
        public double WestBoundLongitude { get; set; }
        public double EastBoundLongitude { get; set; }
        public double SouthBoundLatitude { get; set; }
        public double NorthBoundLatitude { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return WestBoundLongitude == 0.0 &&
                    EastBoundLongitude == 0.0 &&
                    SouthBoundLatitude == 0.0 &&
                    NorthBoundLatitude == 0.0;
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
            writer.WriteStartElement(NamespacePrefix, "boundingBox", Namespace);
            writer.WriteAttributeString("gco", "isoType", @"http://www.isotc211.org/2005/gco", "gmd:EX_GeographicBoundingBox");

            writer.WriteStartElement("gmd", "westBoundLongitude", @"http://www.isotc211.org/2005/gmd");
            writer.WriteStartElement("gco", "Decimal", @"http://www.isotc211.org/2005/gco");
            writer.WriteString(WestBoundLongitude.ToString(new CultureInfo("en-US")));
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("gmd", "eastBoundLongitude", @"http://www.isotc211.org/2005/gmd");
            writer.WriteStartElement("gco", "Decimal", @"http://www.isotc211.org/2005/gco");
            writer.WriteString(EastBoundLongitude.ToString(new CultureInfo("en-US")));
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("gmd", "southBoundLatitude", @"http://www.isotc211.org/2005/gmd");
            writer.WriteStartElement("gco", "Decimal", @"http://www.isotc211.org/2005/gco");
            writer.WriteString(SouthBoundLatitude.ToString(new CultureInfo("en-US")));
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("gmd", "northBoundLatitude", @"http://www.isotc211.org/2005/gmd");
            writer.WriteStartElement("gco", "Decimal", @"http://www.isotc211.org/2005/gco");
            writer.WriteString(NorthBoundLatitude.ToString(new CultureInfo("en-US")));
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}
