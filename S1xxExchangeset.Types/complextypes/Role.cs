﻿using S1xxExchangeset.Types.interfaces;
using System;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class Role : ComplexTypeBase, IRole
    {
        public string CodeList { get; set; }
        public string CodeValue { get; set; }

        /// <summary>
        ///     Returns true if the instance has no data
        /// </summary>
        public override bool IsEmpty
        {
            get
            {
                return String.IsNullOrEmpty(CodeList) && String.IsNullOrEmpty(CodeValue);
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
            writer.WriteStartElement(NamespacePrefix, "role", Namespace);
            writer.WriteStartElement(NamespacePrefix, "CI_RoleCode", Namespace);
            writer.WriteAttributeString("", "codeList", CodeList ?? @"http://standards.iso.org/ittf/PubliclyAvailableStandards/ISO_19139_Schemas/resources/codelist/gmxCodelists.xml#CI_RoleCode");
            writer.WriteAttributeString("", "codeListValue", CodeValue ?? @"owner");

            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
