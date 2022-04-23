namespace RecantoDosPapagaios.Json.AlertaGetJson
{
    public class AlertaGetJson
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Mensagem { get; set; }

        public FuncionarioAlertaGetJson Funcionario { get; set; }
    }
}
