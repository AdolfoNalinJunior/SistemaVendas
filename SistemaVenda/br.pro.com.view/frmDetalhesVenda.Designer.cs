namespace SistemaVenda.br.pro.com.view
{
    partial class frmDetalhesVenda
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
            this.gbDetalheVenda = new System.Windows.Forms.GroupBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.lblCodigoVenda = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.gbDetalheVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetalheVenda
            // 
            this.gbDetalheVenda.Controls.Add(this.txtValorTotal);
            this.gbDetalheVenda.Controls.Add(this.lblValorTotal);
            this.gbDetalheVenda.Controls.Add(this.txtObs);
            this.gbDetalheVenda.Controls.Add(this.lblObservacao);
            this.gbDetalheVenda.Controls.Add(this.txtCodigoVenda);
            this.gbDetalheVenda.Controls.Add(this.lblCodigoVenda);
            this.gbDetalheVenda.Controls.Add(this.maskedTextBox1);
            this.gbDetalheVenda.Controls.Add(this.lblHora);
            this.gbDetalheVenda.Controls.Add(this.mtbData);
            this.gbDetalheVenda.Controls.Add(this.lblData);
            this.gbDetalheVenda.Controls.Add(this.txtNome);
            this.gbDetalheVenda.Controls.Add(this.lblNome);
            this.gbDetalheVenda.Location = new System.Drawing.Point(12, 12);
            this.gbDetalheVenda.Name = "gbDetalheVenda";
            this.gbDetalheVenda.Size = new System.Drawing.Size(776, 104);
            this.gbDetalheVenda.TabIndex = 0;
            this.gbDetalheVenda.TabStop = false;
            this.gbDetalheVenda.Text = "Dados";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(530, 48);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(61, 20);
            this.txtValorTotal.TabIndex = 11;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(463, 51);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblValorTotal.TabIndex = 10;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(99, 48);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(348, 30);
            this.txtObs.TabIndex = 9;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(11, 51);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(82, 13);
            this.lblObservacao.TabIndex = 8;
            this.lblObservacao.Text = "Oberservações:";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(694, 13);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(45, 20);
            this.txtCodigoVenda.TabIndex = 7;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(620, 16);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(77, 13);
            this.lblCodigoVenda.TabIndex = 6;
            this.lblCodigoVenda.Text = "Código Venda:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(566, 13);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(527, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(442, 13);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(67, 20);
            this.mtbData.TabIndex = 3;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(403, 16);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(311, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // dgVenda
            // 
            this.dgVenda.AllowUserToAddRows = false;
            this.dgVenda.AllowUserToDeleteRows = false;
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Location = new System.Drawing.Point(12, 133);
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.ReadOnly = true;
            this.dgVenda.Size = new System.Drawing.Size(776, 232);
            this.dgVenda.TabIndex = 1;
            this.dgVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenda_CellContentClick);
            // 
            // frmDetalhesVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgVenda);
            this.Controls.Add(this.gbDetalheVenda);
            this.Name = "frmDetalhesVenda";
            this.Text = "Detalhes das Vendas";
            this.Load += new System.EventHandler(this.frmDetalhesVenda_Load);
            this.gbDetalheVenda.ResumeLayout(false);
            this.gbDetalheVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalheVenda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblCodigoVenda;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValorTotal;
        public System.Windows.Forms.DataGridView dgVenda;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtObs;
        public System.Windows.Forms.TextBox txtCodigoVenda;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.TextBox txtValorTotal;
    }
}