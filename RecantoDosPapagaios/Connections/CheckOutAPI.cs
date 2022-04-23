using Newtonsoft.Json;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json;
using RestSharp;
using System;

namespace RecantoDosPapagaios.Connections
{
    public class CheckOutAPI
    {
        public RetornoAPI PostCheckIn(CheckOutPostJson checkOut)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/CheckOuts");
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.POST);
                
                request.AddHeader("Content-Type", "application/json");
                
                var body =
                @"{
                    " + "\n" +
                                    $@"  ""idReserva"": {checkOut.idReserva},
                    " + "\n" +
                                    $@"  ""idFuncionario"": {checkOut.idFuncionario},
                    " + "\n" +
                                    $@"  ""valoresAdicionais"": {checkOut.ValoresAdicionais},
                    " + "\n" +
                                    $@"  ""tipoPagamento"": {checkOut.TipoPagamento},
                    " + "\n" +
                                    $@"  ""valorAdicional"": {checkOut.ValorAdicional}
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

            #endregion Request

            return retornoAPI;
        }
    }
}
