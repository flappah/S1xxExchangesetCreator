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

        public override void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement(NamespacePrefix, "identifier", Namespace);
        }
    }
}
