using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.CodeChallenge
{
    [XmlRoot(ElementName = "Declaration")]
    public class DeclarationViewModal : ViewModelBase
    {
        [XmlElement(ElementName = "DeclarationHeader")]
        public InputDocumentViewModal DeclarationHeader { get; set; }
        [XmlAttribute(AttributeName = "Command")]
        public string Command { get; set; }
        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }
    }
}
