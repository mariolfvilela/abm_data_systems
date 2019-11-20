using System;
using abm_data_systems.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace abm_data_systems.Infra.Data.Mappings
{
    internal class MapBase<T> : IEntityTypeConfiguration<T>
        where T : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().UseMySqlIdentityColumn().HasColumnName("ID");
            builder.Property(c => c.CreationDate).IsRequired().HasColumnName("CREATED");
            builder.Property(c => c.LastModifiedDate).HasColumnName("LASTMODIFIED");
        }
    }
}
