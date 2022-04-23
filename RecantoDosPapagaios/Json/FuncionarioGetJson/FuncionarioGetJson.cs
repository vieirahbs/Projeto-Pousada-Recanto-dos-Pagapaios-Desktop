using System;

namespace RecantoDosPapagaios.Json
{
    public class FuncionarioGetJson
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string Cpf { get; set; }

        public string Nacionalidade { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Sexo { get; set; }

        public string Rg { get; set; }

        public string Cargo { get; set; }

        public string Setor { get; set; }

        public double Salario { get; set; }

        public UsuarioGetJson Usuario { get; set; }

        public ContatosGetJson Contatos { get; set; }

        public EnderecoGetJson Endereco { get; set; }

        public DadosBancariosGetJson DadosBancarios { get; set; }

        public CategoriaAcessoGetJson CategoriaAcesso { get; set; }
    }
}
