using Newtonsoft.Json;
using RecantoDosPapagaios.CustomExceptions;
using RecantoDosPapagaios.Entities;
using RestSharp;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Connections
{
    public class HospedeAPI
    {
        public Hospede GetHospede(string cpf)
        {
            #region Request

            Hospede hospede;
            
            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Hospedes/" + cpf);
                client.Timeout = -1;

                var request = new RestRequest(Method.GET);

                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode != 200)
                {
                    throw new ErrorException("Hóspede não encontrado ou inválido.");
                }
                else
                {
                    hospede = JsonConvert.DeserializeObject<Hospede>(response.Content);
                }
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return hospede;
        }

        public Hospede GetHospede(int idHospede)
        {
            #region Request

            Hospede hospede;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Hospedes/" + idHospede.ToString());
                client.Timeout = -1;

                var request = new RestRequest(Method.GET);

                IRestResponse response = client.Execute(request);


                if ((int)response.StatusCode != 200)
                {
                    throw new ErrorException("Hóspede não encontrado ou inválido.");
                }
                else
                {
                    hospede = JsonConvert.DeserializeObject<Hospede>(response.Content);
                }
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return hospede;
        }

        public List<Hospede> GetHospedes()
        {
            #region Request

            List<Hospede> hospedes;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Hospedes?pagina=1&quantidade=11");
                client.Timeout = -1;

                var request = new RestRequest(Method.GET);
                
                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode != 200)
                {
                    throw new ErrorException("Hóspede não encontrado ou inválido.");
                }
                else
                {
                    hospedes = JsonConvert.DeserializeObject<List<Hospede>>(response.Content);
                }
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return hospedes;
        }

        public RetornoAPI PostHospedes(Hospede hospede)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Hospedes");
                client.Timeout = -1;

                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                var body =
                @"{
                    " + "\n" +
                                    $@"  ""nomeCompleto"": ""{hospede.NomeCompleto}"",
                    " + "\n" +
                                    $@"  ""cpf"": ""{hospede.Cpf}"",
                    " + "\n" +
                                    $@"  ""dataDeNascimento"": ""{hospede.DataDeNascimento.ToString("u")}"",
                    " + "\n" +
                                    @"  ""usuario"": {
                    " + "\n" +
                                    $@"    ""nomeUsuario"": ""{hospede.Usuario.NomeUsuario}"",
                    " + "\n" +
                                    $@"    ""senhaUsuario"": ""{hospede.Usuario.SenhaUsuario}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""contatos"": {
                    " + "\n" +
                                    $@"    ""email"": ""{hospede.Contatos.Email}"",
                    " + "\n" +
                                    $@"    ""celular"": ""{hospede.Contatos.Celular}"",
                    " + "\n" +
                                    $@"    ""telefone"": ""{hospede.Contatos.Telefone}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""endereco"": {
                    " + "\n" +
                                    $@"    ""cep"": ""{hospede.Endereco.Cep}"",
                    " + "\n" +
                                    $@"    ""logradouro"": ""{hospede.Endereco.Logradouro}"",
                    " + "\n" +
                                    $@"    ""numero"": ""{hospede.Endereco.Numero}"",
                    " + "\n" +
                                    $@"    ""complemento"": ""{hospede.Endereco.Complemento}"",
                    " + "\n" +
                                    $@"    ""bairro"": ""{hospede.Endereco.Bairro}"",
                    " + "\n" +
                                    $@"    ""cidade"": ""{hospede.Endereco.Cidade}"",
                    " + "\n" +
                                    $@"    ""estado"": ""{hospede.Endereco.Estado}"",
                    " + "\n" +
                                    $@"    ""pais"": ""{hospede.Endereco.Pais}""
                    " + "\n" +
                                    @"  }
                    " + "\n" +
                @"}";

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode != 201)
                {
                    throw new ErrorException("Por gentileza, verificar os dados de entrada, pois algum " +
                        "dos campos preenchidos está inválido.");
                }
                else
                {
                    retornoAPI = JsonConvert.DeserializeObject<RetornoAPI>(response.Content);
                }
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return retornoAPI;
        }

        public RetornoAPI PutHospede(Hospede hospede, int id)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Hospedes/" + id.ToString());
                
                client.Timeout = -1;

                var request = new RestRequest(Method.PUT);
                
                request.AddHeader("Content-Type", "application/json");
                
                var body =
                @"{
                    " + "\n" +
                                    $@"  ""nomeCompleto"": ""{hospede.NomeCompleto}"",
                    " + "\n" +
                                    $@"  ""cpf"": ""{hospede.Cpf}"",
                    " + "\n" +
                                    $@"  ""dataDeNascimento"": ""{hospede.DataDeNascimento.ToString("u")}"",
                    " + "\n" +
                                    @"  ""usuario"": {
                    " + "\n" +
                                    $@"    ""nomeUsuario"": ""{hospede.Usuario.NomeUsuario}"",
                    " + "\n" +
                                    $@"    ""senhaUsuario"": ""{hospede.Usuario.SenhaUsuario}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""contatos"": {
                    " + "\n" +
                                    $@"    ""email"": ""{hospede.Contatos.Email}"",
                    " + "\n" +
                                    $@"    ""celular"": ""{hospede.Contatos.Celular}"",
                    " + "\n" +
                                    $@"    ""telefone"": ""{hospede.Contatos.Telefone}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""endereco"": {
                    " + "\n" +
                                    $@"    ""cep"": ""{hospede.Endereco.Cep}"",
                    " + "\n" +
                                    $@"    ""logradouro"": ""{hospede.Endereco.Logradouro}"",
                    " + "\n" +
                                    $@"    ""numero"": ""{hospede.Endereco.Numero}"",
                    " + "\n" +
                                    $@"    ""complemento"": ""{hospede.Endereco.Complemento}"",
                    " + "\n" +
                                    $@"    ""bairro"": ""{hospede.Endereco.Bairro}"",
                    " + "\n" +
                                    $@"    ""cidade"": ""{hospede.Endereco.Cidade}"",
                    " + "\n" +
                                    $@"    ""estado"": ""{hospede.Endereco.Estado}"",
                    " + "\n" +
                                    $@"    ""pais"": ""{hospede.Endereco.Pais}""
                    " + "\n" +
                                    @"  }
                    " + "\n" +
                @"}";

                request.AddParameter("application/json", body, ParameterType.RequestBody);
                
                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode != 200)
                {
                    throw new ErrorException("Por gentileza, verificar os dados de entrada, pois algum " +
                        "dos campos preenchidos está inválido.");
                }
                else
                {
                    retornoAPI = JsonConvert.DeserializeObject<RetornoAPI>(response.Content);
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
