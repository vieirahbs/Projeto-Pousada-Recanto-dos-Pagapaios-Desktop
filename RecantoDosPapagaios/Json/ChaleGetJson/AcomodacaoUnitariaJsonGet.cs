using System.Collections.Generic;

namespace RecantoDosPapagaios.Json.ChaleJson
{
    public class AcomodacaoUnitariaJsonGet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public StatusAcomodacaoGetJson StatusAcomodacao { get; set; }
        public InformacoesAcomodacaoGetJson InformacoesAcomodacao { get; set; }
        public CategoriaAcomodacaoGetJson CategoriaAcomodacao { get; set; }
        public List<ReservaResumidaGetJson> ProximasReservas { get; set; }
    }
}
