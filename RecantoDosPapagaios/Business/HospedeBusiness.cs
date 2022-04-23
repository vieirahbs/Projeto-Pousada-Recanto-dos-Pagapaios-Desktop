using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Business
{
    public class HospedeBusiness
    {
        private readonly HospedeAPI _hospedeAPI;

        public HospedeBusiness()
        {
            _hospedeAPI = new HospedeAPI();
        }

        public Hospede Obter(string cpf)
        {
            Hospede hospede;

            try
            {
                hospede = _hospedeAPI.GetHospede(cpf);
            }
            catch (Exception)
            {
                throw;
            }

            return hospede;
        }

        public Hospede Obter(int idHospede)
        {
            Hospede hospede;

            try
            {
                hospede = _hospedeAPI.GetHospede(idHospede);
            }
            catch (Exception)
            {
                throw;
            }

            return hospede;
        }

        public List<Hospede> Obter()
        {
            List<Hospede> hospedes;

            try
            {
                hospedes = _hospedeAPI.GetHospedes();
            }
            catch (Exception)
            {
                throw;
            }

            return hospedes;
        }

        public RetornoAPI Inserir(Hospede hospede)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _hospedeAPI.PostHospedes(hospede);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }

        public RetornoAPI Atualizar(Hospede hospede, int id)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _hospedeAPI.PutHospede(hospede, id);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }
    }
}
