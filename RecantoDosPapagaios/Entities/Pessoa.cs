using System;

namespace RecantoDosPapagaios.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public UsuarioPessoa Usuario { get; set; }
        public ContatosPessoa Contatos { get; set; }
        public EnderecoPessoa Endereco { get; set; }
    }
}
