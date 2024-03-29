﻿using System;
using abm_data_systems.Application.ViewModels;
using abm_data_systems.Application.ViewModels.CodeChallenge;
using abm_data_systems.Domain.Entities;
using abm_data_systems.Domain.Entities.CodeChallenge;
using AutoMapper;

namespace abm_data_systems.Application.AutoMapper
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            // Application to Domain
            CreateMap<UserViewModel, User>();
            CreateMap<InputDocumentViewModal, InputDocument>();

            // Domain to Resource
            CreateMap<User, UserViewModel>();
            CreateMap<InputDocument, InputDocumentViewModal>();
        }
    }
}
