using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class ProducingAgency : ComplexTypeBase, IProducingAgency
    {
        public string OrganisationName { get; set; }
        public IContactInfo ContactInfo { get; set; }
        public IRole[] Roles { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(OrganisationName) &&
                    (ContactInfo == null || ContactInfo.IsEmpty);
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
            writer.WriteAttributeString("gco", "isoType", "http://www.isotc211.org/2005/gco", "gmd:CI_ResponsibleParty");

            if (!String.IsNullOrEmpty(OrganisationName))
            {
                writer.WriteStartElement("gmd", "organisationName", "http://www.isotc211.org/2005/gmd");
                writer.WriteStartElement("gco", "CharacterString", "http://www.isotc211.org/2005/gco");
                writer.WriteString(OrganisationName);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            if (ContactInfo != null && ContactInfo.IsEmpty == false)
            {
                ContactInfo.NamespacePrefix = "gmd";
                ContactInfo.Namespace = "http://www.isotc211.org/2005/gmd";
                ContactInfo.WriteXml(writer);
            }

            if (Roles != null && Roles.Length > 0)
            {
                foreach (var role in Roles)
                {
                    if (role.IsEmpty == false)
                    {
                        role.WriteXml(writer);
                    }
                }
            }

            writer.WriteEndElement();
        }
    }
}
