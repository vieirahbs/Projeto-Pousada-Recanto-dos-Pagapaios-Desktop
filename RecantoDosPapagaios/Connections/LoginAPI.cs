using Newtonsoft.Json;
using RecantoDosPapagaios.Entities;
using RestSharp;
using System;

namespace RecantoDosPapagaios.Connections
{
    public class LoginAPI
    {
        public Login FazerLogin(string login, string senha)
        {
            #region Request

            Login retorno;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Logins");
                client.Timeout = -1;

                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                var body =
                @"{
                " + "\n" +
                                $@"  ""nomeUsuario"": ""{login}"",
                " + "\n" +
                                $@"  ""senhaUsuario"": ""{senha}""
                " + "\n" +
                @"}";

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                retorno = JsonConvert.DeserializeObject<Login>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return retorno;
        }

        public PerguntaDeSeguranca EncontrarConta(string cpf)
        {
            #region Request

            PerguntaDeSeguranca perguntaDeSeguranca;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Logins/" + cpf);
                client.Timeout = -1;

                var request = new RestRequest(Method.GET);

                IRestResponse response = client.Execute(request);

                perguntaDeSeguranca = JsonConvert.DeserializeObject<PerguntaDeSeguranca>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return perguntaDeSeguranca;
        }

        public RetornoAPI DefinirNovaSenha(DefinirNovaSenha definirNovaSenha)
        {
            #region Request

            RetornoAPI retorno;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Logins");
                client.Timeout = -1;

                var request = new RestRequest(Method.PUT);
                request.AddHeader("Content-Type", "application/json");

                var body =
                @"{
                " + "\n" +
                                $@"  ""cpf"": ""{definirNovaSenha.Cpf}"",
                " + "\n" +
                                $@"  ""novaSenha"": ""{definirNovaSenha.NovaSenha}"",
                " + "\n" +
                                $@"  ""repeticaoSenha"": ""{definirNovaSenha.RepeticaoSenha}""
                " + "\n" +
                @"}";

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                retorno = JsonConvert.DeserializeObject<RetornoAPI>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return retorno;
        }
    }
}
