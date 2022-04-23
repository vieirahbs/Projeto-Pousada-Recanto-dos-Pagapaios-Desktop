using System;
using System.Drawing;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Json.ChalePutJson;

namespace RecantoDosPapagaios.TelasSecundarias
{
    public partial class frmAtualizarChale : Form
    {
        private readonly ChaleBusiness _chaleBusiness;

        public frmAtualizarChale()
        {
            InitializeComponent();

            _chaleBusiness = new ChaleBusiness();
        }

        private void frmAtualizarChale_Load(object sender, EventArgs e)
        {
            cmbSelecionaChale.Items.Add("Chalé 1");
            cmbSelecionaChale.Items.Add("Chalé 2");
            cmbSelecionaChale.Items.Add("Chalé 3");
            cmbSelecionaChale.Items.Add("Chalé 4");
            cmbSelecionaChale.Items.Add("Chalé 5");
            cmbSelecionaChale.Items.Add("Chalé 6");
            cmbSelecionaChale.Items.Add("Chalé 7");
            cmbSelecionaChale.Items.Add("Chalé 8");
            cmbSelecionaChale.Items.Add("Chalé 9");
            cmbSelecionaChale.Items.Add("Chalé 10");

            cmbCategoria.Items.Add("Standard");
            cmbCategoria.Items.Add("Superior");
            cmbCategoria.Items.Add("Master");
        }

        private void cmbSelecionaChale_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var chale = _chaleBusiness.Obter(cmbSelecionaChale.SelectedIndex + 1);

                lblTituloAtualizaCria.Text = "Atualizar chalé";
                btnAtualizarCriarNovoChale.Text = "Atualizar chalé";
                pcbEditarCriar.BackgroundImage = Properties.Resources.EditarCinza;

                cmbCategoria.SelectedIndex = chale.CategoriaAcomodacao.Id - 1;
                txtNomeChale.Text = chale.Nome;
                txtCapacidade.Text = chale.InformacoesAcomodacao.Capacidade.ToString();
                txtTamanho.Text = chale.InformacoesAcomodacao.MetrosQuadrados.ToString() + "m2";
                txtTipoCama.Text = chale.InformacoesAcomodacao.TipoDeCama;
                txtValorDiaria.Text = "R$ " + chale.InformacoesAcomodacao.Preco.ToString("F2");
                #region Adiciona a foto do chalé
                if (chale.Id == 1)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale1;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 2)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale2;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 3)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale3;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 4)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale4;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 5)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale5;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 6)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale6;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 7)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale7;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 8)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale8;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 9)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale9;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else if (chale.Id == 10)
                {
                    pcbFotoChale.BackgroundImage = Properties.Resources.Chale10;
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Atualização de chalé"
                );
            }
        }

        private void btnAtualizarCriarNovoChale_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAtualizarCriarNovoChale.Text == "Atualizar chalé")
                {
                    if (cmbSelecionaChale.SelectedIndex.Equals(-1) ||
                        txtNomeChale.Text.Trim().Equals(string.Empty) ||
                        txtCapacidade.Text.Trim().Equals(string.Empty) ||
                        txtTamanho.Text.Trim().Equals(string.Empty) ||
                        txtTipoCama.Text.Trim().Equals(string.Empty) ||
                        txtValorDiaria.Text.Trim().Equals(string.Empty) ||
                        cmbCategoria.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show
                        (
                            "Informe todos os dados para que o chalé seja atualizado.",
                            "Atualização de chalé"
                        );

                        return;
                    }
                    else
                    {
                        var tamanho = txtTamanho.Text.Substring(0, 2);
                        var preco = txtValorDiaria.Text.Substring(3, 6).Replace(",", ".");

                        var precoValido = double.TryParse(preco, out _);

                        if (precoValido)
                        {
                            var put = new ChalePutJson
                            {
                                IdAcomodacao = cmbSelecionaChale.SelectedIndex + 1,
                                Nome = txtNomeChale.Text,
                                Categoria = cmbCategoria.SelectedIndex + 1,
                                Capacidade = int.Parse(txtCapacidade.Text),
                                Tamanho = int.Parse(tamanho),
                                TipoDeCama = txtTipoCama.Text,
                                Preco = preco
                            };

                            try
                            {
                                var retorno = _chaleBusiness.Put(put);

                                if (retorno.StatusCode == 200)
                                {
                                    MessageBox.Show(retorno.Mensagem, "Atualização de chalé");

                                    cmbSelecionaChale.SelectedIndex.Equals(-1);
                                    txtNomeChale.Clear();
                                    cmbCategoria.SelectedIndex.Equals(-1);
                                    txtCapacidade.Clear();
                                    txtTamanho.Clear();
                                    txtTipoCama.Clear();
                                    txtValorDiaria.Clear();
                                }
                                else
                                {
                                    MessageBox.Show(retorno.Mensagem, "Atualização de chalé");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show
                                (
                                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}",
                                    "Atualização de chalé"
                                );
                            }
                        }
                        else
                        {
                            MessageBox.Show("O preço informado está inválido.", "Atualização de chalé");
                        }
                    }
                }

                if (btnAtualizarCriarNovoChale.Text == "Criar novo chalé")
                {
                    if (txtNomeChale.Text.Trim().Equals(string.Empty) ||
                        txtCapacidade.Text.Trim().Equals(string.Empty) ||
                        txtTamanho.Text.Trim().Equals(string.Empty) ||
                        txtTipoCama.Text.Trim().Equals(string.Empty) ||
                        txtValorDiaria.Text.Trim().Equals(string.Empty) ||
                        cmbCategoria.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show
                        (
                            "Informe todos os dados para que o chalé seja atualizado.",
                            "Atualização de chalé"
                        );

                        return;
                    }
                    else
                    {
                        MessageBox.Show("Chalé criado com sucesso.", "Criação de chalé");
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atualização de chalé");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (cmbSelecionaChale.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show
                (
                    "Antes de subir uma imagem, é necessário selecionar um chalé ou selecionar" +
                    "'Novo chalé'"
                );

                return;
            }
            else
            {   //Carregar uma imagem de um diretório para dentro do VisualStudio
                DialogResult dialogResult = openFileChaleFoto.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    pcbFotoChale.BackgroundImage = Image.FromFile(openFileChaleFoto.FileName);
                    pcbFotoChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
            }
        }
    }
}
