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
    public partial class FrmMarcas : Form
    {
        Marcas m;
        public FrmMarcas()
        {
            InitializeComponent();
        }

        void limparControles()
        {
            txtID.Clear();
            txtMARCA.Clear();
            txtPESQUISAR.Clear();
        }

        void carregarGrid(string pesquisar)
        {
            m = new Marcas()
            {
                marca = pesquisar
            };
            dgvMARCAS.DataSource = m.Consultar();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            if (txtMARCA.Text == String.Empty) return;

            m = new Marcas()
            {
                marca = txtMARCA.Text
            };
            m.Incluir();

            limparControles();
            carregarGrid("");
        }

        private void dgvMARCAS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMARCAS.RowCount > 0)
            {
                txtID.Text = dgvMARCAS.CurrentRow.Cells["id"].Value.ToString();
                txtMARCA.Text = dgvMARCAS.CurrentRow.Cells["marca"].Value.ToString();
            }
        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            m = new Marcas()
            {
                id = int.Parse(txtID.Text),
                marca = txtMARCA.Text
            };
            m.Alterar();

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
                m = new Marcas()
                {
                    id = int.Parse(txtID.Text)
                };
                m.Excluir();

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
