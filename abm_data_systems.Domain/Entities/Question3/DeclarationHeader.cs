using System;
using abm_data_systems.Domain.Entities.Common;

namespace abm_data_systems.Domain.Entities.Question3
{
    public class DeclarationHeader : EntityBase
    {
        public string Jurisdiction { get; set; }
        public string CWProcedure { get; set; }
        public string DeclarationDestination { get; set; }
        public string DocumentRef { get; set; }
        public string SiteID { get; set; }
        public string AccountCode { get; set; }
    }
}
