using Newtonsoft.Json;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json.ChaleJson;
using RecantoDosPapagaios.Json.ChalePutJson;
using RestSharp;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Connections
{
    public class ChaleAPI
    {
        public List<Acomodacao> Get()
        {
            List<Acomodacao> acomodacaos;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Acomodacoes");
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.GET);
                
                var body = @"";
                
                request.AddParameter("text/plain", body, ParameterType.RequestBody);
                
                IRestResponse response = client.Execute(request);

                acomodacaos = JsonConvert.DeserializeObject<List<Acomodacao>>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            return acomodacaos;
        }

        public AcomodacaoUnitariaJsonGet Get(int id)
        {
            AcomodacaoUnitariaJsonGet acomodacao;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Acomodacoes/" + id.ToString());
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.GET);
                
                IRestResponse response = client.Execute(request);
                
                acomodacao = JsonConvert.DeserializeObject<AcomodacaoUnitariaJsonGet>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            return acomodacao;
        }

        public RetornoAPI Put(ChalePutJson put)
        {
            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Acomodacoes");
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.PUT);
                
                request.AddHeader("Content-Type", "application/json");
                
                var body = @"{
                    " + "\n" +
                                    $@"    ""IdAcomodacao"": {put.IdAcomodacao},
                    " + "\n" +
                                    $@"    ""Nome"": ""{put.Nome}"",
                    " + "\n" +
                                    @"    ""Categoria"": {
                    " + "\n" +
                                    $@"        ""Id"": {put.Categoria},
                    " + "\n" +
                                    @"        ""Descricao"": ""string""
                    " + "\n" +
                                    @"    },
                    " + "\n" +
                                    @"    ""InformacoesAcomodacao"": {
                    " + "\n" +
                                    $@"        ""Capacidade"": {put.Capacidade},
                    " + "\n" +
                                    $@"        ""Tamanho"": {put.Tamanho},
                    " + "\n" +
                                    $@"        ""TipoDeCama"": ""{put.TipoDeCama}"",
                    " + "\n" +
                                    $@"        ""Preco"": {put.Preco}
                    " + "\n" +
                                    @"    }
                    " + "\n" +
                @"}";
                
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                
                IRestResponse response = client.Execute(request);
                
                if ((int)response.StatusCode == 404)
                {
                    retornoAPI = new RetornoAPI
                    {
                        StatusCode = (int)response.StatusCode,
                        Mensagem = "O chalé informado não foi encontrado."
                    };
                }
                else
                {
                    retornoAPI = JsonConvert.DeserializeObject<RetornoAPI>(response.Content);
                }

                return retornoAPI;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
