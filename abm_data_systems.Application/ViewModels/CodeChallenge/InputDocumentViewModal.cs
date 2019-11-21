using System;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.CodeChallenge
{
    [XmlRoot(ElementName = "InputDocument")]
    public class InputDocumentViewModal : ViewModelBase
    {
        [XmlElement(ElementName = "DeclarationList")]
        public DeclarationListViewModal DeclarationList { get; set; }
    }
}
