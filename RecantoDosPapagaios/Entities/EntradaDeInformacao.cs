using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecantoDosPapagaios.Entities
{
    class EntradaDeInformacao
    {
        public void AdicionarInformacoesHospede()
        {
            //Teste para adicionar hóspedes à lista de hóspedes (lstHospede):
            Hospede hospede = new Hospede(1234, "Alessandro Penezzi", "11122233344");
            hospede.AdicionarNaLista(hospede);
            Hospede hospede2 = new Hospede(1235, "Yamandu Costa", "22233344455");
            hospede.AdicionarNaLista(hospede2);
            Hospede hospede3 = new Hospede(1236, "Nelson Faria", "33344455566");
            hospede.AdicionarNaLista(hospede3);
            Hospede hospede4 = new Hospede(1236, "Gustavo Guerra", "55112445565");
            hospede.AdicionarNaLista(hospede4);
            Hospede hospede5 = new Hospede(1236, "Eduardo Ardanuy", "11224433445");
            hospede.AdicionarNaLista(hospede5);
        }
    }
}
