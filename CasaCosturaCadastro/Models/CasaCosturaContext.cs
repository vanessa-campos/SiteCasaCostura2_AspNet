using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CasaCosturaCadastro.Models
{
    public partial class CasaCosturaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseMySql("Server=localhost;DataBase=Costura;Uid=root;");
            // optionsBuilder.UseMySql("Server=MYSQL5040.site4now.net;Database=db_a837b7_casacos;Uid=a837b7_casacos;Pwd=casacos21");
        }

        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vendidos> Vendidos { get; set; }
        public virtual DbSet<Costura> Costura { get; set; }
        public virtual DbSet<MesResumo> MesResumo { get; set; }
    }
}