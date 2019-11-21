using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.CodeChallenge
{
    [XmlRoot(ElementName = "Country")]
    public class CountryViewModal
    {
        [XmlAttribute(AttributeName = "CodeType")]
        public string CodeType { get; set; }
        [XmlAttribute(AttributeName = "CountryType")]
        public string CountryType { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
