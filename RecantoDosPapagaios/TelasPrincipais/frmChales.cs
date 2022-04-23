using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.TelasSecundarias;

namespace RecantoDosPapagaios.TelasPrincipais
{
    public partial class frmChales : Form
    {
        private readonly ChaleBusiness _chaleBusiness;

        public List<Acomodacao> Chales { get; set; }

        public int idFuncionario { get; set; }

        public frmChales(int id)
        {
            InitializeComponent();

            _chaleBusiness = new ChaleBusiness();

            idFuncionario = id;
        }

        private void frmChales_Load(object sender, EventArgs e)
        {
            #region Request

            try
            {
                var chales = _chaleBusiness.Obter();

                Chales = chales;

                AdicionaChales(chales);
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Chalés"
                );
            }

            #endregion Request
        }

        public void AdicionaChales(List<Acomodacao> acomodacaos)
        {
            #region AdicionaChales

            foreach (Acomodacao chale in acomodacaos)
            {
                if (chale.Nome.Equals(lblChale1.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale1.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale1.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale1.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale1.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale1.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale2.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale2.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale2.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale2.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale2.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale2.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale3.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale3.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale3.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale3.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale3.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale3.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale4.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale4.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale4.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale4.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale4.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale4.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale5.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale5.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale5.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale5.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale5.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale5.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale6.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale6.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale6.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale6.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale6.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale6.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale7.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale7.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale7.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale7.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale7.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale7.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale8.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale8.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale8.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale8.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale8.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale8.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale9.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale9.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale9.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale9.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale9.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale9.Text = InformacoesChale(chale);
                }
                else if (chale.Nome.Equals(lblChale10.Text))
                {
                    if (chale.StatusAcomodacao.Descricao.Equals("Ocupado"))
                    {
                        lblChale10.BackColor = System.Drawing.Color.IndianRed;
                        btnAbrirChale10.BackColor = System.Drawing.Color.IndianRed;
                    }
                    else if (chale.StatusAcomodacao.Descricao.Equals("Iniciada"))
                    {
                        lblChale10.BackColor = System.Drawing.Color.SteelBlue;
                        btnAbrirChale10.BackColor = System.Drawing.Color.SteelBlue;
                    }

                    txtChale10.Text = InformacoesChale(chale);
                }
            }

            #endregion AdicionaChales
        }

        #region AbrindoOsChales

        private void btnAbrirChale1_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[0].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale1;
                fChaleDetalhes.lblChaleNome.Text = Chales[0].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[0].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[0].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[0].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[0].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 1.");
            }
        }

        private void btnAbrirChale2_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[1].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale2;
                fChaleDetalhes.lblChaleNome.Text = Chales[1].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[1].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[1].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[1].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[1].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 2.");
            }
        }

        private void btnAbrirChale3_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[2].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale3;
                fChaleDetalhes.lblChaleNome.Text = Chales[2].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[2].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[2].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[2].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[2].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 3.");
            }
        }

        private void btnAbrirChale4_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[3].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale4;
                fChaleDetalhes.lblChaleNome.Text = Chales[3].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[3].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[3].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[3].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[3].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 4.");
            }
        }

        private void btnAbrirChale5_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[4].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale5;
                fChaleDetalhes.lblChaleNome.Text = Chales[4].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[4].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[4].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[4].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[4].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 5.");
            }
        }

        private void btnAbrirChale6_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[5].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale6;
                fChaleDetalhes.lblChaleNome.Text = Chales[5].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[5].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[5].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[5].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[5].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 6.");
            }
        }

        private void btnAbrirChale7_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[6].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale7;
                fChaleDetalhes.lblChaleNome.Text = Chales[6].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[6].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[6].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[6].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[6].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 7.");
            }
        }

        private void btnAbrirChale8_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[7].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale8;
                fChaleDetalhes.lblChaleNome.Text = Chales[7].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[7].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[7].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[7].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[7].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 8.");
            }
        }

        private void btnAbrirChale9_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[8].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale9;
                fChaleDetalhes.lblChaleNome.Text = Chales[8].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[8].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[8].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[8].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[8].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 9.");
            }
        }

        private void btnAbrirChale10_Click(object sender, EventArgs e)
        {
            try
            {
                frmChaleDetalhes fChaleDetalhes = new frmChaleDetalhes(Chales[9].Id);
                fChaleDetalhes.idFuncionario = idFuncionario;

                fChaleDetalhes.pcbChale.BackgroundImage = Properties.Resources.Chale10;
                fChaleDetalhes.lblChaleNome.Text = Chales[9].Nome;
                fChaleDetalhes.lblQdtPessoas.Text = Chales[9].InformacoesAcomodacao.Capacidade.ToString() + " pessoas";
                fChaleDetalhes.lblMetrosQuadrados.Text = Chales[9].InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                fChaleDetalhes.lblTipoDeCama.Text = "Tipo de cama: " + Chales[9].InformacoesAcomodacao.TipoDeCama.ToString();
                fChaleDetalhes.lblValorDiaria.Text = Chales[9].InformacoesAcomodacao.Preco.ToString("F2") + " / diária";
                fChaleDetalhes.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível carregar as informações do Chalé 10.");
            }
        }

        #endregion AbrindoOsChales

        public string InformacoesChale(Acomodacao acomodacao)
        {
            var informacoesAcomodacao = new StringBuilder();
            informacoesAcomodacao.Append("Status: " + acomodacao.StatusAcomodacao.Descricao);
            informacoesAcomodacao.Append(Environment.NewLine);

            return informacoesAcomodacao.ToString();
        }

        private void btnAtualizarChale_Click(object sender, EventArgs e)
        {
            frmAtualizarChale fAtualizarChale = new frmAtualizarChale();
            fAtualizarChale.Show();
        }
    }
}
