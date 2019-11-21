using System;
using abm_data_systems.Domain.Entities.Common;

namespace abm_data_systems.Domain.Entities.CodeChallenge



{
    public class Declaration : EntityBase
    {
        public InputDocument DeclarationHeader { get; set; }
        public string Command { get; set; }
        public string Version { get; set; }
    }
}
