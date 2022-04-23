using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using System;

namespace RecantoDosPapagaios.Business
{
    public class CheckInBusiness
    {
        private readonly CheckInAPI _checkInAPI;

        public CheckInBusiness()
        {
            _checkInAPI = new CheckInAPI();
        }

        public RetornoAPI FazerCheckIn(int idReserva, int idFuncionario)
        {
            RetornoAPI retornoAPI;
            
            try
            {
                retornoAPI = _checkInAPI.PostCheckIn(idReserva, idFuncionario);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }


    }
}
