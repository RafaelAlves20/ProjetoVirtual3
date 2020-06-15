using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BancoVirtualSql.Repositorio;

namespace BancoVirtualSql.Conexao
{
    public class BancoVirtualContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        public DbSet<Extrato> Extratos { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server = SUPORTELOCAL02\PARTNERSQL;Database=BancoVirtual;Trusted_Connection=true;");
            //optionsBuilder.UseSqlServer(@"Server = RAFAEL-PC\PARTNERSQL;Database=BancoVirtual;Trusted_Connection=true;");
        }
    }
}
