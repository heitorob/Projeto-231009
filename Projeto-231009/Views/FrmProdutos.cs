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
    public partial class FrmProdutos : Form
    {
        Produtos p;
        Categorias c;
        Marcas m;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtID.Clear();
            txtDESCRICAO.Clear();
            cmbCATEGORIAS.SelectedIndex = -1;
            cmbMARCAS.SelectedIndex = -1;
            txtESTOQUE.Clear();
            txtVENDA.Clear();
            picFoto.ImageLocation = "";
        }

        void carregarGrid(string pesquisar)
        {
            p = new Produtos()
            {
                descricao = pesquisar
            };
            dgvPRODUTOS.DataSource = p.Consultar();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            p = new Produtos();
            dgvPRODUTOS.DataSource = p.Consultar();
            cmbCATEGORIAS.DisplayMember = "categoria";
            cmbCATEGORIAS.ValueMember = "id";
            cmbMARCAS.DisplayMember = "marca";
            cmbMARCAS.ValueMember = "id";

            limparControles();
            carregarGrid("");

            dgvPRODUTOS.Columns["idCategoria"].Visible = false;
            dgvPRODUTOS.Columns["idMarca"].Visible = false;
            dgvPRODUTOS.Columns["foto"].Visible = false;
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdARQUIVO.InitialDirectory = "D:/fotos/Produtos";
            ofdARQUIVO.FileName = "";
            ofdARQUIVO.ShowDialog();
            picFoto.ImageLocation = ofdARQUIVO.FileName;
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            if (txtDESCRICAO.Text == "") return;

            p = new Produtos()
            {
                descricao = txtDESCRICAO.Text,
                idCategoria = (int)cmbCATEGORIAS.SelectedValue,
                idMarca = (int)cmbMARCAS.SelectedValue,
                estoque = double.Parse(txtESTOQUE.Text),
                valorVenda = double.Parse(txtVENDA.Text),
                foto = picFoto.ImageLocation
            };
            p.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dgvPRODUTOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPRODUTOS.RowCount > 0)
            {
                txtID.Text = dgvPRODUTOS.CurrentRow.Cells["id"].Value.ToString();
                txtDESCRICAO.Text = dgvPRODUTOS.CurrentRow.Cells["descricao"].Value.ToString();
                cmbCATEGORIAS.Text = dgvPRODUTOS.CurrentRow.Cells["categoria"].Value.ToString();
                cmbMARCAS.Text = dgvPRODUTOS.CurrentRow.Cells["marca"].Value.ToString();
                txtESTOQUE.Text = dgvPRODUTOS.CurrentRow.Cells["estoque"].Value.ToString();
                txtVENDA.Text = dgvPRODUTOS.CurrentRow.Cells["valorVenda"].Value.ToString();
                picFoto.ImageLocation = dgvPRODUTOS.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            if (txtDESCRICAO.Text == "") return;

            p = new Produtos()
            {
                descricao = txtDESCRICAO.Text,
                idCategoria = (int)cmbCATEGORIAS.SelectedValue,
                idMarca = (int)cmbMARCAS.SelectedValue,
                estoque = double.Parse(txtESTOQUE.Text),
                valorVenda = double.Parse(txtVENDA.Text),
                foto = picFoto.ImageLocation
            };
            p.Alterar();

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

            if (MessageBox.Show("Deseja excluir o produto?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                p = new Produtos()
                {
                    id = int.Parse(txtID.Text)
                };
                p.Excluir();

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
