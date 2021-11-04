using System;
using System.Collections.Generic;
using System.Text;

namespace S1xxExchangeset.Types.interfaces
{
    public interface ISupportFileDiscoveryMetadata : IComplexType
    {
		public string FileName { get; set; }
		public string FileLocation { get; set; }
		public string Purpose { get; set; }
		public string EditionNumber { get; set; }
		public string IssueDate { get; set; }
		public ISupportFileSpecification SupportFileSpecification { get; set; }
		public string DataType { get; set; }
	}
}
