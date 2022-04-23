﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RecantoDosPapagaios.Business;
using RecantoDosPapagaios.Entities;
using RecantoDosPapagaios.TelasSecundarias;

namespace RecantoDosPapagaios.TelasPrincipais
{
    public partial class frmCheckOut : Form
    {
        private readonly ReservaBusiness _reservaBusiness;

        public List<Reserva> Reservas { get; set; }

        public int idFuncionario { get; set; }

        public frmCheckOut(int id)
        {
            InitializeComponent();

            _reservaBusiness = new ReservaBusiness();

            idFuncionario = id;
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            #region Codigo

            //Estabelece as colunas que a lstReservas vai ter ao abri-la
            lstCheckOut.Clear();
            lstCheckOut.Columns.Insert(0, "Código de reserva", 110, HorizontalAlignment.Left);
            lstCheckOut.Columns.Insert(1, "Titular", 190, HorizontalAlignment.Left);
            lstCheckOut.Columns.Insert(2, "Chalé", 140, HorizontalAlignment.Left);
            lstCheckOut.Columns.Insert(3, "Check-in", 140, HorizontalAlignment.Left);
            lstCheckOut.Columns.Insert(4, "Check-out", 140, HorizontalAlignment.Left);

            #endregion Codigo
        }

        private void btnBuscarCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                frmCheckOut_Load(this, new EventArgs());
                
                int count = 0;

                if (!txtPesquisaReserva.Text.Trim().Equals(string.Empty))
                {
                    var reservas = _reservaBusiness.Obter(txtPesquisaReserva.Text);

                    if (reservas.Count > 0)
                    {
                        Reservas = reservas;

                        foreach (Reserva item in reservas)
                        {
                            if (item.StatusReserva.Id.Equals(2))
                            {
                                ListViewItem reservaTeste = lstCheckOut.Items.Add(item.Id.ToString());
                                reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Hospede.NomeCompleto));
                                reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.Acomodacao.Nome));
                                reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckIn.ToShortDateString()));
                                reservaTeste.SubItems.Add(new ListViewItem.ListViewSubItem(null, item.DataCheckOut.ToShortDateString()));

                                count++;
                            }
                        }

                        if (count == 0)
                            MessageBox.Show("CPF não localizado ou não há check-ins para esse CPF.", "Check-outs");
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma reserva foi encontrada para o CPF informado.", "Check-outs");
                    }

                    lblTotalCheckOut.Text = "Total de check-outs localizados: " + count.ToString();
                }
                else
                {
                    MessageBox.Show("Para buscar check-outs, é necessário um CPF.", "Check-outs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"O seguinte erro aconteceu ao realizar o processo: {ex.Message}", "Check-in"
                );
            }
        }

        private void lstCheckOut_DoubleClick(object sender, EventArgs e)
        {
            frmReservaDetalhe fReservaDetalhe = new frmReservaDetalhe(idFuncionario);

            foreach (Reserva item in Reservas)
            {
                if (item.Id.ToString() == lstCheckOut.SelectedItems[0].Text)
                {
                    fReservaDetalhe.Reserva = item;

                    #region Adiciona a imagem do chalé
                    if (item.Acomodacao.Id.Equals(1))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale1;
                    }
                    else if (item.Acomodacao.Id.Equals(2))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale2;
                    }
                    else if (item.Acomodacao.Id.Equals(3))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale3;
                    }
                    else if (item.Acomodacao.Id.Equals(4))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale4;
                    }
                    else if (item.Acomodacao.Id.Equals(5))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale5;
                    }
                    else if (item.Acomodacao.Id.Equals(6))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale6;
                    }
                    else if (item.Acomodacao.Id.Equals(7))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale7;
                    }
                    else if (item.Acomodacao.Id.Equals(8))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale8;
                    }
                    else if (item.Acomodacao.Id.Equals(9))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale9;
                    }
                    else if (item.Acomodacao.Id.Equals(10))
                    {
                        fReservaDetalhe.pcbChale.BackgroundImage = global::RecantoDosPapagaios.Properties.Resources.Chale10;
                    }
                    #endregion
                    fReservaDetalhe.IdReserva = item.Id;
                    fReservaDetalhe.Categoria = item.Acomodacao.StatusAcomodacao.Descricao;
                    fReservaDetalhe.pcbChale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    fReservaDetalhe.lblStatusReserva.Text = item.StatusReserva.Descricao;
                    fReservaDetalhe.txtReservaDetalhes.Text = AdicionarDetalhesReserva(item);
                    fReservaDetalhe.lblValorDiaria.Text = "R$ " + item.PrecoUnitario.ToString("F2");
                    fReservaDetalhe.lblValorTotal.Text = "R$ " + item.PrecoTotal.ToString("F2");
                    fReservaDetalhe.lblCodigoReserva.Text = item.Id.ToString();

                    if (item.StatusReserva.Descricao.Trim().Equals("Confirmada"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.Chocolate;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = true;
                    }
                    else if (item.StatusReserva.Descricao.Trim().Equals("Concluída"))
                    {
                        fReservaDetalhe.lblStatusReserva.ForeColor = Color.DarkCyan;
                        fReservaDetalhe.btnFazerCheckIn.Enabled = false;
                        fReservaDetalhe.btnFazerCheckOut.Enabled = false;
                    }
                }
            }

            fReservaDetalhe.Show();
        }

        private void txtPesquisaReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnBuscarCheckOut_Click(btnBuscarCheckOut, new EventArgs());
            }
        }

        private void btnCriarNovaReserva_Click(object sender, EventArgs e)
        {
            frmCriarNovaReserva fCriarNovaReserva = new frmCriarNovaReserva();
            fCriarNovaReserva.Show();
        }

        private string AdicionarDetalhesReserva(Reserva reserva)
        {
            var builder = new StringBuilder();
            builder.Append("Hóspede: " + reserva.Hospede.NomeCompleto);
            builder.Append(Environment.NewLine);

            builder.Append("Chalé: " + reserva.Acomodacao.Nome);
            builder.Append(Environment.NewLine);

            builder.Append("Tipo de pagamento: " + reserva.Pagamento.TipoPagamento.Descricao);
            builder.Append(Environment.NewLine);

            builder.Append("Status: " + reserva.Pagamento.StatusPagamento.Descricao);
            builder.Append(Environment.NewLine);

            builder.Append("Data de check-in: " + reserva.DataCheckIn.ToString("d"));
            builder.Append(Environment.NewLine);

            builder.Append("Data de check-out: " + reserva.DataCheckOut.ToString("d"));
            builder.Append(Environment.NewLine);

            builder.Append("Acompanhantes: " + reserva.Acompanhantes.ToString());
            builder.Append(Environment.NewLine);

            return builder.ToString();
        }
    }
}
