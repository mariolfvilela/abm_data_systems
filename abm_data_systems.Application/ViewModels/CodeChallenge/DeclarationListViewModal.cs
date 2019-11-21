using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.CodeChallenge
{
    [XmlRoot(ElementName = "DeclarationList")]
    public class DeclarationListViewModal
    {
        [XmlElement(ElementName = "Declaration")]
        public DeclarationViewModal Declaration { get; set; }
    }
}
