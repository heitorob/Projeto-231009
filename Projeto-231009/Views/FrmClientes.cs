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


    }
}
