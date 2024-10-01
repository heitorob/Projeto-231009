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
    public partial class FrmCidades : Form
    {
        Cidades c;
        public FrmCidades()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtID.Clear();
            txtNOME.Clear();
            txtUF.Clear();
            txtPESQUISAR.Clear();
        }

        void carregarGrid(string pesquisar)
        {
            c = new Cidades()
            {
                nome = pesquisar
            };
            dgvCIDADES.DataSource = c.Consultar();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            if (txtNOME.Text == String.Empty) return;

            c = new Cidades()
            {
                nome = txtNOME.Text,
                uf = txtUF.Text,
            };
            c.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dgvCIDADES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCIDADES.RowCount > 0)
            {
                txtID.Text = dgvCIDADES.CurrentRow.Cells["id"].Value.ToString();
                txtNOME.Text = dgvCIDADES.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = dgvCIDADES.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            c = new Cidades()
            {
                id = int.Parse(txtID.Text),
                nome = txtNOME.Text,
                uf = txtUF.Text
            };
            c.Alterar();

            limparControles();
            carregarGrid("");
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidades()
                {
                    id = int.Parse(txtID.Text)
                };
                c.Excluir();

                limparControles();
                carregarGrid("");
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnPESQUISAR_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPESQUISAR.Text);
        }

        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
