using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.Question3
{
    [XmlRoot(ElementName = "InputDocument")]
    public class InputDocumentViewModal
    {
        [XmlElement(ElementName = "DeclarationList")]
        public DeclarationListViewModal DeclarationList { get; set; }
    }
}
