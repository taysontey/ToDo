﻿using System.Configuration;
using System.Data.Entity;
using ToDo.AcessoDados.Mapeamento;
using ToDo.Dominio.Entidades;

namespace ToDo.AcessoDados
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base(ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TarefaMap());
            modelBuilder.Configurations.Add(new SubtarefaMap());
        }

        public DbSet<Tarefa> Tarefa { get; set; }
        public DbSet<Subtarefa> Subtarefa { get; set; }
    }
}
