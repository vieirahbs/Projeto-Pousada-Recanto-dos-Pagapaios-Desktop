using System;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;

namespace RecantoDosPapagaios.TelasPrincipais
{
    public partial class frmRelatorios : Form
    {
        private readonly RelatorioBusiness _relatorioBusiness;

        public int idFuncionario { get; set; }

        public frmRelatorios(int id)
        {
            InitializeComponent();

            _relatorioBusiness = new RelatorioBusiness();

            idFuncionario = id;
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            cmbSelecionaTipoRelatorio.Items.Clear();
            cmbSelecionaTipoRelatorio.Items.Add("Faturamento Mensal por Chalé");
            cmbSelecionaTipoRelatorio.Items.Add("Performance dos Funcionários");
            cmbSelecionaTipoRelatorio.Items.Add("Visão Geral Mensal");
        }

        private void btnGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            try
            {
                TimeSpan duration = dtpDataFinal.Value.Subtract(dtpDataInicial.Value);

                if (cmbSelecionaTipoRelatorio.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Selecione o tipo de relatório que deseja gerar.",
                        "Relatórios");

                    return;
                }
                else if (cmbSelecionaTipoRelatorio.SelectedIndex == 0 || cmbSelecionaTipoRelatorio.SelectedIndex == 2)
                {
                    if (dtpDataFinal.Value < dtpDataInicial.Value)
                    {
                        MessageBox.Show("A data inicial não pode ser superior a data final.",
                        "Relatórios");

                        return;
                    }
                    else if (duration.TotalDays > 30)
                    {
                        MessageBox.Show("Para gerar o relatório, o período não pode ser superior a 30 dias.",
                            "Relatórios");

                        return;
                    }
                    else
                    {
                        if (cmbSelecionaTipoRelatorio.SelectedIndex == 0)
                            _relatorioBusiness.RelatorioFaturamentoChaleMensal(dtpDataInicial.Value, dtpDataFinal.Value);
                        else if (cmbSelecionaTipoRelatorio.SelectedIndex == 2)
                            _relatorioBusiness.RelatorioVisaoGeralMensal(dtpDataInicial.Value, dtpDataFinal.Value);
                        MessageBox.Show(@"Seu relatório foi gerado com sucesso e salvo na pasta 'Relatorios' em C:\.");
                        frmRelatorios_Load(this, new EventArgs());
                    }
                }
                else
                {
                    if (cmbSelecionaTipoRelatorio.SelectedIndex == 1)
                        _relatorioBusiness.RelatorioPerformanceFuncionarios();
                    MessageBox.Show(@"Seu relatório foi gerado com sucesso e salvo na pasta 'Relatorios' em C:\.");
                    frmRelatorios_Load(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Relatórios"
                );
            }
        }        
    }
}
