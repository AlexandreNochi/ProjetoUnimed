using Microsoft.EntityFrameworkCore;
using ProjetoUnimed.Models;

namespace ProjetoUnimed.Context
{
    public class UnimedContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Exame> Exames { get; set; }

        public string DbPath { get; }

        public UnimedContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Unimed.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}