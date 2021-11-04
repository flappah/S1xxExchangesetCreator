using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class Contact : ComplexTypeBase, IContact
    {
        public string Organization { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty => String.IsNullOrEmpty(Organization);

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

            //public string Organization { get; set; }
            if (!String.IsNullOrEmpty(Organization))
            {
                writer.WriteStartElement(NamespacePrefix, "organization", Namespace);
                writer.WriteString(Organization);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
