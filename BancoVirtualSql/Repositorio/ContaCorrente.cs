namespace BancoVirtualSql.Repositorio
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public Cliente Cliente { get;  set; }
        public string Agencia { get;  set; }
        public string Conta { get;  set; }
        public double Saldo { get;  set; }
        public string Senha { get;  set; }
        public bool Situacao { get;  set; }

        public static int Tipo;

    }
}