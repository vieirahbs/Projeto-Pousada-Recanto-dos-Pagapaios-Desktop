using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using System;

namespace RecantoDosPapagaios.Business
{
    public class LoginBusiness
    {
        private readonly LoginAPI _loginAPI;

        public LoginBusiness()
        {
            _loginAPI = new LoginAPI();
        }

        public Login FazerLogin(string login, string senha)
        {
            Login retornoAPI;

            try
            {
                retornoAPI = _loginAPI.FazerLogin(login, senha);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }

        public PerguntaDeSeguranca EncontrarConta(string cpf)
        {
            PerguntaDeSeguranca pergunta;

            try
            {
                pergunta = _loginAPI.EncontrarConta(cpf);
            }
            catch (Exception)
            {
                throw;
            }

            return pergunta;
        }

        public RetornoAPI DefinirNovaSenha(DefinirNovaSenha novaSenha)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _loginAPI.DefinirNovaSenha(novaSenha);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }
    }
}
