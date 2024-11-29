namespace Projeto_231009.Views
{
    partial class FrmProdutos
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCATEGORIAS = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPRODUTOS = new System.Windows.Forms.DataGridView();
            this.txtPESQUISAR = new System.Windows.Forms.TextBox();
            this.btnPESQUISAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDESCRICAO = new System.Windows.Forms.TextBox();
            this.txtVENDA = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.btnINCLUIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMARCAS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtESTOQUE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ofdARQUIVO = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Valor de Venda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Categorias:";
            // 
            // cmbCATEGORIAS
            // 
            this.cmbCATEGORIAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCATEGORIAS.FormattingEnabled = true;
            this.cmbCATEGORIAS.Location = new System.Drawing.Point(54, 177);
            this.cmbCATEGORIAS.Name = "cmbCATEGORIAS";
            this.cmbCATEGORIAS.Size = new System.Drawing.Size(271, 21);
            this.cmbCATEGORIAS.TabIndex = 44;
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(580, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(200, 186);
            this.picFoto.TabIndex = 43;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPRODUTOS);
            this.groupBox1.Controls.Add(this.txtPESQUISAR);
            this.groupBox1.Controls.Add(this.btnPESQUISAR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 385);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // dgvPRODUTOS
            // 
            this.dgvPRODUTOS.AllowUserToAddRows = false;
            this.dgvPRODUTOS.AllowUserToDeleteRows = false;
            this.dgvPRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUTOS.Location = new System.Drawing.Point(30, 85);
            this.dgvPRODUTOS.Name = "dgvPRODUTOS";
            this.dgvPRODUTOS.ReadOnly = true;
            this.dgvPRODUTOS.Size = new System.Drawing.Size(706, 271);
            this.dgvPRODUTOS.TabIndex = 9;
            this.dgvPRODUTOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRODUTOS_CellClick);
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
            // txtDESCRICAO
            // 
            this.txtDESCRICAO.Location = new System.Drawing.Point(54, 115);
            this.txtDESCRICAO.Name = "txtDESCRICAO";
            this.txtDESCRICAO.Size = new System.Drawing.Size(509, 20);
            this.txtDESCRICAO.TabIndex = 39;
            // 
            // txtVENDA
            // 
            this.txtVENDA.Location = new System.Drawing.Point(590, 251);
            this.txtVENDA.Name = "txtVENDA";
            this.txtVENDA.Size = new System.Drawing.Size(170, 20);
            this.txtVENDA.TabIndex = 38;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(54, 57);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 37;
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Location = new System.Drawing.Point(634, 298);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(126, 58);
            this.btnFECHAR.TabIndex = 32;
            this.btnFECHAR.Text = "Fechar";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(489, 298);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnEXCLUIR.TabIndex = 33;
            this.btnEXCLUIR.Text = "Excluir";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(344, 298);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(126, 58);
            this.btnCANCELAR.TabIndex = 34;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(199, 298);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(126, 58);
            this.btnALTERAR.TabIndex = 35;
            this.btnALTERAR.Text = "Alterar";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // btnINCLUIR
            // 
            this.btnINCLUIR.Location = new System.Drawing.Point(54, 298);
            this.btnINCLUIR.Name = "btnINCLUIR";
            this.btnINCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnINCLUIR.TabIndex = 36;
            this.btnINCLUIR.Text = "Incluir";
            this.btnINCLUIR.UseVisualStyleBackColor = true;
            this.btnINCLUIR.Click += new System.EventHandler(this.btnINCLUIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código:";
            // 
            // cmbMARCAS
            // 
            this.cmbMARCAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMARCAS.FormattingEnabled = true;
            this.cmbMARCAS.Location = new System.Drawing.Point(54, 250);
            this.cmbMARCAS.Name = "cmbMARCAS";
            this.cmbMARCAS.Size = new System.Drawing.Size(271, 21);
            this.cmbMARCAS.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Marcas:";
            // 
            // txtESTOQUE
            // 
            this.txtESTOQUE.Location = new System.Drawing.Point(371, 251);
            this.txtESTOQUE.Name = "txtESTOQUE";
            this.txtESTOQUE.Size = new System.Drawing.Size(170, 20);
            this.txtESTOQUE.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Estoque";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbMARCAS);
            this.Controls.Add(this.cmbCATEGORIAS);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDESCRICAO);
            this.Controls.Add(this.txtESTOQUE);
            this.Controls.Add(this.txtVENDA);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.btnINCLUIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCATEGORIAS;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPRODUTOS;
        private System.Windows.Forms.TextBox txtPESQUISAR;
        private System.Windows.Forms.Button btnPESQUISAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDESCRICAO;
        private System.Windows.Forms.TextBox txtVENDA;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnFECHAR;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.Button btnINCLUIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMARCAS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtESTOQUE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofdARQUIVO;
    }
}