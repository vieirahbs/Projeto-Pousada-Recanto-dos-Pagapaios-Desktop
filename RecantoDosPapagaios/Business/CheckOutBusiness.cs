using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json;
using System;

namespace RecantoDosPapagaios.Business
{
    public class CheckOutBusiness
    {
        private readonly CheckOutAPI _checkOutAPI;

        public CheckOutBusiness()
        {
            _checkOutAPI = new CheckOutAPI();
        }

        public RetornoAPI PostCheckOut(CheckOutPostJson checkOut)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _checkOutAPI.PostCheckIn(checkOut);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }
    }
}
