using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class SpecificUsage : ComplexTypeBase, ISpecificUsage
    {
        public IMDUsage MDUsage { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return MDUsage == null || MDUsage.IsEmpty;
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
            writer.WriteStartElement(NamespacePrefix, "specificUsage", Namespace);

            if (MDUsage != null && MDUsage.IsEmpty == false)
            {
                MDUsage.NamespacePrefix = "mri";
                MDUsage.Namespace = "http://standards.iso.org/iso/19115/-3/mri/1.0d";
                MDUsage.WriteXml(writer);
            }

            writer.WriteEndElement();
        }
    }
}
