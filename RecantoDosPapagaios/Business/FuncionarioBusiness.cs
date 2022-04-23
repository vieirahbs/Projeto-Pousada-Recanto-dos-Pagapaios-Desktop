using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Business
{
    public class FuncionarioBusiness
    {
        private readonly FuncionarioAPI _funcionarioAPI;

        public FuncionarioBusiness()
        {
            _funcionarioAPI = new FuncionarioAPI();
        }

        public List<FuncionarioGetJson> Obter()
        {
            List<FuncionarioGetJson> funcionariosJson;

            try
            {
                funcionariosJson = _funcionarioAPI.Get();
            }
            catch (Exception)
            {
                throw;
            }

            return funcionariosJson;
        }

        public FuncionarioGetJson Obter(int id)
        {
            FuncionarioGetJson funcionarioJson;

            try
            {
                funcionarioJson = _funcionarioAPI.Get(id);
            }
            catch (Exception)
            {
                throw;
            }

            return funcionarioJson;
        }

        public FuncionarioGetJson Obter(string cpf)
        {
            FuncionarioGetJson funcionarioJson;

            try
            {
                funcionarioJson = _funcionarioAPI.Get(cpf);
            }
            catch (Exception)
            {
                throw;
            }

            return funcionarioJson;
        }

        public RetornoAPI Inserir(Funcionario funcionario)
        {
            try
            {
                return _funcionarioAPI.PostFuncionario(funcionario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public RetornoAPI Atualizar(Funcionario funcionario, int id)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _funcionarioAPI.PutFuncionario(funcionario, id);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }
    }
}
