using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;

namespace RecantoDosPapagaios.TelasPrincipais
{
    public partial class frmGraficos : Form
    {
        private readonly HospedeBusiness _hospedeBusiness;
        private readonly ChaleBusiness _chalesBusiness;

        public int idFuncionario { get; set; }

        public List<Hospede> Hospedes { get; set; }
        public List<Acomodacao> Chales { get; set; }

        public frmGraficos(int id)
        {
            InitializeComponent();

            _chalesBusiness = new ChaleBusiness();
            _hospedeBusiness = new HospedeBusiness();
            idFuncionario = id;
        }

        private void CarregandoHospedes()
        {
            #region Request

            try
            {
                Hospedes = _hospedeBusiness.Obter();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Gráficos"
                );
            }

            #endregion Request
        }

        private void CarregandoChales()
        {
            #region Request

            try
            {
                Chales = _chalesBusiness.Obter();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Gráficos"
                );
            }

            #endregion Request
        }

        private void GraficoStatusChales()
        {
            #region Codigo

            int disponivel = 0, iniciado = 0, ocupado = 0;

            foreach (Acomodacao chale in Chales)
            {
                if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                {
                    iniciado++;
                }
                else if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                {
                    ocupado++;
                }
            }

            disponivel = 10 - (ocupado + iniciado);

            List<string> status = new List<string>();
            status.Add("Iniciado");            
            status.Add("Ocupado");
            status.Add("Disponível");

            List<string> quantidade = new List<string>();
            quantidade.Add(disponivel.ToString());
            quantidade.Add(ocupado.ToString());
            quantidade.Add(iniciado.ToString());


            //Título principal
            Title titulo = new Title();
            titulo.Font = new Font("Arial", 18, FontStyle.Bold);
            titulo.ForeColor = Color.DarkCyan;
            titulo.Text = "Status de chalés";
            Chart01.Titles.Add(titulo);

            //Insere paleta de cores do gráfico
            Chart01.Palette = ChartColorPalette.BrightPastel;

            //Inserir Legenda
            Chart01.Legends.Add("Legenda");
            Chart01.Legends[0].Title = "Status";

            Chart01.Series.Add("Chales");
            Chart01.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //Mostra as quantidades por setor
            Chart01.Series[0].IsValueShownAsLabel = true;

            //Série de dados com os valores do gráfico
            Chart01.Series[0].Points.DataBindXY(status, quantidade);

            #endregion Codigo
        }

        private void GraficoStatusHospedes()
        {
            #region Codigo

            int sp = 0, rj = 0, mg = 0, es = 0, go = 0, outros = 0;

            #region Insere estado
            foreach (Hospede hospede in Hospedes)
            {
                if (hospede.Endereco.Estado.Equals("SP"))
                {
                    sp++;
                }
                else if (hospede.Endereco.Estado.Equals("RJ"))
                {
                    rj++;
                }
                else if (hospede.Endereco.Estado.Equals("MG"))
                {
                    mg++;
                }
                else if (hospede.Endereco.Estado.Equals("ES"))
                {
                    es++;
                }
                else if (hospede.Endereco.Estado.Equals("GO"))
                {
                    go++;
                }
                else
                {
                    outros++;
                }
            }
            #endregion
            List<string> estado = new List<string>();
            estado.Add("São Paulo");
            estado.Add("Rio de Janeiro");
            estado.Add("Minas Gerais");
            estado.Add("Espírito Santo");
            estado.Add("Goiás");
            estado.Add("Outros");

            List<string> quantidade = new List<string>();
            quantidade.Add(sp.ToString());
            quantidade.Add(rj.ToString());
            quantidade.Add(mg.ToString());
            quantidade.Add(es.ToString());
            quantidade.Add(go.ToString());
            quantidade.Add(outros.ToString());


            //Título principal
            Title titulo = new Title();
            titulo.Font = new Font("Arial", 18, FontStyle.Bold);
            titulo.ForeColor = Color.DarkCyan;
            titulo.Text = "Quantidade de hóspedes por estado";
            Chart02.Titles.Add(titulo);

            //Insere paleta de cores do gráfico
            Chart02.Palette = ChartColorPalette.BrightPastel;

            //Inserir Legenda            
            Chart02.Legends.Add("Legenda");
            Chart02.Legends[0].Title = "Estados";

            Chart02.Series.Add("Hóspedes");
            Chart02.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //Mostra as quantidades por setor
            Chart02.Series[0].IsValueShownAsLabel = true;

            //Série de dados com os valores do gráfico
            Chart02.Series[0].Points.DataBindXY(estado, quantidade);

            #endregion Codigo
        }

        #region DefinirGraficoReservas

        //private void GerarGraficosReservas()
        //{
        //    AdicionaInformacoes add = new AdicionaInformacoes();
        //    List<Chale> listChale = add.AddChale();
        //    //List<Reserva> listReserva = add.AdicionaReserva();

        //    int iniciada = 0, confirmada = 0, finalizada = 0, cancelada = 0;

        //    //foreach (Reserva item in listReserva)
        //    //{
        //    //    if (item.StatusReserva.Equals("Iniciada"))
        //    //    {
        //    //        iniciada++;
        //    //    }
        //    //    else if (item.StatusReserva.Equals("Confirmada"))
        //    //    {
        //    //        confirmada++;
        //    //    }
        //    //    else if (item.StatusReserva.Equals("Finalizada"))
        //    //    {
        //    //        finalizada++;
        //    //    }
        //    //    else if (item.StatusReserva.Equals("Cancelada"))
        //    //    {
        //    //        cancelada++;
        //    //    }
        //    //}

        //    List<string> status = new List<string>();
        //    status.Add("Iniciada");
        //    status.Add("Confirmada");
        //    status.Add("Finalizada");
        //    status.Add("Cancelada");

        //    List<string> quantidade = new List<string>();
        //    quantidade.Add(iniciada.ToString());
        //    quantidade.Add(confirmada.ToString());
        //    quantidade.Add(finalizada.ToString());
        //    quantidade.Add(cancelada.ToString());


        //    //Título principal
        //    Title titulo = new Title();
        //    titulo.Font = new Font("Arial", 18, FontStyle.Bold);
        //    titulo.ForeColor = Color.DarkCyan;
        //    titulo.Text = "Status de reserva";
        //    chtGraficoStatusReserva.Titles.Add(titulo);

        //    //Inserir Legenda
        //    chtGraficoStatusReserva.Legends.Add("Legenda");
        //    chtGraficoStatusReserva.Legends[0].Title = "Status";

        //    chtGraficoStatusReserva.Series.Add("Reservas");
        //    chtGraficoStatusReserva.Series[0].ChartType =
        //        System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        //    //Mostra as quantidades por setor
        //    chtGraficoStatusReserva.Series[0].IsValueShownAsLabel = true;

        //    //Série de dados com os valores do gráfico
        //    chtGraficoStatusReserva.Series[0].Points.DataBindXY(status, quantidade);
        //}

        #endregion DefinirGraficoReservas

        private void frmGraficos_Load(object sender, EventArgs e)
        {
            CarregandoChales();
            GraficoStatusChales();
            CarregandoHospedes();
            GraficoStatusHospedes();            
        }
    }
}
