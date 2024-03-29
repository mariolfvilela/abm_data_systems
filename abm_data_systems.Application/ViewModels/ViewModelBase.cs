﻿using System;
using System.ComponentModel.DataAnnotations;
namespace abm_data_systems.Application.ViewModels
{
    public class ViewModelBase
    {
        [Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "The Created is Required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        //[DisplayName("Created Date")]
        public DateTime? CreationDate { get; set; }

        //[Required(ErrorMessage = "The LastModified is Required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        //[DisplayName("LastModified Date")]
        public DateTime? LastModifiedDate { get; set; }
    }
}
