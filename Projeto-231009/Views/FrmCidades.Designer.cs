namespace Projeto_231009.Views
{
    partial class FrmCidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnINCLUIR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.btnPESQUISAR = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtPESQUISAR = new System.Windows.Forms.TextBox();
            this.dgvCIDADES = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCIDADES)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UF:";
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
            // btnINCLUIR
            // 
            this.btnINCLUIR.Location = new System.Drawing.Point(54, 183);
            this.btnINCLUIR.Name = "btnINCLUIR";
            this.btnINCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnINCLUIR.TabIndex = 4;
            this.btnINCLUIR.Text = "Incluir";
            this.btnINCLUIR.UseVisualStyleBackColor = true;
            this.btnINCLUIR.Click += new System.EventHandler(this.btnINCLUIR_Click);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(199, 183);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(126, 58);
            this.btnALTERAR.TabIndex = 4;
            this.btnALTERAR.Text = "Alterar";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(344, 183);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(126, 58);
            this.btnCANCELAR.TabIndex = 4;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(489, 183);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnEXCLUIR.TabIndex = 4;
            this.btnEXCLUIR.Text = "Excluir";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Location = new System.Drawing.Point(634, 183);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(126, 58);
            this.btnFECHAR.TabIndex = 4;
            this.btnFECHAR.Text = "Fechar";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
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
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(54, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(54, 115);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(561, 20);
            this.txtNOME.TabIndex = 6;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(634, 115);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(100, 20);
            this.txtUF.TabIndex = 7;
            // 
            // txtPESQUISAR
            // 
            this.txtPESQUISAR.Location = new System.Drawing.Point(30, 56);
            this.txtPESQUISAR.Name = "txtPESQUISAR";
            this.txtPESQUISAR.Size = new System.Drawing.Size(612, 20);
            this.txtPESQUISAR.TabIndex = 8;
            // 
            // dgvCIDADES
            // 
            this.dgvCIDADES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCIDADES.Location = new System.Drawing.Point(30, 85);
            this.dgvCIDADES.Name = "dgvCIDADES";
            this.dgvCIDADES.Size = new System.Drawing.Size(706, 271);
            this.dgvCIDADES.TabIndex = 9;
            this.dgvCIDADES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCIDADES_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCIDADES);
            this.groupBox1.Controls.Add(this.txtPESQUISAR);
            this.groupBox1.Controls.Add(this.btnPESQUISAR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 385);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // FrmCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.btnINCLUIR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.Load += new System.EventHandler(this.FrmCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCIDADES)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnINCLUIR;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnFECHAR;
        private System.Windows.Forms.Button btnPESQUISAR;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtPESQUISAR;
        private System.Windows.Forms.DataGridView dgvCIDADES;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}