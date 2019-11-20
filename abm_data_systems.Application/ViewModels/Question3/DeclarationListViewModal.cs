using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.Question3
{
    [XmlRoot(ElementName = "DeclarationList")]
    public class DeclarationListViewModal
    {
        [XmlElement(ElementName = "Declaration")]
        public DeclarationViewModal Declaration { get; set; }
    }
}
