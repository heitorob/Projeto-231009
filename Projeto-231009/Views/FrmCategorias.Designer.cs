namespace Projeto_231009.Views
{
    partial class FrmCategorias
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
            this.dgvCATEGORIAS = new System.Windows.Forms.DataGridView();
            this.txtPESQUISAR = new System.Windows.Forms.TextBox();
            this.btnPESQUISAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCATEGORIA = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.btnINCLUIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIAS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCATEGORIAS);
            this.groupBox1.Controls.Add(this.txtPESQUISAR);
            this.groupBox1.Controls.Add(this.btnPESQUISAR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 385);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // dgvCATEGORIAS
            // 
            this.dgvCATEGORIAS.AllowUserToAddRows = false;
            this.dgvCATEGORIAS.AllowUserToDeleteRows = false;
            this.dgvCATEGORIAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCATEGORIAS.Location = new System.Drawing.Point(30, 85);
            this.dgvCATEGORIAS.Name = "dgvCATEGORIAS";
            this.dgvCATEGORIAS.ReadOnly = true;
            this.dgvCATEGORIAS.Size = new System.Drawing.Size(706, 271);
            this.dgvCATEGORIAS.TabIndex = 9;
            this.dgvCATEGORIAS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMARCAS_CellClick);
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
            this.label4.Size = new System.Drawing.Size(213, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o Nome da Categoria para Pesquisar:\r\n";
            // 
            // txtCATEGORIA
            // 
            this.txtCATEGORIA.Location = new System.Drawing.Point(54, 115);
            this.txtCATEGORIA.Name = "txtCATEGORIA";
            this.txtCATEGORIA.Size = new System.Drawing.Size(561, 20);
            this.txtCATEGORIA.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(54, 57);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(126, 20);
            this.txtID.TabIndex = 28;
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Location = new System.Drawing.Point(634, 183);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(126, 58);
            this.btnFECHAR.TabIndex = 23;
            this.btnFECHAR.Text = "Fechar";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.Location = new System.Drawing.Point(489, 183);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnEXCLUIR.TabIndex = 24;
            this.btnEXCLUIR.Text = "Excluir";
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(344, 183);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(126, 58);
            this.btnCANCELAR.TabIndex = 25;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(199, 183);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(126, 58);
            this.btnALTERAR.TabIndex = 26;
            this.btnALTERAR.Text = "Alterar";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // btnINCLUIR
            // 
            this.btnINCLUIR.Location = new System.Drawing.Point(54, 183);
            this.btnINCLUIR.Name = "btnINCLUIR";
            this.btnINCLUIR.Size = new System.Drawing.Size(126, 58);
            this.btnINCLUIR.TabIndex = 27;
            this.btnINCLUIR.Text = "Incluir";
            this.btnINCLUIR.UseVisualStyleBackColor = true;
            this.btnINCLUIR.Click += new System.EventHandler(this.btnINCLUIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código:";
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCATEGORIA);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnEXCLUIR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.btnINCLUIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCATEGORIAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCATEGORIAS;
        private System.Windows.Forms.TextBox txtPESQUISAR;
        private System.Windows.Forms.Button btnPESQUISAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCATEGORIA;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnFECHAR;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.Button btnINCLUIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}