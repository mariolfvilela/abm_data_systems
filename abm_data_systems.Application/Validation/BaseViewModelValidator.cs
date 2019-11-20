using System;
using abm_data_systems.Application.ViewModels;
using DotNetCore.Validation;
namespace abm_data_systems.Application.Validation
{
    public class BaseViewModelValidator<T> : Validator<T> where T : ViewModelBase
    {
        protected BaseViewModelValidator()
        {
        }
    }
}
