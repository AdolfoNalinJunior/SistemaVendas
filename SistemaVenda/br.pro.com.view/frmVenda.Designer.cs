namespace SistemaVenda.br.pro.com.veiw
{
    partial class frmVenda
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
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.gbConsumidor = new System.Windows.Forms.GroupBox();
            this.mtbFone = new System.Windows.Forms.MaskedTextBox();
            this.lblFone = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeCon = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtDescricaoResumida = new System.Windows.Forms.TextBox();
            this.lblDescriçãoResumida = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.mtbSubTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontoReal = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.lblDescontoPor100 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.gbConsumidor.SuspendLayout();
            this.gbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(401, 72);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.Size = new System.Drawing.Size(384, 237);
            this.dgvVenda.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(445, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 43);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(623, 381);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 43);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // gbConsumidor
            // 
            this.gbConsumidor.Controls.Add(this.mtbFone);
            this.gbConsumidor.Controls.Add(this.lblFone);
            this.gbConsumidor.Controls.Add(this.txtEndereco);
            this.gbConsumidor.Controls.Add(this.lblEndereco);
            this.gbConsumidor.Controls.Add(this.txtNome);
            this.gbConsumidor.Controls.Add(this.lblNomeCon);
            this.gbConsumidor.Controls.Add(this.mtbCPF);
            this.gbConsumidor.Controls.Add(this.lblCPF);
            this.gbConsumidor.Controls.Add(this.txtID);
            this.gbConsumidor.Controls.Add(this.lblID);
            this.gbConsumidor.Location = new System.Drawing.Point(23, 31);
            this.gbConsumidor.Name = "gbConsumidor";
            this.gbConsumidor.Size = new System.Drawing.Size(372, 152);
            this.gbConsumidor.TabIndex = 10;
            this.gbConsumidor.TabStop = false;
            this.gbConsumidor.Text = "Consumidor";
            // 
            // mtbFone
            // 
            this.mtbFone.Location = new System.Drawing.Point(238, 45);
            this.mtbFone.Mask = "(00) 00000-0000";
            this.mtbFone.Name = "mtbFone";
            this.mtbFone.Size = new System.Drawing.Size(88, 20);
            this.mtbFone.TabIndex = 19;
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(203, 48);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(34, 13);
            this.lblFone.TabIndex = 18;
            this.lblFone.Text = "Fone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(80, 97);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(268, 37);
            this.txtEndereco.TabIndex = 17;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(24, 100);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 16;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(78, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 20);
            this.txtNome.TabIndex = 15;
            // 
            // lblNomeCon
            // 
            this.lblNomeCon.AutoSize = true;
            this.lblNomeCon.Location = new System.Drawing.Point(33, 74);
            this.lblNomeCon.Name = "lblNomeCon";
            this.lblNomeCon.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCon.TabIndex = 14;
            this.lblNomeCon.Text = "Nome:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(78, 45);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 20);
            this.mtbCPF.TabIndex = 13;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(42, 48);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(79, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(54, 20);
            this.txtID.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Código:";
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.btnAdicionar);
            this.gbProduto.Controls.Add(this.btnRemover);
            this.gbProduto.Controls.Add(this.txtQuantidade);
            this.gbProduto.Controls.Add(this.lblQuantidade);
            this.gbProduto.Controls.Add(this.txtDescricaoResumida);
            this.gbProduto.Controls.Add(this.lblDescriçãoResumida);
            this.gbProduto.Controls.Add(this.txtCodigoProduto);
            this.gbProduto.Controls.Add(this.lblCodigoProduto);
            this.gbProduto.Location = new System.Drawing.Point(23, 201);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(372, 157);
            this.gbProduto.TabIndex = 11;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(220, 98);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 43);
            this.btnAdicionar.TabIndex = 29;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(42, 98);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(112, 43);
            this.btnRemover.TabIndex = 28;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(225, 15);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(54, 20);
            this.txtQuantidade.TabIndex = 27;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(154, 18);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 26;
            this.lblQuantidade.Text = "Qauntidade:";
            // 
            // txtDescricaoResumida
            // 
            this.txtDescricaoResumida.Enabled = false;
            this.txtDescricaoResumida.Location = new System.Drawing.Point(75, 51);
            this.txtDescricaoResumida.Name = "txtDescricaoResumida";
            this.txtDescricaoResumida.Size = new System.Drawing.Size(268, 20);
            this.txtDescricaoResumida.TabIndex = 25;
            // 
            // lblDescriçãoResumida
            // 
            this.lblDescriçãoResumida.AutoSize = true;
            this.lblDescriçãoResumida.Location = new System.Drawing.Point(30, 54);
            this.lblDescriçãoResumida.Name = "lblDescriçãoResumida";
            this.lblDescriçãoResumida.Size = new System.Drawing.Size(38, 13);
            this.lblDescriçãoResumida.TabIndex = 24;
            this.lblDescriçãoResumida.Text = "Nome:";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Enabled = false;
            this.txtCodigoProduto.Location = new System.Drawing.Point(76, 15);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(54, 20);
            this.txtCodigoProduto.TabIndex = 23;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(31, 18);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoProduto.TabIndex = 22;
            this.lblCodigoProduto.Text = "Código:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(491, 36);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "Hora:";
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(527, 32);
            this.mtbHora.Mask = "90:00";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(38, 20);
            this.mtbHora.TabIndex = 14;
            this.mtbHora.ValidatingType = typeof(System.DateTime);
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(650, 31);
            this.mtbData.Mask = "99/99/9999";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(67, 20);
            this.mtbData.TabIndex = 16;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(614, 35);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 15;
            this.lblData.Text = "Data:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(436, 323);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // mtbSubTotal
            // 
            this.mtbSubTotal.Location = new System.Drawing.Point(490, 319);
            this.mtbSubTotal.Mask = "R$ ";
            this.mtbSubTotal.Name = "mtbSubTotal";
            this.mtbSubTotal.Size = new System.Drawing.Size(67, 20);
            this.mtbSubTotal.TabIndex = 18;
            this.mtbSubTotal.ValidatingType = typeof(System.DateTime);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(631, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(668, 319);
            this.maskedTextBox1.Mask = "R$ ";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBox1.TabIndex = 20;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(668, 348);
            this.maskedTextBox2.Mask = "R$ ";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBox2.TabIndex = 24;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // lblDescontoReal
            // 
            this.lblDescontoReal.AutoSize = true;
            this.lblDescontoReal.Location = new System.Drawing.Point(593, 352);
            this.lblDescontoReal.Name = "lblDescontoReal";
            this.lblDescontoReal.Size = new System.Drawing.Size(73, 13);
            this.lblDescontoReal.TabIndex = 23;
            this.lblDescontoReal.Text = "Desconto R$:";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(490, 345);
            this.maskedTextBox3.Mask = "R$ ";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBox3.TabIndex = 22;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // lblDescontoPor100
            // 
            this.lblDescontoPor100.AutoSize = true;
            this.lblDescontoPor100.Location = new System.Drawing.Point(422, 349);
            this.lblDescontoPor100.Name = "lblDescontoPor100";
            this.lblDescontoPor100.Size = new System.Drawing.Size(67, 13);
            this.lblDescontoPor100.TabIndex = 21;
            this.lblDescontoPor100.Text = "Desconto %:";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lblDescontoReal);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.lblDescontoPor100);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.mtbSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.gbConsumidor);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvVenda);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Vendas";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.gbConsumidor.ResumeLayout(false);
            this.gbConsumidor.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox gbConsumidor;
        private System.Windows.Forms.MaskedTextBox mtbFone;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeCon;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtDescricaoResumida;
        private System.Windows.Forms.Label lblDescriçãoResumida;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MaskedTextBox mtbHora;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.MaskedTextBox mtbSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblDescontoReal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label lblDescontoPor100;
    }
}