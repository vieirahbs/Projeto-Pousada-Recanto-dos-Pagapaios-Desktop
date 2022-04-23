using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecantoDosPapagaios.Entities
{
    class AdicionaInformacoes
    {
        //Adiciona informações de chale
        #region
        public List<Chale> AddChale()
        {
            ChaleStatus status = new ChaleStatus();

            Chale chale = new Chale();
            
            Chale chale1 = new Chale(1, "Chalé 1 (Standard)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale1, 4, 35.0,
                "Double", 100.0);
            RetornaCategoriaChale(chale1);
            chale.ListaChales.Add(chale1);

            Chale chale2 = new Chale(2, "Chalé 2 (Standard)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale2, 4, 35.0, 
                "Double", 100.0);
            RetornaCategoriaChale(chale2);
            chale.ListaChales.Add(chale2);

            Chale chale3 = new Chale(3, "Chalé 3 (Standard)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale3, 4, 35.0, 
                "Double", 100.0);
            RetornaCategoriaChale(chale3);
            chale.ListaChales.Add(chale3);

            Chale chale4 = new Chale(4, "Chalé 4 (Standard)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale4, 4, 35.0, 
                "Double", 100.0);
            RetornaCategoriaChale(chale4);
            chale.ListaChales.Add(chale4);

            Chale chale5 = new Chale(5, "Chalé 5 (Standard)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale5, 4, 35.0, 
                "Double", 100.0);
            RetornaCategoriaChale(chale5);
            chale.ListaChales.Add(chale5);

            Chale chale6 = new Chale(6, "Chalé 6 (Standard)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale6, 4, 35.0, 
                "Double", 100.0);
            RetornaCategoriaChale(chale6);
            chale.ListaChales.Add(chale6);

            Chale chale7 = new Chale( 7, "Chalé 7 (Superior)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale7, 3, 40.0, 
                "Double", 150.0);
            RetornaCategoriaChale(chale7);
            chale.ListaChales.Add(chale7);

            Chale chale8 = new Chale(8, "Chalé 8 (Superior)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale8, 3, 40.0, "Double", 150.0);
            RetornaCategoriaChale(chale8);
            chale.ListaChales.Add(chale8);

            Chale chale9 = new Chale(9, "Chalé 9 (Master)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale9, 3, 45.0, "Double", 200.0);
            RetornaCategoriaChale(chale9);
            chale.ListaChales.Add(chale9);

            Chale chale10 = new Chale(10, "Chalé 10 (Master)", 
                global::RecantoDosPapagaios.Properties.Resources.Chale10, 3, 45.0, "Double", 200.0);
            RetornaCategoriaChale(chale10);
            chale.ListaChales.Add(chale10);

            return chale.ListaChales;
        }        

        private void RetornaCategoriaChale(Chale chale)
        {
            int i = 1;
            foreach (Chale item in chale.ListaChales)
            {
                if (item.Id == i)
                {
                    if (i <= 6)
                    {
                        chale.Categoria = "Standard";
                    }
                    else if (i <= 8)
                    {
                        chale.Categoria = "Superior";
                    }
                    else
                    {
                        chale.Categoria = "Master";
                    }
                }
                i++;
            }
        }

        #endregion

        //Adiciona informações de funcionários
        #region
        public List<EnderecoFuncionario> AdicionaEnderecoFuncionario()
        {
            EnderecoFuncionario endereco = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco);

            EnderecoFuncionario endereco2 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco2);

            EnderecoFuncionario endereco3 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco3);

            EnderecoFuncionario endereco4 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco4);

            EnderecoFuncionario endereco5 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco5);

            EnderecoFuncionario endereco6 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco6);

            EnderecoFuncionario endereco7 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco7);

            EnderecoFuncionario endereco8 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco8);

            EnderecoFuncionario endereco9 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco9);

            EnderecoFuncionario endereco10 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco10);

            EnderecoFuncionario endereco11 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco11);

            EnderecoFuncionario endereco12 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco12);

            EnderecoFuncionario endereco13 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco13);

            EnderecoFuncionario endereco14 = new EnderecoFuncionario("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco14);

            return endereco.ListaEnderecoFuncionario;
        }

        public void /*List<Funcionario>*/ AdicionaFuncionario()
        {
            //List<EnderecoFuncionario> listEndFunc = AdicionaEnderecoFuncionario();

            //Funcionario funcionario1 = new Funcionario("João da Silva", "js@gmail.com",
            //    "Socio", "11111111111", DateTime.Parse("05/05/1989"), listEndFunc[0]);
            //RetornaIDFuncionario(funcionario1);
            //funcionario1.AdicionaFuncionarioALista(funcionario1);

            //Funcionario funcionario2 = new Funcionario("Diego Santos", "ds@gmail.com",
            //    "Socio", "22222222222", DateTime.Parse("05/05/1989"), listEndFunc[1]);
            //RetornaIDFuncionario(funcionario2);
            //funcionario1.AdicionaFuncionarioALista(funcionario2);

            //Funcionario funcionario3 = new Funcionario("Maria Souza", "ms@gmail.com",
            //    "Diretor", "33333333333", DateTime.Parse("05/05/1989"), listEndFunc[2]);
            //RetornaIDFuncionario(funcionario3);
            //funcionario1.AdicionaFuncionarioALista(funcionario3);

            //Funcionario funcionario4 = new Funcionario("Ricardo Vieira", "rv@gmail.com",
            //    "Gerente Contábil", "44444444444", DateTime.Parse("05/05/1989"), listEndFunc[3]);
            //RetornaIDFuncionario(funcionario4);
            //funcionario1.AdicionaFuncionarioALista(funcionario4);

            //Funcionario funcionario5 = new Funcionario("Ana Maria", "am@gmail.com",
            //    "Gerente de RH", "55555555555", DateTime.Parse("05/05/1989"), listEndFunc[4]);
            //RetornaIDFuncionario(funcionario5);
            //funcionario1.AdicionaFuncionarioALista(funcionario5);

            //Funcionario funcionario6 = new Funcionario("Caroline Santos", "cb@gmail.com",
            //    "Assistente de RH", "66666666666", DateTime.Parse("05/05/1989"), listEndFunc[5]);
            //RetornaIDFuncionario(funcionario6);
            //funcionario1.AdicionaFuncionarioALista(funcionario6);

            //Funcionario funcionario7 = new Funcionario("Lucas Moreira", "cm@gmail.com",
            //    "Recepcionista", "77777777777", DateTime.Parse("05/05/1989"), listEndFunc[6]);
            //RetornaIDFuncionario(funcionario7);
            //funcionario1.AdicionaFuncionarioALista(funcionario7);

            //Funcionario funcionario8 = new Funcionario("Patricia Aparecida", "pa@gmail.com",
            //    "Recepcionista", "88888888888", DateTime.Parse("05/05/1989"), listEndFunc[6]);
            //funcionario1.AdicionaFuncionarioALista(funcionario8);

            //Funcionario funcionario9 = new Funcionario("Luciana Bitencourt", "lb@gmail.com",
            //    "Auxiliar de limpeza", "99999999999", DateTime.Parse("05/05/1989"), listEndFunc[8]);
            //RetornaIDFuncionario(funcionario9);
            //funcionario1.AdicionaFuncionarioALista(funcionario9);

            //Funcionario funcionario10 = new Funcionario("Juliana Machado", "ca@gmail.com",
            //    "Camareira", "21111111111", DateTime.Parse("05/05/1989"), listEndFunc[9]);
            //RetornaIDFuncionario(funcionario10);
            //funcionario1.AdicionaFuncionarioALista(funcionario10);

            //Funcionario funcionario11 = new Funcionario("Renato Augusto", "ra@gmail.com",
            //    "Mensageiro", "31111111111", DateTime.Parse("05/05/1989"), listEndFunc[10]);
            //RetornaIDFuncionario(funcionario11);
            //funcionario1.AdicionaFuncionarioALista(funcionario11);

            //Funcionario funcionario12 = new Funcionario("Julio Alves", "ja@gmail.com",
            //    "Cozinheiro", "41111111111", DateTime.Parse("05/05/1989"), listEndFunc[11]);
            //RetornaIDFuncionario(funcionario12);
            //funcionario1.AdicionaFuncionarioALista(funcionario12);

            //Funcionario funcionario13 = new Funcionario("Rogerio Nascimento", "rn@gmail.com",
            //    "Garçom", "51111111111", DateTime.Parse("05/05/1989"), listEndFunc[12]);
            //RetornaIDFuncionario(funcionario13);
            //funcionario1.AdicionaFuncionarioALista(funcionario13);

            //Funcionario funcionario14 = new Funcionario("Caique Araujo", "jm@gmail.com",
            //    "Garçom", "61111111111", DateTime.Parse("05/05/1989"), listEndFunc[13]);
            //RetornaIDFuncionario(funcionario14);
            //funcionario1.AdicionaFuncionarioALista(funcionario14);

            //return funcionario1.ListaFuncionario;
        }

        public int F = 1;
        private void RetornaIDFuncionario(Funcionario funcionario)
        {
            //funcionario.ID = 04700 + F; 
            F++;
        }
        #endregion     

        //Adiciona informações de hospede
        #region
        public List<EnderecoHospede> AdicionaEnderecoHospede()
        {
            EnderecoHospede endereco = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco);

            EnderecoHospede endereco2 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco2);

            EnderecoHospede endereco3 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco3);

            EnderecoHospede endereco4 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco4);

            EnderecoHospede endereco5 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco5);

            EnderecoHospede endereco6 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco6);

            EnderecoHospede endereco7 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco7);

            EnderecoHospede endereco8 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco8);

            EnderecoHospede endereco9 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco9);

            EnderecoHospede endereco10 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco9);

            EnderecoHospede endereco11 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco9);

            EnderecoHospede endereco12 = new EnderecoHospede("12345678",
                "Rua Quarunas", "15", "Casa", "Vila Rui Barbosa", "São Paulo",
                "SP", "Brasil");
            endereco.AdicionaEndereco(endereco9);

            return endereco.ListaEndereco;
        } 
        
        public void /*List<Hospede>*/ AdicionaHospede()
        {
            //List<EnderecoHospede> endereco = AdicionaEnderecoHospede();

            //Hospede hospede1 = new Hospede("Alessandro Penezzi", "11111111112",
            //    "ap@gmail.com", DateTime.Parse("05/05/1985"), endereco[0]);
            //RetornaIDHospede(hospede1);
            //hospede1.AdicionaHospedeALista(hospede1);

            //Hospede hospede2 = new Hospede("Yamandu Costa", "11111111113",
            //    "yc@gmail.com", DateTime.Parse("05/05/1985"), endereco[1]);
            //RetornaIDHospede(hospede2);
            //hospede1.AdicionaHospedeALista(hospede2);

            //Hospede hospede3 = new Hospede("Nelson Faria", "11111111114",
            //    "nf@gmail.com", DateTime.Parse("05/05/1985"), endereco[2]);
            //RetornaIDHospede(hospede3);
            //hospede1.AdicionaHospedeALista(hospede3);

            //Hospede hospede4 = new Hospede("Gustavo Guerra", "11111111115",
            //    "gg@gmail.com", DateTime.Parse("05/05/1985"), endereco[3]);
            //RetornaIDHospede(hospede4);
            //hospede1.AdicionaHospedeALista(hospede4);

            //Hospede hospede5 = new Hospede("Eduardo Ardanuy", "11111111117",
            //    "ea@gmail.com", DateTime.Parse("05/05/1985"), endereco[4]);
            //RetornaIDHospede(hospede5);
            //hospede1.AdicionaHospedeALista(hospede5);

            //Hospede hospede6 = new Hospede("Marcus Miller", "11111111118",
            //    "mm@gmail.com", DateTime.Parse("05/05/1985"), endereco[5]);
            //RetornaIDHospede(hospede6);
            //hospede1.AdicionaHospedeALista(hospede6);

            //Hospede hospede7 = new Hospede("Victor Wooten", "11111111119",
            //    "vw@gmail.com", DateTime.Parse("05/05/1985"), endereco[6]);
            //RetornaIDHospede(hospede7);
            //hospede1.AdicionaHospedeALista(hospede7);

            //Hospede hospede8 = new Hospede("Marcelo Barbosa", "11111111220",
            //    "mb@gmail.com", DateTime.Parse("05/05/1985"), endereco[7]);
            //RetornaIDHospede(hospede8);
            //hospede1.AdicionaHospedeALista(hospede8);

            //Hospede hospede9 = new Hospede("Patricia Santos", "1111111230",
            //    "ps@gmail.com", DateTime.Parse("05/05/1985"), endereco[8]);
            //RetornaIDHospede(hospede9);
            //hospede1.AdicionaHospedeALista(hospede9);

            //Hospede hospede10 = new Hospede("Rafaela Costa", "11111111240",
            //    "rc@gmail.com", DateTime.Parse("05/05/1985"), endereco[9]);
            //RetornaIDHospede(hospede10);
            //hospede1.AdicionaHospedeALista(hospede10);

            //Hospede hospede11 = new Hospede("Letícia Vasconcelos", "11111111250",
            //    "lv@gmail.com", DateTime.Parse("05/05/1985"), endereco[10]);
            //RetornaIDHospede(hospede11);
            //hospede1.AdicionaHospedeALista(hospede11);

            //Hospede hospede12 = new Hospede("Joana Lima", "11111111260",
            //    "jl@gmail.com", DateTime.Parse("05/05/1985"), endereco[11]);
            //RetornaIDHospede(hospede12);
            //hospede1.AdicionaHospedeALista(hospede12);

            //return hospede1.ListaHospede;
        }

        public int N = 1;        
        private void RetornaIDHospede(Hospede hospede)
        {
            //hospede.ID = 20210 + N;
            //N++;
        }
        #endregion

        //Adiciona informações de reserva
        #region
        public void/*List<Reserva>*/ AdicionaReserva()
        {
            ////List<Hospede> listHospede = AdicionaHospede();
            //List<Chale> listChale = AddChale();

            //Reserva reserva1 = new Reserva(listHospede[0], listChale[0], 4,
            //DateTime.Parse("30/09/2021"), DateTime.Parse("05/10/2021"), true, true, false);
            //RetornaCódigoReserva(reserva1);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva1);
            //reserva1.CalculaValorTotal(reserva1);
            //reserva1.ListaReserva.Add(reserva1);            

            //Reserva reserva2 = new Reserva(listHospede[1], listChale[2], 2,
            //DateTime.Parse("01/10/2021"), DateTime.Parse("09/10/2021"), true, false, false);
            //RetornaCódigoReserva(reserva2);
            //reserva1.CalculaValorTotal(reserva2);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva2);
            //reserva1.ListaReserva.Add(reserva2);

            //Reserva reserva3 = new Reserva(listHospede[2], listChale[7], 3,
            //DateTime.Parse("25/09/2021"), DateTime.Parse("27/09/2021"), true, true, false);
            //RetornaCódigoReserva(reserva3);
            //reserva1.CalculaValorTotal(reserva3);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva3);
            //reserva1.ListaReserva.Add(reserva3);

            //Reserva reserva4 = new Reserva(listHospede[3], listChale[9], 2,
            //DateTime.Parse("27/09/2021"), DateTime.Parse("05/10/2021"), true, true, false);
            //RetornaCódigoReserva(reserva4);
            //reserva1.CalculaValorTotal(reserva4);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva4);
            //reserva1.ListaReserva.Add(reserva4);

            //Reserva reserva5 = new Reserva(listHospede[4], listChale[3], 2,
            //DateTime.Parse("03/10/2021"), DateTime.Parse("07/10/2021"), true, false, false);
            //RetornaCódigoReserva(reserva5);
            //reserva1.CalculaValorTotal(reserva5);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva5);
            //reserva1.ListaReserva.Add(reserva5);

            //Reserva reserva6 = new Reserva(listHospede[5], listChale[8], 2,
            //DateTime.Parse("01/10/2021"), DateTime.Parse("13/10/2021"), true, false, false);
            //RetornaCódigoReserva(reserva6);
            //reserva1.CalculaValorTotal(reserva6);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva6);
            //reserva1.ListaReserva.Add(reserva6);

            //Reserva reserva7 = new Reserva(listHospede[6], listChale[4], 2,
            //DateTime.Parse("25/09/2021"), DateTime.Parse("29/09/2021"), true, true, false);
            //RetornaCódigoReserva(reserva7);
            //reserva1.CalculaValorTotal(reserva7);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva7);
            //reserva1.ListaReserva.Add(reserva7);
            

            //Reserva reserva8 = new Reserva(listHospede[7], listChale[1], 2,
            //DateTime.Parse("29/09/2021"), DateTime.Parse("10/10/2021"), true, true, false);
            //RetornaCódigoReserva(reserva8);
            //reserva1.CalculaValorTotal(reserva8);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva8);
            //reserva1.ListaReserva.Add(reserva8);

            //Reserva reserva9 = new Reserva(listHospede[8], listChale[7], 2,
            //DateTime.Parse("29/09/2021"), DateTime.Parse("10/10/2021"), false, false, false);
            //RetornaCódigoReserva(reserva9);
            //reserva1.CalculaValorTotal(reserva9);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva9);
            //reserva1.ListaReserva.Add(reserva9);

            //Reserva reserva10 = new Reserva(listHospede[9], listChale[5], 2,
            //DateTime.Parse("29/09/2021"), DateTime.Parse("10/10/2021"), true, true, true);
            //RetornaCódigoReserva(reserva10);
            //reserva1.CalculaValorTotal(reserva10);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva10);
            //reserva1.ListaReserva.Add(reserva10);

            //Reserva reserva11 = new Reserva(listHospede[10], listChale[3], 2,
            //DateTime.Parse("29/09/2021"), DateTime.Parse("10/10/2021"), false, false, false);
            //RetornaCódigoReserva(reserva11);
            //reserva1.CalculaValorTotal(reserva11);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva11);
            //reserva1.ListaReserva.Add(reserva11);

            //Reserva reserva12 = new Reserva(listHospede[11], listChale[8], 2,
            //DateTime.Parse("29/09/2021"), DateTime.Parse("10/10/2021"), true, true, true);
            //RetornaCódigoReserva(reserva12);
            //reserva1.CalculaValorTotal(reserva12);
            //reserva1.StatusReserva = RetornaStatusReserva(reserva12);
            //reserva1.ListaReserva.Add(reserva12);

            //return reserva1.ListaReserva;
        }

        //private string RetornaStatusReserva(Reserva reserva)
        //{
        //    ReservaStatus reservaStatus = new ReservaStatus();
        //    ChaleStatus chaleStatus = new ChaleStatus();

        //    if (reserva.CheckInStatus == true
        //    && reserva.CheckInPagamento == true && reserva.CheckOutStatus == false)
        //    {
        //        reserva.StatusReserva = reservaStatus.Confirmada;
        //        reserva.Chale.Status = chaleStatus.Ocupado;
        //    }
        //    else if (reserva.CheckInStatus == true
        //        && reserva.CheckInPagamento == false && reserva.CheckOutStatus == false)
        //    {
        //        reserva.StatusReserva = reservaStatus.Iniciada;
        //        reserva.Chale.Status = chaleStatus.Iniciada;
        //    }
        //    else if(reserva.CheckInStatus == true
        //        && reserva.CheckInPagamento == true && reserva.CheckOutStatus == true)
        //    {
        //        reserva.StatusReserva = reservaStatus.Finalizada;
        //        reserva.Chale.Status = chaleStatus.Disponivel;
        //    }
        //    else if (reserva.CheckInStatus == false
        //        && reserva.CheckInPagamento == false && reserva.CheckOutStatus == false)
        //    {
        //        reserva.StatusReserva = reservaStatus.Cancelada;
        //        reserva.Chale.Status = chaleStatus.Disponivel;
        //    }
            
        //    return reserva.StatusReserva;
        //}

        private int R = 1;
        private void RetornaCódigoReserva(Reserva reserva)
        {
            //int codReserva = 20210 + reserva.Chale.Id;

            //reserva.CodigoReserva =  codReserva.ToString() + R;
            R++;
        }

        #endregion


        public List<string[]> AdicionaAlerta()
        {

            List<string[]> ListaAlertas = new List<string[]>();
            for (int i = 1; i <= 4; i++)
            {
                string[] alerta = new string[2];
                alerta[0] = "Titulo do alerta " + i.ToString();
                alerta[1] = "Conteúdo do alerta" + i.ToString();

                ListaAlertas.Add(alerta);
            }

            return ListaAlertas;
        }

    }
}
