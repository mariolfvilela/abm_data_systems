using System;
using abm_data_systems.Application.ViewModels.CodeChallenge;
using FluentValidation;

namespace abm_data_systems.Application.Validation
{
    public sealed class Question3ViewModalValitor : BaseViewModelValidator<InputDocumentViewModal>
    {
        public Question3ViewModalValitor()
        {
            RuleFor(x => x.DeclarationList.Declaration.Command).NotEmpty();
            RuleFor(x => x.DeclarationList.Declaration.DeclarationHeader.SiteID).NotEmpty();

            //If the Declararation’s Command <> ‘DEFAULT’ then return ‘-1’ – which means invalid command specified.
            RuleFor(x => x.DeclarationList.Declaration.Command).Equals("DEFAULT");
            //If the SiteID <> ‘DUB’ then return ‘-2’ – invalid Site specified.
            RuleFor(x => x.DeclarationList.Declaration.DeclarationHeader.SiteID).Equals("DUB");
        }
    }
}