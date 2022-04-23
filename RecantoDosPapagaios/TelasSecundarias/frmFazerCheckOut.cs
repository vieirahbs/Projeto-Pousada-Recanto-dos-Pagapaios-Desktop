using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.Json;
using System;
using System.Windows.Forms;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmFazerCheckOut : Form
    {
        private readonly CheckOutBusiness _checkOutBusiness;
        
        public Reserva Reserva { get; set; }

        public int idFuncionario { get; set; }
        public int IdAcomodacao { get; set; }

        public frmFazerCheckOut(int id, int idAcomodacao)
        {
            InitializeComponent();

            _checkOutBusiness = new CheckOutBusiness();

            idFuncionario = id;
            IdAcomodacao = idAcomodacao;
        }

        private void frmFazerCheckOut_Load(object sender, EventArgs e)
        {
            #region Codigo

            cmbSelecionarPagamento.Items.Add("Dinheiro");
            cmbSelecionarPagamento.Items.Add("Cartão de Débito");
            cmbSelecionarPagamento.Items.Add("Cartão de Crédito");
            cmbSelecionarPagamento.Items.Add("Transferência Bancária");
            cmbSelecionarPagamento.Items.Add("Deposito Bancário");
            cmbSelecionarPagamento.Items.Add("PIX");
            cmbSelecionarPagamento.Items.Add("Sem pagamentos adicionais");

            cmbSelecionarPagamento.Enabled = false;
            txtValorAdicional.Enabled = false;
            lblAviso.Text = string.Empty;

            #endregion Codigo

            #region Adiciona foto do chalé
            if (IdAcomodacao.Equals(1))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale1;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(2))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale2;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(3))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale3;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(4))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale4;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(5))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale5;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(6))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale6;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(7))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale7;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(8))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale8;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(9))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale9;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else if (IdAcomodacao.Equals(10))
            {
                pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale10;
                pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            #endregion
        }

        private void btnAdicionarValor_Click(object sender, EventArgs e)
        {
            #region Codigo

            try
            {
                if (txtValorAdicional.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("Informe o valor adicional.", "Check-out");
                    return;
                }
                else
                {
                    double total = double.Parse(lblValorTotal.Text) + double.Parse(txtValorAdicional.Text);
                    lblValorTotal.Text = total.ToString("F2");
                    MessageBox.Show("Valor adicionado!", "Check-out");
                    ckbValorAdicional.Checked = false;
                    lblAviso.Text = "Valor adicionado!";
                    lblAviso.ForeColor = System.Drawing.Color.DarkCyan;
                    ckbValorAdicional.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Check-out"
                );
            }

            #endregion Codigo
        }

        private void btnFazerCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelecionarPagamento.Enabled == false)
                {
                    #region Post

                    try
                    {
                        int valoresAdicionais;
                        int tipoPagamento;
                        double valorAdicional;

                        if (ckbValorAdicional.Checked)
                        {
                            valoresAdicionais = 1;
                            tipoPagamento = cmbSelecionarPagamento.SelectedIndex + 1;
                            valorAdicional = Convert.ToDouble(txtValorAdicional.Text);
                        }
                        else
                        {
                            valoresAdicionais = 0;
                            tipoPagamento = 0;
                            valorAdicional = 0;
                        }

                        var checkOutPost = new CheckOutPostJson
                        {
                            idReserva = Reserva.Id,
                            idFuncionario = idFuncionario,
                            ValoresAdicionais = valoresAdicionais,
                            TipoPagamento = tipoPagamento,
                            ValorAdicional = valorAdicional
                        };

                        var post = _checkOutBusiness.PostCheckOut(checkOutPost);

                        if (post.StatusCode == 200)
                        {
                            MessageBox.Show(post.Mensagem, "Check-out");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(post.Mensagem, "Check-out");
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    #endregion Post
                }
                else
                {
                    if (txtValorAdicional.Text.Trim().Equals(string.Empty))
                    {
                        MessageBox.Show("Informe o valor adicional", "Check-out");
                        return;
                    }
                    else if(cmbSelecionarPagamento.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Selecione a forma de pagamento", "Check-out");
                        return;
                    }
                    else if (!lblAviso.Text.Equals("Valor adicionado!"))
                    {
                        MessageBox.Show("Clique em '+' para adicionar o valor.", "Check-out");
                        return;
                    }
                    else
                    {
                        #region Post

                        try
                        {
                            int valoresAdicionais = 1;
                            int tipoPagamento = cmbSelecionarPagamento.SelectedIndex + 1;
                            double valorAdicional = Convert.ToDouble(txtValorAdicional.Text);

                            var checkOutPost = new CheckOutPostJson
                            {
                                idReserva = Reserva.Id,
                                idFuncionario = idFuncionario,
                                ValoresAdicionais = valoresAdicionais,
                                TipoPagamento = tipoPagamento,
                                ValorAdicional = valorAdicional
                            };

                            var post = _checkOutBusiness.PostCheckOut(checkOutPost);

                            if (post.StatusCode == 201)
                            {
                                MessageBox.Show(post.Mensagem, "Check-out");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(post.Mensagem, "Check-out");
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }

                        #endregion Post
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Check-out"
                );
            }
        }

        private void ckbValorAdicional_CheckedChanged(object sender, EventArgs e)
        {
            #region Codigo

            if (!ckbValorAdicional.Checked)
            {
                txtValorAdicional.Enabled = false;
                btnAdicionarValor.Enabled = false;
            }
            else
            {
                txtValorAdicional.Enabled = true;
                cmbSelecionarPagamento.Enabled = true;
                btnAdicionarValor.Enabled = true;
            }

            #endregion Codigo
        }
    }
}
