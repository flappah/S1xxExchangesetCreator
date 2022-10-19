using System;

namespace S1xxExchangesetGenerator
{
    public class Generator
    {
        /// <summary>
        ///     Input S1xx XML/GML file which it to be processed
        /// </summary>
        public string S1xxFileName { get; set; }

        /// <summary>
        ///     Collection of supportfiles that are to be added. Supported filetypes are PNG, SVG, TIFF, JPEG
        /// </summary>
        public string[] SupportFileNames { get; set; }

        /// <summary>
        ///     S-62 valid country code 
        /// </summary>
        public string ProducerCode { get; set; }

        /// <summary>
        ///     User provided file name that used to rename position 9-16 of the filename (A-Z0-9_)
        /// </summary>
        public string UniqueFileName { get; set; }
    }
}
