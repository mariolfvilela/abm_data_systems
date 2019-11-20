using System;
using DotNetCore.Validation;
using abm_data_systems.Application.ViewModels;
using FluentValidation;

namespace abm_data_systems.Application.Validation
{
    public sealed class UserViewModelValidator : BaseViewModelValidator<UserViewModel>
    {
        public UserViewModelValidator()
        {
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Roles).NotEmpty();
        }
    }
}
