using System;

namespace RecantoDosPapagaios.Json.ChaleJson
{
    public class ReservaResumidaGetJson
    {
        public int idReserva { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public HospedeReservaGetJson Hospede { get; set; }
    }
}
