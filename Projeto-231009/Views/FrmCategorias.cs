using Projeto_231009.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_231009.Views
{
    public partial class FrmCategorias : Form
    {
        Categorias c;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtID.Clear();
            txtCATEGORIA.Clear();
            txtPESQUISAR.Clear();
        }

        void carregarGrid(string pesquisar)
        {
            c = new Categorias()
            {
                categoria = pesquisar
            };
            dgvCATEGORIAS.DataSource = c.Consultar();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            if (txtCATEGORIA.Text == String.Empty) return;

            c = new Categorias()
            {
                categoria = txtCATEGORIA.Text
            };
            c.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dgvMARCAS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCATEGORIAS.RowCount > 0)
            {
                txtID.Text = dgvCATEGORIAS.CurrentRow.Cells["id"].Value.ToString();
                txtCATEGORIA.Text = dgvCATEGORIAS.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            c = new Categorias()
            {
                id = int.Parse(txtID.Text),
                categoria = txtCATEGORIA.Text
            };
            c.Alterar();

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

            if (MessageBox.Show("Deseja excluir a marca?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Categorias()
                {
                    id = int.Parse(txtID.Text)
                };
                c.Excluir();

                limparControles();
                carregarGrid("");
            }
        }

        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPESQUISAR_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPESQUISAR.Text);
        }
    }
}