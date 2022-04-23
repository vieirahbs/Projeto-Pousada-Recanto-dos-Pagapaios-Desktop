using RecantoDosPapagaios.Connections;
using RecantoDosPapagaios.Entities;
using System;

namespace RecantoDosPapagaios.Business
{
    public class FNRHBusiness
    {
        private readonly FNRHAPI _fnrhAPI;

        public FNRHBusiness()
        {
            _fnrhAPI = new FNRHAPI();
        }

        //public RetornoAPI Inserir(FNRH fnrh, int idHospede)
        //{
        //    RetornoAPI retornoAPI;

        //    try
        //    {
        //        retornoAPI = _fnrhAPI.PostFNRH(fnrh, idHospede);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return retornoAPI;
        //}

        public RetornoAPI Inserir(FNRH fnrh, int id)
        {
            RetornoAPI retornoAPI;

            try
            {
                retornoAPI = _fnrhAPI.PostFNRH(fnrh, id);
            }
            catch (Exception)
            {
                throw;
            }

            return retornoAPI;
        }
    }
}
