using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_231009.Models;

namespace Projeto_231009.Views
{
    public partial class FrmClientes : Form
    {
        Cidades ci;
        Clientes cl;

        public FrmClientes()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtID.Clear();
            txtNOME.Clear();
            cmbCIDADES.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRENDA.Clear();
            dtpNASCIMENTO.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVENDA.Checked = false;
        }

        void carregarGrid(string pesquisar)
        {
            cl = new Clientes()
            {
                nome = pesquisar
            };
            dgvCLIENTES.DataSource = cl.Consultar();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidades();
            cmbCIDADES.DataSource = ci.Consultar();
            cmbCIDADES.DisplayMember = "nome";
            cmbCIDADES.ValueMember = "id";

            limparControles();
            carregarGrid("");

            dgvCLIENTES.Columns["idCidade"].Visible = false;
            dgvCLIENTES.Columns["foto"].Visible = false;
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdARQUIVO.InitialDirectory = "D:/fotos/clientes";
            ofdARQUIVO.FileName = "";
            ofdARQUIVO.ShowDialog();
            picFoto.ImageLocation = ofdARQUIVO.FileName;
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            if (txtNOME.Text == "") return;

            cl = new Clientes()
            {
                nome = txtNOME.Text,
                idCidade = (int)cmbCIDADES.SelectedValue,
                nascimento = dtpNASCIMENTO.Value,
                renda = double.Parse(txtRENDA.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVENDA.Checked
            };
            cl.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dgvCLIENTES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCLIENTES.RowCount > 0)
            {
                txtID.Text = dgvCLIENTES.CurrentRow.Cells["id"].Value.ToString();
                txtNOME.Text = dgvCLIENTES.CurrentRow.Cells["nome"].Value.ToString();
                cmbCIDADES.Text = dgvCLIENTES.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = dgvCLIENTES.CurrentRow.Cells["uf"].Value.ToString();
                chkVENDA.Checked = (bool)dgvCLIENTES.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = dgvCLIENTES.CurrentRow.Cells["cpf"].Value.ToString();
                dtpNASCIMENTO.Text = dgvCLIENTES.CurrentRow.Cells["nascimento"].Value.ToString();
                txtRENDA.Text = dgvCLIENTES.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = dgvCLIENTES.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            if (txtNOME.Text == "") return;

            cl = new Clientes()
            {
                nome = txtNOME.Text,
                idCidade = (int)cmbCIDADES.SelectedValue,
                nascimento = dtpNASCIMENTO.Value,
                renda = double.Parse(txtRENDA.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVENDA.Checked
            };
            cl.Alterar();

            limparControles();
            carregarGrid("");
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Clientes()
                {
                    id = int.Parse(txtID.Text)
                };
                cl.Excluir();

                limparControles();
                carregarGrid("");
            }
        }

        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPESQUISAR_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPESQUISAR.Text);
        }
    }
}
