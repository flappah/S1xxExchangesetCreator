using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class Identifier : ComplexTypeBase, IIdentifier
    {
        public string Ident { get; set; }
        public string EditionNumber { get; set; }
        public string Date { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty 
        { 
            get {
                return String.IsNullOrEmpty(Ident) &&
                    String.IsNullOrEmpty(EditionNumber) &&
                    String.IsNullOrEmpty(Date);
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
            writer.WriteStartElement(NamespacePrefix, "identifier", Namespace);

            //public string Ident { get; set; }
            if (!String.IsNullOrEmpty(Ident))
            {
                writer.WriteStartElement(NamespacePrefix, "identifier", Namespace);
                writer.WriteString(Ident);
                writer.WriteEndElement();
            }

            //public string EditionNumber { get; set; }
            if (!String.IsNullOrEmpty(EditionNumber))
            {
                writer.WriteStartElement(NamespacePrefix, "editionNumber", Namespace);
                writer.WriteString(EditionNumber);
                writer.WriteEndElement();
            }

            //public string Date { get; set; }
            if (!String.IsNullOrEmpty(Date))
            {
                writer.WriteStartElement(NamespacePrefix, "date", Namespace);
                writer.WriteString(Date);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
