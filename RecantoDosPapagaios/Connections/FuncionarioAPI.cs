using Newtonsoft.Json;
using RecantoDosPapagaios.CustomExceptions;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Connections
{
    public class FuncionarioAPI
    {
        public List<FuncionarioGetJson> Get()
        {
            #region Request

            List<FuncionarioGetJson> funcionarios;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Funcionarios?pagina=1&quantidade=11");
                client.Timeout = -1;

                var request = new RestRequest(Method.GET);

                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode != 200)
                {
                    throw new ErrorException("Funcionário não encontrado ou inválido.");
                }
                else
                {
                    funcionarios = JsonConvert.DeserializeObject<List<FuncionarioGetJson>>(response.Content);
                }
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return funcionarios;
        }

        public FuncionarioGetJson Get(int idFuncionario)
        {
            #region Request

            FuncionarioGetJson json;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Funcionarios/" + idFuncionario);

                client.Timeout = -1;

                var request = new RestRequest(Method.GET);

                IRestResponse response = client.Execute(request);

                if ((int)response.StatusCode != 200)
                {
                    throw new ErrorException("Funcionário não encontrado ou inválido.");
                }
                else
                {
                    json = JsonConvert.DeserializeObject<FuncionarioGetJson>(response.Content);
                }
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return json;
        }

        public FuncionarioGetJson Get(string cpf)
        {
            #region Request

            FuncionarioGetJson json;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Funcionarios/" + cpf);

                client.Timeout = -1;

                var request = new RestRequest(Method.GET);

                IRestResponse response = client.Execute(request);

                json = JsonConvert.DeserializeObject<FuncionarioGetJson>(response.Content);
            }
            catch (Exception)
            {
                throw;
            }

            #endregion Request

            return json;
        }

        public RetornoAPI PostFuncionario(Funcionario funcionario)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Funcionarios/");

                client.Timeout = -1;

                var request = new RestRequest(Method.POST);

                request.AddHeader("Content-Type", "application/json");

                var body = @"{
                    " + "\n" +
                                    $@"  ""nomeCompleto"": ""{funcionario.NomeCompleto}"",
                    " + "\n" +
                                    $@"  ""cpf"": ""{funcionario.Cpf}"",
                    " + "\n" +
                                    $@"  ""nacionalidade"": ""{funcionario.Nacionalidade}"",
                    " + "\n" +
                                    $@"  ""dataDeNascimento"": ""{funcionario.DataDeNascimento.ToString("u")}"",
                    " + "\n" +
                                    $@"  ""sexo"": ""{funcionario.Sexo}"",
                    " + "\n" +
                                    $@"  ""rg"": ""{funcionario.Rg}"",
                    " + "\n" +
                                    $@"  ""cargo"": ""{funcionario.Cargo}"",
                    " + "\n" +
                                    $@"  ""setor"": ""{funcionario.Setor}"",
                    " + "\n" +
                                    $@"  ""salario"": {funcionario.Salario},
                    " + "\n" +
                                    @"  ""usuario"": {
                    " + "\n" +
                                    $@"    ""nomeUsuario"": ""{funcionario.Usuario.NomeUsuario}"",
                    " + "\n" +
                                    $@"    ""senhaUsuario"": ""{funcionario.Usuario.SenhaUsuario}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""contatos"": {
                    " + "\n" +
                                    $@"    ""email"": ""{funcionario.Contatos.Email}"",
                    " + "\n" +
                                    $@"    ""celular"": ""{funcionario.Contatos.Celular}"",
                    " + "\n" +
                                    $@"    ""telefone"": ""{funcionario.Contatos.Telefone}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""endereco"": {
                    " + "\n" +
                                    $@"    ""cep"": ""{funcionario.Endereco.Cep}"",
                    " + "\n" +
                                    $@"    ""logradouro"": ""{funcionario.Endereco.Logradouro}"",
                    " + "\n" +
                                    $@"    ""numero"": ""{funcionario.Endereco.Numero}"",
                    " + "\n" +
                                    $@"    ""complemento"": ""{funcionario.Endereco.Complemento}"",
                    " + "\n" +
                                    $@"    ""bairro"": ""{funcionario.Endereco.Bairro}"",
                    " + "\n" +
                                    $@"    ""cidade"": ""{funcionario.Endereco.Cidade}"",
                    " + "\n" +
                                    $@"    ""estado"": ""{funcionario.Endereco.Estado}"",
                    " + "\n" +
                                    $@"    ""pais"": ""{funcionario.Endereco.Pais}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""dadosBancarios"": {
                    " + "\n" +
                                    $@"    ""banco"": ""{funcionario.DadosBancarios.Banco}"",
                    " + "\n" +
                                    $@"    ""agencia"": ""{funcionario.DadosBancarios.Agencia}"",
                    " + "\n" +
                                    $@"    ""numeroDaConta"": ""{funcionario.DadosBancarios.NumeroDaConta}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""categoriaAcesso"": {
                    " + "\n" +
                                    $@"    ""id"": {funcionario.CategoriaAcesso.Id}
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""perguntaDeSeguranca"": {
                    " + "\n" +
                                    $@"    ""perguntaSeguranca"": ""{funcionario.PerguntaDeSeguranca.PerguntaSeguranca}"",
                    " + "\n" +
                                    $@"    ""respostaSeguranca"": ""{funcionario.PerguntaDeSeguranca.RespostaSeguranca}""
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

        public RetornoAPI PutFuncionario(Funcionario funcionario, int idFuncionario)
        {
            #region Request

            RetornoAPI retornoAPI;

            try
            {
                var client = new RestClient("https://localhost:44398/api/V1/Funcionarios/" + idFuncionario.ToString());

                client.Timeout = -1;

                var request = new RestRequest(Method.PUT);

                request.AddHeader("Content-Type", "application/json");

                var body = @"{
                    " + "\n" +
                                    $@"  ""nomeCompleto"": ""{funcionario.NomeCompleto}"",
                    " + "\n" +
                                    $@"  ""cpf"": ""{funcionario.Cpf}"",
                    " + "\n" +
                                    $@"  ""nacionalidade"": ""{funcionario.Nacionalidade}"",
                    " + "\n" +
                                    $@"  ""dataDeNascimento"": ""{funcionario.DataDeNascimento.ToString("u")}"",
                    " + "\n" +
                                    $@"  ""sexo"": ""{funcionario.Sexo}"",
                    " + "\n" +
                                    $@"  ""rg"": ""{funcionario.Rg}"",
                    " + "\n" +
                                    $@"  ""cargo"": ""{funcionario.Cargo}"",
                    " + "\n" +
                                    $@"  ""setor"": ""{funcionario.Setor}"",
                    " + "\n" +
                                    $@"  ""salario"": {funcionario.Salario},
                    " + "\n" +
                                    @"  ""usuario"": {
                    " + "\n" +
                                    $@"    ""nomeUsuario"": ""{funcionario.Usuario.NomeUsuario}"",
                    " + "\n" +
                                    $@"    ""senhaUsuario"": ""{funcionario.Usuario.SenhaUsuario}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""contatos"": {
                    " + "\n" +
                                    $@"    ""email"": ""{funcionario.Contatos.Email}"",
                    " + "\n" +
                                    $@"    ""celular"": ""{funcionario.Contatos.Celular}"",
                    " + "\n" +
                                    $@"    ""telefone"": ""{funcionario.Contatos.Telefone}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""endereco"": {
                    " + "\n" +
                                    $@"    ""cep"": ""{funcionario.Endereco.Cep}"",
                    " + "\n" +
                                    $@"    ""logradouro"": ""{funcionario.Endereco.Logradouro}"",
                    " + "\n" +
                                    $@"    ""numero"": ""{funcionario.Endereco.Numero}"",
                    " + "\n" +
                                    $@"    ""complemento"": ""{funcionario.Endereco.Complemento}"",
                    " + "\n" +
                                    $@"    ""bairro"": ""{funcionario.Endereco.Bairro}"",
                    " + "\n" +
                                    $@"    ""cidade"": ""{funcionario.Endereco.Cidade}"",
                    " + "\n" +
                                    $@"    ""estado"": ""{funcionario.Endereco.Estado}"",
                    " + "\n" +
                                    $@"    ""pais"": ""{funcionario.Endereco.Pais}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""dadosBancarios"": {
                    " + "\n" +
                                    $@"    ""banco"": ""{funcionario.DadosBancarios.Banco}"",
                    " + "\n" +
                                    $@"    ""agencia"": ""{funcionario.DadosBancarios.Agencia}"",
                    " + "\n" +
                                    $@"    ""numeroDaConta"": ""{funcionario.DadosBancarios.NumeroDaConta}""
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""categoriaAcesso"": {
                    " + "\n" +
                                    $@"    ""id"": {funcionario.CategoriaAcesso.Id}
                    " + "\n" +
                                    @"  },
                    " + "\n" +
                                    @"  ""perguntaDeSeguranca"": {
                    " + "\n" +
                                    $@"    ""perguntaSeguranca"": ""{funcionario.PerguntaDeSeguranca.PerguntaSeguranca}"",
                    " + "\n" +
                                    $@"    ""respostaSeguranca"": ""{funcionario.PerguntaDeSeguranca.RespostaSeguranca}""
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
