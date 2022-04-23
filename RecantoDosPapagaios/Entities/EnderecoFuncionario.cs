using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecantoDosPapagaios.Entities
{
    class EnderecoFuncionario
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string NumeroResidencial { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public List<EnderecoFuncionario> ListaEnderecoFuncionario { get; set; } 
            = new List<EnderecoFuncionario>();
        public EnderecoFuncionario()
        {
        }

        public EnderecoFuncionario(string cEP, string logradouro,
            string numeroResidencial, string complemento, string bairro, 
            string cidade, string uF, string pais)
        {
            CEP = cEP;
            Logradouro = logradouro;
            NumeroResidencial = numeroResidencial;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Pais = pais;
        }

        public void AdicionaEndereco(EnderecoFuncionario endereco)
        {
            ListaEnderecoFuncionario.Add(endereco);
        }
    }
}
