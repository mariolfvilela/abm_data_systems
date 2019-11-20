using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.Question3
{
    [XmlRoot(ElementName = "Declaration")]
    public class DeclarationViewModal
    {
        [XmlElement(ElementName = "DeclarationHeader")]
        public DeclarationHeaderViewModal DeclarationHeader { get; set; }
        [XmlAttribute(AttributeName = "Command")]
        public string Command { get; set; }
        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }
    }
}
