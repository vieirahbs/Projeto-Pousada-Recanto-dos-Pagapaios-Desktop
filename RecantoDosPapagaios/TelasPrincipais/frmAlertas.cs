using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Json;
using RecantoDosPapagaios.Json.AlertaDeleteJson;
using RecantoDosPapagaios.Json.AlertaGetJson;
using RecantoDosPapagaios.Json.AlertaPostJson;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecantoDosPapagaios.TelasPrincipais
{
    public partial class frmAlertas : Form
    {
        private readonly AlertaBusiness _alertaBusiness;

        public FuncionarioGetJson Funcionario { get; set; }

        public List<AlertaGetJson> Alertas { get; set; }

        public int idFuncionario { get; set; }

        public frmAlertas(int id, FuncionarioGetJson funcionario)
        {
            InitializeComponent();

            _alertaBusiness = new AlertaBusiness();
            Funcionario = funcionario;

            idFuncionario = id;
        }

        private void frmAlertas_Load(object sender, EventArgs e)
        {
            #region Limpa os panels de alertas
            lblTitulo.Text = string.Empty;
            lblAlertaTexto.Text = string.Empty;
            lblTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            lblAlertaTexto.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblAlertaTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            btnExcluirAlerta1.Enabled = false;
            btnExcluirAlerta1.Visible = false;

            lblTitulo2.Text = string.Empty;
            lblAlertaTexto2.Text = string.Empty;
            lblTitulo2.BackColor = System.Drawing.Color.WhiteSmoke;
            lblAlertaTexto2.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTitulo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblAlertaTexto2.BorderStyle = System.Windows.Forms.BorderStyle.None;

            btnExcluirAlerta2.Enabled = false;
            btnExcluirAlerta2.Visible = false;

            lblTitulo3.Text = string.Empty;
            lblAlertaTexto3.Text = string.Empty;
            lblTitulo3.BackColor = System.Drawing.Color.WhiteSmoke;
            lblAlertaTexto3.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTitulo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblAlertaTexto3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            btnExcluirAlerta3.Enabled = false;
            btnExcluirAlerta3.Visible = false;

            lblTitulo4.Text = string.Empty;
            lblAlertaTexto4.Text = string.Empty;
            lblTitulo4.BackColor = System.Drawing.Color.WhiteSmoke;
            lblAlertaTexto4.BackColor = System.Drawing.Color.WhiteSmoke;
            lblTitulo4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblAlertaTexto4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            btnExcluirAlerta4.Enabled = false;
            btnExcluirAlerta4.Visible = false;
            #endregion

            #region Request            
            try
            {
                Alertas = _alertaBusiness.Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Alerta"
                );
            }
            int count = 0;
            txtTituloAlerta.Enabled = false;
            txtMensagemAlerta.Enabled = false;
            btnCriarAlerta.Enabled = false;

            if (Alertas != null)
            {
                

                foreach (AlertaGetJson alerta in Alertas)
                {
                    if (lblTitulo.Text.Trim().Equals(string.Empty))
                    {
                        btnExcluirAlerta1.Visible = true;
                        btnExcluirAlerta1.Enabled = true;
                        lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblTitulo.BackColor = System.Drawing.Color.Wheat;
                        lblTitulo.Font = new System.Drawing.Font("Arial", 12.25F,
                            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;

                        lblAlertaTexto.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblAlertaTexto.Dock = System.Windows.Forms.DockStyle.Fill;
                        lblAlertaTexto2.Font = new System.Drawing.Font("Arial", 11.25F,
                            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        lblTitulo.Text = alerta.Titulo;
                        lblAlertaTexto.Text = alerta.Mensagem;
                        lblID1.Text = alerta.Id.ToString();
                        count++;
                    }
                    else if (lblTitulo2.Text.Trim().Equals(string.Empty))
                    {
                        btnExcluirAlerta2.Visible = true;
                        btnExcluirAlerta2.Enabled = true;
                        lblTitulo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblTitulo2.BackColor = System.Drawing.Color.Wheat;
                        lblTitulo2.Font = new System.Drawing.Font("Arial", 12.25F,
                            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblTitulo2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;

                        lblAlertaTexto2.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblAlertaTexto2.Dock = System.Windows.Forms.DockStyle.Fill;
                        lblAlertaTexto2.Font = new System.Drawing.Font("Arial", 11.25F,
                            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        lblTitulo2.Text = alerta.Titulo;
                        lblAlertaTexto2.Text = alerta.Mensagem;
                        lblID2.Text = alerta.Id.ToString();
                        count++;
                    }
                    else if (lblTitulo3.Text.Trim().Equals(string.Empty))
                    {
                        btnExcluirAlerta3.Visible = true;
                        btnExcluirAlerta3.Enabled = true;
                        lblTitulo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblTitulo3.BackColor = System.Drawing.Color.Wheat;
                        lblTitulo3.Font = new System.Drawing.Font("Arial", 12.25F,
                            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblTitulo3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;

                        lblAlertaTexto3.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblAlertaTexto.Dock = System.Windows.Forms.DockStyle.Fill;
                        lblAlertaTexto2.Font = new System.Drawing.Font("Arial", 11.25F,
                            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        lblTitulo3.Text = alerta.Titulo;
                        lblAlertaTexto3.Text = alerta.Mensagem;
                        lblID3.Text = alerta.Id.ToString();
                        count++;
                    }
                    else if (lblTitulo4.Text.Trim().Equals(string.Empty))
                    {
                        btnExcluirAlerta4.Visible = true;
                        btnExcluirAlerta4.Enabled = true;
                        lblTitulo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblTitulo4.BackColor = System.Drawing.Color.Wheat;
                        lblTitulo4.Font = new System.Drawing.Font("Arial", 12.25F,
                            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblTitulo4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;

                        lblAlertaTexto4.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblAlertaTexto4.Dock = System.Windows.Forms.DockStyle.Fill;
                        lblAlertaTexto4.Font = new System.Drawing.Font("Arial", 11.25F,
                            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        lblTitulo4.Text = alerta.Titulo;
                        lblAlertaTexto4.Text = alerta.Mensagem;
                        lblID4.Text = alerta.Id.ToString();
                        count++;
                    }
                };
            }
            #region Contador de alertas
            if (count == 0)
            {
                lblContadorAlertas.Text = "Nenhum alerta até o momento.";
                lblContadorAlertas.ForeColor = System.Drawing.Color.DarkSlateGray;
            }
            else if (count == 1)
            {
                lblContadorAlertas.Text = $"{count} alerta.";
                lblContadorAlertas.ForeColor = System.Drawing.Color.IndianRed;
            }
            else
            {
                lblContadorAlertas.Text = $"{count} alertas.";
                lblContadorAlertas.ForeColor = System.Drawing.Color.IndianRed;
            }
            #endregion

            #endregion Request

            #region Desabilita a criação de alertas
            if (Funcionario.CategoriaAcesso.Descricao.Equals("Recepcao"))
            {
                btnHabilitarAlerta.Enabled = false;
                btnHabilitarAlerta.Visible = false;
                pnlAlertaTexto.Enabled = false;
                pnlAlertaTexto.Visible = false;
                btnExcluirAlerta1.Enabled = false;
                btnExcluirAlerta1.Visible = false;
                btnExcluirAlerta2.Enabled = false;
                btnExcluirAlerta2.Visible = false;
                btnExcluirAlerta3.Enabled = false;
                btnExcluirAlerta3.Visible = false;
                btnExcluirAlerta4.Enabled = false;
                btnExcluirAlerta4.Visible = false;
            }
            #endregion
        }

        private void btnHabilitarAlerta_Click(object sender, EventArgs e)
        {
            #region Codigo

            txtTituloAlerta.Enabled = true;
            txtMensagemAlerta.Enabled = true;
            btnCriarAlerta.Enabled = true;

            #endregion Codigo
        }

        private void btnCriarAlerta_Click(object sender, EventArgs e)
        {
            if (txtTituloAlerta.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe um título para o alerta.", "Alerta");
                return;
            }
            else if (txtMensagemAlerta.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("O campo mensagem não pode estar vazio.", "Alerta");
                return;
            }

            #region Request

            try
            {
                if (lblTitulo4.Text.Trim().Equals(string.Empty))
                {
                    var alerta = new AlertaPostJson
                    {
                        Titulo = txtTituloAlerta.Text,
                        Mensagem = txtMensagemAlerta.Text,
                        IdFuncionario = idFuncionario
                    };

                    var post = _alertaBusiness.Post(alerta);

                    if (post.StatusCode == 201)
                    {
                        MessageBox.Show(post.Mensagem, "Alerta");

                        txtTituloAlerta.Clear();
                        txtMensagemAlerta.Clear();

                        txtTituloAlerta.Enabled = false;
                        txtMensagemAlerta.Enabled = false;
                        btnCriarAlerta.Enabled = false;


                        frmAlertas_Load(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show(post.Mensagem, "Alerta");
                    }
                }
                else
                {
                    MessageBox.Show("O limite de registro de alertas foi atingido!", "Alerta");

                    txtTituloAlerta.Enabled = false;
                    txtMensagemAlerta.Enabled = false;
                    btnCriarAlerta.Enabled = false;

                    frmAlertas_Load(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Alerta"
                );
            }

            #endregion Request
        }

        #region Botões para excluir os alertas

        private void btnExcluirAlerta1_Click(object sender, EventArgs e)
        {
            string mensagem = "Tem certeza que deseja deletar este alerta?";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensagem, "Alertas", botoes);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    var alerta = new AlertaDeleteJson
                    {
                        Id = int.Parse(lblID1.Text)
                    };

                    var delete = _alertaBusiness.Delete(alerta.Id);

                    if (delete.StatusCode == 200)
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");

                        lblTitulo.Text = string.Empty;
                        lblAlertaTexto.Text = string.Empty;
                        lblTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto.BackColor = System.Drawing.Color.WhiteSmoke;
                        txtTituloAlerta.Clear();
                        txtMensagemAlerta.Clear();

                        txtTituloAlerta.Enabled = false;
                        txtMensagemAlerta.Enabled = false;
                        btnCriarAlerta.Enabled = false;
                        btnExcluirAlerta1.Enabled = false;
                        btnExcluirAlerta1.Visible = false;


                        frmAlertas_Load(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Alerta");
                }
            }
        }

        private void btnExcluirAlerta2_Click(object sender, EventArgs e)
        {
            string mensagem = "Tem certeza que deseja deletar este alerta?";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensagem, "Alertas", botoes);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    var alerta = new AlertaDeleteJson
                    {
                        Id = int.Parse(lblID2.Text)
                    };

                    var delete = _alertaBusiness.Delete(alerta.Id);

                    if (delete.StatusCode == 200)
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");

                        lblTitulo2.Text = string.Empty;
                        lblAlertaTexto2.Text = string.Empty;
                        lblTitulo2.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto2.BackColor = System.Drawing.Color.WhiteSmoke;
                        txtTituloAlerta.Clear();
                        txtMensagemAlerta.Clear();

                        txtTituloAlerta.Enabled = false;
                        txtMensagemAlerta.Enabled = false;
                        btnCriarAlerta.Enabled = false;
                        btnExcluirAlerta1.Enabled = false;
                        btnExcluirAlerta1.Visible = false;


                        frmAlertas_Load(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Alerta");
                }
            }
        }

        private void btnExcluirAlerta3_Click(object sender, EventArgs e)
        {
            string mensagem = "Tem certeza que deseja deletar este alerta?";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensagem, "Alertas", botoes);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    var alerta = new AlertaDeleteJson
                    {
                        Id = int.Parse(lblID3.Text)
                    };

                    var delete = _alertaBusiness.Delete(alerta.Id);

                    if (delete.StatusCode == 200)
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");

                        lblTitulo3.Text = string.Empty;
                        lblAlertaTexto3.Text = string.Empty;
                        lblTitulo3.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto3.BackColor = System.Drawing.Color.WhiteSmoke;
                        txtTituloAlerta.Clear();
                        txtMensagemAlerta.Clear();

                        txtTituloAlerta.Enabled = false;
                        txtMensagemAlerta.Enabled = false;
                        btnCriarAlerta.Enabled = false;
                        btnExcluirAlerta1.Enabled = false;
                        btnExcluirAlerta1.Visible = false;


                        frmAlertas_Load(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Alerta");
                }
            }
        }

        private void btnExcluirAlerta4_Click(object sender, EventArgs e)
        {
            string mensagem = "Tem certeza que deseja deletar este alerta?";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resultado = MessageBox.Show(mensagem, "Alertas", botoes);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    var alerta = new AlertaDeleteJson
                    {
                        Id = int.Parse(lblID4.Text)
                    };

                    var delete = _alertaBusiness.Delete(alerta.Id);

                    if (delete.StatusCode == 200)
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");

                        lblTitulo4.Text = string.Empty;
                        lblAlertaTexto4.Text = string.Empty;
                        lblTitulo4.BackColor = System.Drawing.Color.WhiteSmoke;
                        lblAlertaTexto4.BackColor = System.Drawing.Color.WhiteSmoke;
                        txtTituloAlerta.Clear();
                        txtMensagemAlerta.Clear();

                        txtTituloAlerta.Enabled = false;
                        txtMensagemAlerta.Enabled = false;
                        btnCriarAlerta.Enabled = false;
                        btnExcluirAlerta1.Enabled = false;
                        btnExcluirAlerta1.Visible = false;


                        frmAlertas_Load(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show(delete.Mensagem, "Alerta");
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Alerta");
                }
            }
        }

        #endregion
    }
}
