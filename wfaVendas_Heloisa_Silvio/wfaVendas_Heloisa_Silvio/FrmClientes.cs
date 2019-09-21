using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaVendas_Heloisa_Silvio
{
    public partial class FrmClientes : Form
    {
        bool incluir = false;
        bool alterar = false;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //this.pc_clientesTableAdapter.Fill(this.vendasDataSet.pc_clientes);
        }

        private void habilitaCampos(bool hab)
        {
            txtCodigo.Enabled = hab;
            txtNome.Enabled = hab;
            txtEndereco.Enabled = hab;
            txtCidade.Enabled = hab;
            txtBairro.Enabled = hab;
            mskUf.Enabled = hab;
            mskCep.Enabled = hab;
            mskTelefone.Enabled = hab;
            dtpDataNasc.Enabled = hab;
        }

        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if ((item is TextBox))
                {
                    ((TextBox)item).Clear();
                }
                /*if ((item is MaskedTextBox))
                {
                    ((MaskedTextBox)item).Clear();
                }*/
                if ((item is DateTimePicker))
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnAlterar.Enabled = hab;
            btnExcluir.Enabled = hab;
            btnPesquisar.Enabled = hab;
            //btnSair.Enabled = hab;
            btnGravar.Enabled = hab;
            btnCancelar.Enabled = hab;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            incluir = true;
            txtCodigo.Focus();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtCodigo.Enabled = false;
                txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                mskUf.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                mskCep.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                mskTelefone.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString());
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    /*pc_clientesTableAdpter.Insert(Convert.ToInt32(txtCodigo.Text),
                        txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text,
                        mskUf.Text, mskCep.Text, mskTelefone.Text, dtpDataNasc.Value);
                    MessageBox.Show("Incluido com sucesso!", "Incluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }
                if (alterar)
                {
                    /*pc_clientesTableAdpter.Update(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text,
                        mskUf.Text, mskCep.Text, mskTelefone.Text, dtpDataNasc.Value);
                    MessageBox.Show("Alterado com sucesso!", "Alterar",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                }
                FrmClientes_Load(null, null);
                //btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro")
                throw;
            }
        }
    }
}
