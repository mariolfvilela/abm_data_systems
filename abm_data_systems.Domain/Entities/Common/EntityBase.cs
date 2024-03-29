﻿using System;
namespace abm_data_systems.Domain.Entities.Common
{
    /// <summary>
    /// Entidade base.
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// Identificação (Identity)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Data de criação do registro.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Data de alteração do registro.
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }
    }
}
