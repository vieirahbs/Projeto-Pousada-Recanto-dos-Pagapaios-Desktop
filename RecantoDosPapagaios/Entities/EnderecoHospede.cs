using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecantoDosPapagaios.Entities
{
    class EnderecoHospede
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string NumeroResidencial { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public List<EnderecoHospede> ListaEndereco { get; set; } = new List<EnderecoHospede>();
        public EnderecoHospede()
        {
        }

        public EnderecoHospede(string cEP, string logradouro, string numeroResidencial,
            string complemento, string bairro, string cidade, string estado,
            string pais)
        {
            CEP = cEP;
            Logradouro = logradouro;
            NumeroResidencial = numeroResidencial;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public void AdicionaEndereco(EnderecoHospede endereco)
        {
            ListaEndereco.Add(endereco);
        }
    }
}
