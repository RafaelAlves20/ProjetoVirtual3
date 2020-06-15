using System;

namespace BancoVirtualSql.Repositorio
{
    public class Extrato
    {
        public int Id { get; set; }
        public ContaCorrente Conta { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
        public DateTime DataHora { get; set; }
    }
}