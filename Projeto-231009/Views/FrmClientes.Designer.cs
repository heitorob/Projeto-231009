namespace Projeto_231009.Views
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCLIENTES = new System.Windows.Forms.DataGridView();
            this.txtPESQUISAR = new System.Windows.Forms.TextBox();
            this.btnPESQUISAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.btnINCLUIR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtRENDA = new System.Windows.Forms.TextBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cmbCIDADES = new System.Windows.Forms.ComboBox();
            this.dtpNASCIMENTO = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkVENDA = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ofdARQUIVO = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCLIENTES);
            this.groupBox1.Controls.Add(this.txtPESQUISAR);
            this.groupBox1.Controls.Add(this.btnPESQUISAR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 385);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // dgvCLIENTES
            // 
            this.dgvCLIENTES.AllowUserToAddRows = false;
            this.dgvCLIENTES.AllowUserToDeleteRows = false;
            this.dgvCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLIENTES.Location = new System.Drawing.Point(30, 85);
            this.dgvCLIENTES.Name = "dgvCLIENTES";
            this.dgvCLIENTES.ReadOnly = true;
            this.dgvCLIENTES.Size = new System.Drawing.Size(706, 271);
            this.dgvCLIENTES.TabIndex = 9;
            this.dgvCLIENTES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCLIENTES_CellClick);
            // 
            // txtPESQUISAR
            // 
            this.txtPESQUISAR.Location = new System.Drawing.Point(30, 56);
            this.txtPESQUISAR.Name = "txtPESQUISAR";
            this.txtPESQUISAR.Size = new System.Drawing.Size(612, 20);
            this.txtPESQUISAR.TabIndex = 8;
            // 
            // btnPESQUISAR
            // 
            this.btnPESQUISAR.Location = new System.Drawing.Point(648, 10);
            this.btnPESQUISAR.Name = "btnPESQUISAR";
            this.btnPESQUISAR.Size = new System.Drawing.Size(88, 66);
            this.btnPESQUISAR.TabIndex = 4;
            this.btnPESQUISAR.Text = "Pesquisar";
            this.btnPESQUISAR.UseVisualStyleBackColor = true;
            this.btnPESQUISAR.Click += new System.EventHandler(this.btnPESQUISAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o Nome da Cidade para Pesquisar:\r\n";
            // 
            // txtUF
            // 
            this.txtUF.Enabled = false;
            this.txtUF.Location = new System.Drawing.Point(463, 178);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 20);
            this.txtUF.TabIndex = 21;
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(54, 115);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(509, 20);
            this.txtNOME.TabIndex = 20;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(54, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 19;
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Location = new System.Drawing.Point(634, 298);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(126, 58);
            this.btnFECHAR.TabIndex = 14;
            this.btnFECHAR.Text = "Fechar";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(489, 298);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnEXCLUIR.TabIndex = 15;
            this.btnEXCLUIR.Text = "Excluir";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(344, 298);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(126, 58);
            this.btnCANCELAR.TabIndex = 16;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(199, 298);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(126, 58);
            this.btnALTERAR.TabIndex = 17;
            this.btnALTERAR.Text = "Alterar";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // btnINCLUIR
            // 
            this.btnINCLUIR.Location = new System.Drawing.Point(54, 298);
            this.btnINCLUIR.Name = "btnINCLUIR";
            this.btnINCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnINCLUIR.TabIndex = 18;
            this.btnINCLUIR.Text = "Incluir";
            this.btnINCLUIR.UseVisualStyleBackColor = true;
            this.btnINCLUIR.Click += new System.EventHandler(this.btnINCLUIR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "UF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(54, 251);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(194, 20);
            this.mskCPF.TabIndex = 23;
            // 
            // txtRENDA
            // 
            this.txtRENDA.Location = new System.Drawing.Point(590, 251);
            this.txtRENDA.Name = "txtRENDA";
            this.txtRENDA.Size = new System.Drawing.Size(170, 20);
            this.txtRENDA.TabIndex = 19;
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(580, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(200, 186);
            this.picFoto.TabIndex = 24;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // cmbCIDADES
            // 
            this.cmbCIDADES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCIDADES.FormattingEnabled = true;
            this.cmbCIDADES.Location = new System.Drawing.Point(54, 177);
            this.cmbCIDADES.Name = "cmbCIDADES";
            this.cmbCIDADES.Size = new System.Drawing.Size(403, 21);
            this.cmbCIDADES.TabIndex = 25;
            // 
            // dtpNASCIMENTO
            // 
            this.dtpNASCIMENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNASCIMENTO.Location = new System.Drawing.Point(319, 251);
            this.dtpNASCIMENTO.Name = "dtpNASCIMENTO";
            this.dtpNASCIMENTO.Size = new System.Drawing.Size(200, 20);
            this.dtpNASCIMENTO.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Renda";
            // 
            // chkVENDA
            // 
            this.chkVENDA.AutoSize = true;
            this.chkVENDA.Location = new System.Drawing.Point(276, 60);
            this.chkVENDA.Name = "chkVENDA";
            this.chkVENDA.Size = new System.Drawing.Size(116, 17);
            this.chkVENDA.TabIndex = 28;
            this.chkVENDA.Text = "Bloqueia a Venda?";
            this.chkVENDA.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cidade:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.chkVENDA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNASCIMENTO);
            this.Controls.Add(this.cmbCIDADES);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.txtRENDA);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.btnINCLUIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCLIENTES;
        private System.Windows.Forms.TextBox txtPESQUISAR;
        private System.Windows.Forms.Button btnPESQUISAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnFECHAR;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.Button btnINCLUIR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtRENDA;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cmbCIDADES;
        private System.Windows.Forms.DateTimePicker dtpNASCIMENTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkVENDA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog ofdARQUIVO;
    }
}