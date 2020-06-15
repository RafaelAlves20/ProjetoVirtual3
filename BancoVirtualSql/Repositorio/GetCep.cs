using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BancoVirtualSql.Repositorio
{
    public class GetCep
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Unidade { get; set; }
        public long Ibge { get; set; }
        public string Gia { get; set; }


        public static GetCep DesSerializedClassGetCep(string vJson)
        {
            return JsonConvert.DeserializeObject<GetCep>(vJson);
        }
    }
}
