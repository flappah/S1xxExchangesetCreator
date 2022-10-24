using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class Party : ComplexTypeBase, IParty
    {
        public ICIOrganisation Organisation { get; set; }

        public override bool IsEmpty => throw new NotImplementedException();

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
            writer.WriteStartElement(NamespacePrefix, "party", Namespace);

            if (Organisation != null && Organisation.IsEmpty == false)
            {
                Organisation.Namespace = Namespace;
                Organisation.NamespacePrefix = NamespacePrefix;
                Organisation.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement(NamespacePrefix, "CI_Organisation", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
