using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.CodeChallenge
{
    [XmlRoot(ElementName = "Reference")]
    public class ReferenceViewModal
    {
        [XmlElement(ElementName = "RefText")]
        public string RefText { get; set; }
        [XmlAttribute(AttributeName = "RefCode")]
        public string RefCode { get; set; }
    }
}
