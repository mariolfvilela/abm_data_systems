using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace abm_data_systems.Application.ViewModels.CodeChallenge
{
    [XmlRoot(ElementName = "DeclarationHeader")]
    public class DeclarationHeaderViewModal
    {
        [XmlElement(ElementName = "Jurisdiction")]
        public string Jurisdiction { get; set; }
        [XmlElement(ElementName = "CWProcedure")]
        public string CWProcedure { get; set; }
        [XmlElement(ElementName = "DeclarationDestination")]
        public string DeclarationDestination { get; set; }
        [XmlElement(ElementName = "DocumentRef")]
        public string DocumentRef { get; set; }
        [XmlElement(ElementName = "SiteID")]
        [Required(ErrorMessage = "-2")]
        public string SiteID { get; set; }
        [XmlElement(ElementName = "AccountCode")]
        public string AccountCode { get; set; }
    }
}
