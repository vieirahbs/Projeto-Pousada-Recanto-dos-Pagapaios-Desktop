using Newtonsoft.Json;
using RecantoDosPapagaios.CustomExceptions;
using RecantoDosPapagaios.Entities;
using RestSharp;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Connections
{
    public class ReservaAPI
    {
        public List<Reserva> GetPorCpf(string cpf)
        {
            #region Request

            List<Reserva> reserva = null;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Reservas/" + cpf);
                
                client.Timeout = -1;
                
                var request = new RestRequest(Method.GET);
                
                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode == 200)
                    reserva = JsonConvert.DeserializeObject<List<Reserva>>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return reserva;
        }

        public Reserva Get(int idReserva)
        {
            #region Request

            Reserva reserva;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Reservas/" + idReserva.ToString());

                client.Timeout = -1;

                var request = new RestRequest(Method.GET);

                IRestResponse response = client.Execute(request);

                reserva = JsonConvert.DeserializeObject<Reserva>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return reserva;
        }

        public RetornoAPI PostReserva(Reserva reserva)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Reservas");

                client.Timeout = -1;
                
                var request = new RestRequest(Method.POST);
                
                request.AddHeader("Content-Type", "application/json");
                
                var body = @"{
                    " + "\n" +
                                    $@"  ""idHospede"": {reserva.Hospede.Id},
                    " + "\n" +
                                    $@"  ""idAcomodacao"": {reserva.Acomodacao.Id},
                    " + "\n" +
                                    $@"  ""idPagamento"": {reserva.Pagamento.TipoPagamento.Id},
                    " + "\n" +
                                    $@"  ""dataCheckIn"": ""{reserva.DataCheckIn.ToString("u")}"",
                    " + "\n" +
                                    $@"  ""dataCheckOut"": ""{reserva.DataCheckOut.ToString("u")}"",
                    " + "\n" +
                                    $@"  ""acompanhantes"": {reserva.Acompanhantes}
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

        public RetornoAPI Delete(int idReserva)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Reservas/" + idReserva.ToString());

                client.Timeout = -1;

                var request = new RestRequest(Method.DELETE);

                IRestResponse response = client.Execute(request);

                retornoAPI = JsonConvert.DeserializeObject<RetornoAPI>(response.Content);

                if ((int)response.StatusCode != 200)
                {
                    throw new ErrorException("Reserva inválida, inexistente ou inválida para cancelamento.");
                }

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
