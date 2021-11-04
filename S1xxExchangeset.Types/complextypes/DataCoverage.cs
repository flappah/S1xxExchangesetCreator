using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class DataCoverage : ComplexTypeBase, IDataCoverage
    {
        public IBoundingBox BoundingBox { get; set; }
        public string BoundingPolygon { get; set; }
        public string OptimumDisplayScale { get; set; }
        public string MaximumDisplayScale { get; set; }
        public string MinimumDisplayScale { get; set; }

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
            throw new NotImplementedException();
        }
    }
}
