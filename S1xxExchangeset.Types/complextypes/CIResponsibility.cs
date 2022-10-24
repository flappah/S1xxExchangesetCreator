using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class CIResponsibility : ComplexTypeBase, ICIResponsibility
    {
        public IRole Role { get; set; }
        public IParty[] Party { get; set; }

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
            writer.WriteStartElement(NamespacePrefix, "CI_Responsibility", Namespace);

            if (Role != null && Role.IsEmpty == false)
            {
                Role.Namespace = Namespace;
                Role.NamespacePrefix = NamespacePrefix;
                Role.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement(NamespacePrefix, "role", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();
            }

            if (Party != null && Party.Length > 0)
            {
                foreach (IParty partyItem in Party)
                {
                    partyItem.Namespace = Namespace;
                    partyItem.NamespacePrefix = NamespacePrefix;
                    partyItem.WriteXml(writer);
                }
            }
            else
            {
                writer.WriteStartElement(NamespacePrefix, "party", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://www.w3.org/2001/XMLSchema-instance", "true");
                writer.WriteEndElement();

            }

            writer.WriteEndElement();
        }
    }
}
