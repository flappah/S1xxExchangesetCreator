using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class ProducingAgency : ComplexTypeBase, IProducingAgency
    {
        public ICIResponsibility Responsibility { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return (Responsibility == null || Responsibility.IsEmpty);
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
            writer.WriteStartElement(NamespacePrefix, "producingAgency", Namespace);

            if (Responsibility != null && Responsibility.IsEmpty == false)
            {
                Responsibility.Namespace = "http://standards.iso.org/iso/19115/-3/cit/2.0";
                Responsibility.NamespacePrefix = "cit";
                Responsibility.WriteXml(writer);
            }
            else
            {
                writer.WriteStartElement("cit", "CI_Responsiblity", Namespace);
                writer.WriteAttributeString("xsi", "nil", "http://standards.iso.org/iso/19115/-3/cit/2.0", "true");
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
