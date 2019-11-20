using System;
using System.Linq;
using abm_data_systems.Domain.Entities;
using abm_data_systems.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace abm_data_systems.Infra.Data.Context
{
    public class Context_ABM_Data_Systems : DbContext
    {
        public DbSet<User> Users { get; set; }

        public IDbContextTransaction Transaction { get; private set; }

        public Context_ABM_Data_Systems(DbContextOptions<Context_ABM_Data_Systems> options)
            : base(options)
        {
            Database.EnsureCreated();
            //if (Database.GetPendingMigrations().Count() > 0)
            //Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        public IDbContextTransaction InitTransacao()
        {
            if (Transaction == null) Transaction = this.Database.BeginTransaction();
            return Transaction;
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreationDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreationDate").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreationDate").IsModified = false;
                }
            };

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("LastModifiedDate") != null))
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("LastModifiedDate").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Added)
                {
                    entry.Property("LastModifiedDate").IsModified = false;
                }
            };
            return base.SaveChanges();
        }

        private void RollBack()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
            }
        }

        private void Salvar()
        {
            try
            {
                ChangeTracker.DetectChanges();
                SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void SendChanges()
        {
            Salvar();
            Commit();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
        }

    }
}