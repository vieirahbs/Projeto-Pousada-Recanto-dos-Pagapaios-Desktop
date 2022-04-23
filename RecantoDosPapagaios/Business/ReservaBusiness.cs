using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using System;
using System.Collections.Generic;

namespace RecantoDosPapagaios.Business
{
    public class ReservaBusiness
    {
        private readonly ReservaAPI _reservaAPI;

        public ReservaBusiness()
        {
            _reservaAPI = new ReservaAPI();
        }

        public List<Reserva> Obter(string cpf)
        {
            List<Reserva> reserva;

            try
            {
                reserva = _reservaAPI.GetPorCpf(cpf);
            }
            catch (Exception)
            {
                throw;
            }

            return reserva;
        }

        public Reserva Get(int idReserva)
        {
            Reserva reserva;

            try
            {
                reserva = _reservaAPI.Get(idReserva);
            }
            catch (Exception)
            {
                throw;
            }

            return reserva;
        }

        public RetornoAPI Inserir(Reserva reserva)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _reservaAPI.PostReserva(reserva);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }

        public RetornoAPI Excluir(int idReserva)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _reservaAPI.Delete(idReserva);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }


    }
}
