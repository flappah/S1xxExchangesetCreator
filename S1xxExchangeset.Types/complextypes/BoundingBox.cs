using S1xxExchangeset.Types.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;

namespace S1xxExchangeset.Types.complextypes
{
    public class BoundingBox : ComplexTypeBase, IBoundingBox
    {
        public double WestBoundLongitude { get; set; }
        public double EastBoundLongitude { get; set; }
        public double SouthBoundLatitude { get; set; }
        public double NorthBoundLatitude { get; set; }

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
