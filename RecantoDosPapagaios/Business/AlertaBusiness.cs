using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json.AlertaDeleteJson;
using RecantoDosPapagaios.Json.AlertaGetJson;
using RecantoDosPapagaios.Json.AlertaPostJson;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Business
{
    public class AlertaBusiness
    {
        private readonly AlertaAPI _alertaAPI;

        public AlertaBusiness()
        {
            _alertaAPI = new AlertaAPI();
        }

        public List<AlertaGetJson> Get()
        {
            List<AlertaGetJson> alertas;

            try
            {
                alertas = _alertaAPI.Get();
            }
            catch (Exception)
            {
                throw;
            }

            return alertas;
        }

        public RetornoAPI Post(AlertaPostJson alerta)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _alertaAPI.Post(alerta);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }

        public RetornoAPI Delete(int idAlerta)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _alertaAPI.Delete(idAlerta);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }
    }
}
