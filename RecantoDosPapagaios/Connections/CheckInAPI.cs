using Newtonsoft.Json;
using RecantoDosPapagaios.Entities;
using RestSharp;
using System;

namespace RecantoDosPapagaios.Connections
{
    public class CheckInAPI
    {
        public RetornoAPI PostCheckIn(int idReserva, int idFuncionario)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/CheckIns");
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.POST);
                
                request.AddHeader("Content-Type", "application/json");
                
                var body = @"{
                    " + "\n" +
                                    $@"  ""idReserva"": {idReserva},
                    " + "\n" +
                                    $@"  ""idFuncionario"": {idFuncionario}
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
