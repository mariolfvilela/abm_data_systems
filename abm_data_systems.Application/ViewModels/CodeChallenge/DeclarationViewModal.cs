using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.CodeChallenge
{
    [XmlRoot(ElementName = "Declaration")]
    public class DeclarationViewModal
    {
        [XmlElement(ElementName = "DeclarationHeader")]
        public DeclarationHeaderViewModal DeclarationHeader { get; set; }

        [XmlAttribute(AttributeName = "Command")]
        [Required(ErrorMessage = "-1" )]
        public string Command { get; set; }
        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }
    }
}
