namespace SistemaVenda.br.pro.com.view
{
    partial class frmConsultarFuncionario
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgFuncionario = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(359, 63);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgFuncionario
            // 
            this.dgFuncionario.AllowUserToAddRows = false;
            this.dgFuncionario.AllowUserToDeleteRows = false;
            this.dgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionario.Location = new System.Drawing.Point(28, 115);
            this.dgFuncionario.Name = "dgFuncionario";
            this.dgFuncionario.ReadOnly = true;
            this.dgFuncionario.Size = new System.Drawing.Size(744, 273);
            this.dgFuncionario.TabIndex = 6;
            this.dgFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncionario_CellContentClick);
            this.dgFuncionario.DoubleClick += new System.EventHandler(this.dgFuncionario_DoubleClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(47, 68);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 4;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgFuncionario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPesquisar);
            this.Name = "frmConsultarFuncionario";
            this.Text = "Consultar Funcionario";
            this.Load += new System.EventHandler(this.frmConsultarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.DataGridView dgFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPesquisar;
    }
}