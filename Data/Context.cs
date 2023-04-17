using ITAssetsManagement.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Windows.Media.Imaging;

namespace ITAssetsManagement.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=AssetsDatabase")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ativos_Software> Software { get; set; }
        public DbSet<Hardware> Hardware { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Self referencing many to many relationship
            modelBuilder.Entity<UserContacts>()
                .HasRequired(x => x.User)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.UserId)
                .WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);
        }*/

    }
}
