using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json.ChaleJson;
using RecantoDosPapagaios.Json.ChalePutJson;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Business
{
    public class ChaleBusiness
    {
        private readonly ChaleAPI _chaleAPI;

        public ChaleBusiness()
        {
            _chaleAPI = new ChaleAPI();
        }

        public List<Acomodacao> Obter()
        {
            List<Acomodacao> acomodacoes;

            try
            {
                acomodacoes = _chaleAPI.Get();
            }
            catch (Exception)
            {
                throw;
            }

            return acomodacoes;
        }

        public AcomodacaoUnitariaJsonGet Obter(int idAcomodacao)
        {
            AcomodacaoUnitariaJsonGet acomodacao;

            try
            {
                acomodacao = _chaleAPI.Get(idAcomodacao);
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
                retornoAPI = _chaleAPI.Put(put);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }
    }
}
