using Newtonsoft.Json;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json.AlertaDeleteJson;
using RecantoDosPapagaios.Json.AlertaGetJson;
using RecantoDosPapagaios.Json.AlertaPostJson;
using RestSharp;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Connections
{
    public class AlertaAPI
    {
        public List<AlertaGetJson> Get()
        {
            #region Request

            List<AlertaGetJson> alertas = null;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Alertas?pagina=1&quantidade=4");
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.GET);
                
                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode == 200)
                    alertas = JsonConvert.DeserializeObject<List<AlertaGetJson>>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            return alertas;

            #endregion Request
        }

        public RetornoAPI Post(AlertaPostJson alerta)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Alertas");
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.POST);
                
                request.AddHeader("Content-Type", "application/json");
                
                var body = @"{
                    " + "\n" +
                                    $@"  ""titulo"": ""{alerta.Titulo}"",
                    " + "\n" +
                                    $@"  ""mensagem"": ""{alerta.Mensagem}"",
                    " + "\n" +
                                    $@"  ""idFuncionario"": {alerta.IdFuncionario}
                    " + "\n" +
                @"}";
                
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                
                IRestResponse response = client.Execute(request);
                
                retornoAPI = JsonConvert.DeserializeObject<RetornoAPI>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;

            #endregion Request
        }

        public RetornoAPI Delete(int idAlerta)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Alertas/" + idAlerta.ToString());

                client.Timeout = -1;

                var request = new RestRequest(Method.DELETE);

                IRestResponse response = client.Execute(request);

                retornoAPI = JsonConvert.DeserializeObject<RetornoAPI>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;

            #endregion Request
        }

    }
}
