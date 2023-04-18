using ITAssetsManagement.Models.Tables;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Windows.Media.Imaging;
using ITAssetsManagement.Models;


namespace ITAssetsManagement.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=AssetsDatabase")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Ativos_Software> Software { get; set; }
        public DbSet<Ativos_Hardware> Hardware { get; set; }
        public DbSet<Fornecedores> Fornecedor { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Hardware_Produto> Hardware_Produto { get; set; }
        public DbSet<Software_Produto> Software_Produto { get; set; }
        public DbSet<Fornecedor_tem_hardware> Fornecedor_tem_hardware { get; set; }
        public DbSet<Fornecedor_tem_software> Fornecedor_tem_software { get; set; }

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

        public List<Funcionario_obj> Get_funcionario_nome(string nome)
        {
            List<Funcionario_obj> lista = new();

            foreach (var linha in this.Funcionarios)
            {
                if (linha.Nome == nome) {
                lista.Add(new Funcionario_obj{
                    Nome = linha.Nome,
                    Email = linha.Email,
                    Telefone = linha.Telefone,
                    CPF = linha.CPF
                }); 
               }
            }


            return lista;
        }

        public List<Software_obj> Get_software_nome(string nome)
        {
            List<string> Nomes_software = this.Database.SqlQuery<List<string>>

;
            foreach (var linha in this.Funcionarios)
            {
                if (linha.Nome == nome)
                {
                    lista.Add(new Funcionario_obj
                    {
                        Nome = linha.Nome,
                        Email = linha.Email,
                        Telefone = linha.Telefone,
                        CPF = linha.CPF
                    });
                }
            }


            return lista;
        }

    }
}
