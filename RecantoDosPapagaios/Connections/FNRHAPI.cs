using Newtonsoft.Json;
using RecantoDosPapagaios.Entities;
using RestSharp;
using System;

namespace RecantoDosPapagaios.Connections
{
    public class FNRHAPI
    {
        public RetornoAPI PostFNRH(FNRH fnrh, int id)
        {
            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/FNRHs/" + id.ToString());

                client.Timeout = -1;

                var request = new RestRequest(Method.POST);

                request.AddHeader("Content-Type", "application/json");

                var body = @"{
                    " + "\n" +
                                    $@"  ""profissao"": ""{fnrh.Profissao}"",
                    " + "\n" +
                                    $@"  ""nacionalidade"": ""{fnrh.Nacionalidade}"",
                    " + "\n" +
                                    $@"  ""sexo"": ""{fnrh.Sexo}"",
                    " + "\n" +
                                    $@"  ""rg"": ""{fnrh.Rg}"",
                    " + "\n" +
                                    $@"  ""ultimoDestino"": ""{fnrh.UltimoDestino}"",
                    " + "\n" +
                                    $@"  ""proximoDestino"": ""{fnrh.ProximoDestino}"",
                    " + "\n" +
                                    $@"  ""motivoViagem"": ""{fnrh.MotivoViagem}"",
                    " + "\n" +
                                    $@"  ""meioDeTransporte"": ""{fnrh.MeioDeTransporte}"",
                    " + "\n" +
                                    $@"  ""placaAutomovel"": ""{fnrh.PlacaAutomovel}"",
                    " + "\n" +
                                    $@"  ""numAcompanhantes"": {fnrh.NumAcompanhantes}
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
        }
    }
}
