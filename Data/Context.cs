using ITAssetsManagement.Models.Tables;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Windows.Media.Imaging;
using ITAssetsManagement.Models;


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

        public List<Funcionario_obj> Get_funcionario_CPF(long CPF)
        {
            List<Funcionario_obj> lista = new();
            foreach (var linha in this.Funcionarios)
            {
                if (linha.CPF == CPF)
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

        public List<Hardware_obj> Get_Hardware_HID(int Hardware_ID)        {
            List<Hardware_obj> lista = new();
            foreach (var linha in this.Hardware)
            {
                if (linha.Hardware_ID == Hardware_ID)
                {
                    lista.Add(new Hardware_obj
                    {
                        ID = linha.ID,
                        Hardware_ID = linha.Hardware_ID,
                        Funcionario = linha.Funcionario,
                        Fornecedor = linha.Fornecedor
                    });
                }
            }
            return lista;
        }
    }
}
