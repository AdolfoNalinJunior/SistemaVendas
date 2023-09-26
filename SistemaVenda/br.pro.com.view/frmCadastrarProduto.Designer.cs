namespace SistemaVenda.br.pro.com.view
{
    partial class frmCadastrarProduto
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
            this.lblImagem = new System.Windows.Forms.Label();
            this.mtbPrecoPrazo = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtDescricaoCompleta = new System.Windows.Forms.TextBox();
            this.lblDescricaoCompleta = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblPrecoPrazo = new System.Windows.Forms.Label();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.txtDescricaoResumida = new System.Windows.Forms.TextBox();
            this.lblDescricaoResumida = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.lblUnidadeMedida = new System.Windows.Forms.Label();
            this.mtbPrecoVista = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecoVista = new System.Windows.Forms.Label();
            this.mtbValorEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblValoEntrada = new System.Windows.Forms.Label();
            this.mtbValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbHora = new System.Windows.Forms.MaskedTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNumeroNota = new System.Windows.Forms.Label();
            this.mtbNumeroNota = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(608, 191);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(47, 13);
            this.lblImagem.TabIndex = 51;
            this.lblImagem.Text = "Imagem:";
            this.lblImagem.UseWaitCursor = true;
            // 
            // mtbPrecoPrazo
            // 
            this.mtbPrecoPrazo.Location = new System.Drawing.Point(611, 122);
            this.mtbPrecoPrazo.Mask = "R$";
            this.mtbPrecoPrazo.Name = "mtbPrecoPrazo";
            this.mtbPrecoPrazo.Size = new System.Drawing.Size(61, 20);
            this.mtbPrecoPrazo.TabIndex = 49;
            this.mtbPrecoPrazo.UseWaitCursor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(189, 24);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 48;
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.UseWaitCursor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.Location = new System.Drawing.Point(482, 330);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 39);
            this.btnSalvar.TabIndex = 47;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.UseWaitCursor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.Location = new System.Drawing.Point(397, 330);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 39);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.UseWaitCursor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.Location = new System.Drawing.Point(310, 330);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 39);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.UseWaitCursor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNovo.Location = new System.Drawing.Point(223, 330);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 39);
            this.btnNovo.TabIndex = 44;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.UseWaitCursor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtDescricaoCompleta
            // 
            this.txtDescricaoCompleta.Location = new System.Drawing.Point(124, 88);
            this.txtDescricaoCompleta.Multiline = true;
            this.txtDescricaoCompleta.Name = "txtDescricaoCompleta";
            this.txtDescricaoCompleta.Size = new System.Drawing.Size(383, 50);
            this.txtDescricaoCompleta.TabIndex = 43;
            this.txtDescricaoCompleta.UseWaitCursor = true;
            // 
            // lblDescricaoCompleta
            // 
            this.lblDescricaoCompleta.AutoSize = true;
            this.lblDescricaoCompleta.Location = new System.Drawing.Point(20, 91);
            this.lblDescricaoCompleta.Name = "lblDescricaoCompleta";
            this.lblDescricaoCompleta.Size = new System.Drawing.Size(105, 13);
            this.lblDescricaoCompleta.TabIndex = 42;
            this.lblDescricaoCompleta.Text = "Descrição Completa:";
            this.lblDescricaoCompleta.UseWaitCursor = true;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO\t"});
            this.cbFornecedor.Location = new System.Drawing.Point(592, 52);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(95, 21);
            this.cbFornecedor.TabIndex = 41;
            this.cbFornecedor.UseWaitCursor = true;
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Location = new System.Drawing.Point(521, 55);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(72, 13);
            this.lblFornecedores.TabIndex = 40;
            this.lblFornecedores.Text = "Fornecedores";
            this.lblFornecedores.UseWaitCursor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 20);
            this.txtCodigo.TabIndex = 39;
            this.txtCodigo.UseWaitCursor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(81, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseWaitCursor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(254, 21);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(47, 20);
            this.txtQuantidade.TabIndex = 37;
            this.txtQuantidade.UseWaitCursor = true;
            // 
            // lblPrecoPrazo
            // 
            this.lblPrecoPrazo.AutoSize = true;
            this.lblPrecoPrazo.Location = new System.Drawing.Point(536, 124);
            this.lblPrecoPrazo.Name = "lblPrecoPrazo";
            this.lblPrecoPrazo.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoPrazo.TabIndex = 36;
            this.lblPrecoPrazo.Text = "Preço a Prazo:";
            this.lblPrecoPrazo.UseWaitCursor = true;
            // 
            // pbProduto
            // 
            this.pbProduto.BackColor = System.Drawing.Color.LightGray;
            this.pbProduto.Location = new System.Drawing.Point(611, 209);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(153, 134);
            this.pbProduto.TabIndex = 50;
            this.pbProduto.TabStop = false;
            this.pbProduto.UseWaitCursor = true;
            // 
            // txtDescricaoResumida
            // 
            this.txtDescricaoResumida.Location = new System.Drawing.Point(124, 53);
            this.txtDescricaoResumida.Name = "txtDescricaoResumida";
            this.txtDescricaoResumida.Size = new System.Drawing.Size(383, 20);
            this.txtDescricaoResumida.TabIndex = 53;
            this.txtDescricaoResumida.UseWaitCursor = true;
            // 
            // lblDescricaoResumida
            // 
            this.lblDescricaoResumida.AutoSize = true;
            this.lblDescricaoResumida.Location = new System.Drawing.Point(15, 53);
            this.lblDescricaoResumida.Name = "lblDescricaoResumida";
            this.lblDescricaoResumida.Size = new System.Drawing.Size(108, 13);
            this.lblDescricaoResumida.TabIndex = 52;
            this.lblDescricaoResumida.Text = "Descrição Resumida:";
            this.lblDescricaoResumida.UseWaitCursor = true;
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO\t"});
            this.cbUnidadeMedida.Location = new System.Drawing.Point(519, 19);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(95, 21);
            this.cbUnidadeMedida.TabIndex = 55;
            this.cbUnidadeMedida.UseWaitCursor = true;
            // 
            // lblUnidadeMedida
            // 
            this.lblUnidadeMedida.AutoSize = true;
            this.lblUnidadeMedida.Location = new System.Drawing.Point(453, 22);
            this.lblUnidadeMedida.Name = "lblUnidadeMedida";
            this.lblUnidadeMedida.Size = new System.Drawing.Size(67, 13);
            this.lblUnidadeMedida.TabIndex = 54;
            this.lblUnidadeMedida.Text = "Uni. Medida:";
            this.lblUnidadeMedida.UseWaitCursor = true;
            // 
            // mtbPrecoVista
            // 
            this.mtbPrecoVista.Location = new System.Drawing.Point(611, 91);
            this.mtbPrecoVista.Mask = "R$";
            this.mtbPrecoVista.Name = "mtbPrecoVista";
            this.mtbPrecoVista.Size = new System.Drawing.Size(61, 20);
            this.mtbPrecoVista.TabIndex = 57;
            this.mtbPrecoVista.UseWaitCursor = true;
            // 
            // lblPrecoVista
            // 
            this.lblPrecoVista.AutoSize = true;
            this.lblPrecoVista.Location = new System.Drawing.Point(539, 94);
            this.lblPrecoVista.Name = "lblPrecoVista";
            this.lblPrecoVista.Size = new System.Drawing.Size(73, 13);
            this.lblPrecoVista.TabIndex = 56;
            this.lblPrecoVista.Text = "Preço a Vista:";
            this.lblPrecoVista.UseWaitCursor = true;
            // 
            // mtbValorEntrada
            // 
            this.mtbValorEntrada.Location = new System.Drawing.Point(382, 20);
            this.mtbValorEntrada.Mask = "R$";
            this.mtbValorEntrada.Name = "mtbValorEntrada";
            this.mtbValorEntrada.Size = new System.Drawing.Size(61, 20);
            this.mtbValorEntrada.TabIndex = 59;
            this.mtbValorEntrada.UseWaitCursor = true;
            // 
            // lblValoEntrada
            // 
            this.lblValoEntrada.AutoSize = true;
            this.lblValoEntrada.Location = new System.Drawing.Point(309, 24);
            this.lblValoEntrada.Name = "lblValoEntrada";
            this.lblValoEntrada.Size = new System.Drawing.Size(73, 13);
            this.lblValoEntrada.TabIndex = 58;
            this.lblValoEntrada.Text = "Valor entrada:";
            this.lblValoEntrada.UseWaitCursor = true;
            // 
            // mtbValorTotal
            // 
            this.mtbValorTotal.Location = new System.Drawing.Point(693, 19);
            this.mtbValorTotal.Mask = "R$";
            this.mtbValorTotal.Name = "mtbValorTotal";
            this.mtbValorTotal.Size = new System.Drawing.Size(61, 20);
            this.mtbValorTotal.TabIndex = 61;
            this.mtbValorTotal.UseWaitCursor = true;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(636, 22);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblValorTotal.TabIndex = 60;
            this.lblValorTotal.Text = "Valor Total:";
            this.lblValorTotal.UseWaitCursor = true;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(717, 91);
            this.mtbData.Mask = "99/99/9999";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(61, 20);
            this.mtbData.TabIndex = 63;
            this.mtbData.UseWaitCursor = true;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(680, 94);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 62;
            this.lblData.Text = "Data:";
            this.lblData.UseWaitCursor = true;
            // 
            // mtbHora
            // 
            this.mtbHora.Location = new System.Drawing.Point(717, 124);
            this.mtbHora.Mask = "99:99";
            this.mtbHora.Name = "mtbHora";
            this.mtbHora.Size = new System.Drawing.Size(37, 20);
            this.mtbHora.TabIndex = 65;
            this.mtbHora.UseWaitCursor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(680, 127);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 64;
            this.lblHora.Text = "Hora:";
            this.lblHora.UseWaitCursor = true;
            // 
            // lblNumeroNota
            // 
            this.lblNumeroNota.AutoSize = true;
            this.lblNumeroNota.Location = new System.Drawing.Point(38, 147);
            this.lblNumeroNota.Name = "lblNumeroNota";
            this.lblNumeroNota.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroNota.TabIndex = 66;
            this.lblNumeroNota.Text = "Núemro da NFe:";
            this.lblNumeroNota.UseWaitCursor = true;
            // 
            // mtbNumeroNota
            // 
            this.mtbNumeroNota.Location = new System.Drawing.Point(124, 144);
            this.mtbNumeroNota.Mask = "9999999999";
            this.mtbNumeroNota.Name = "mtbNumeroNota";
            this.mtbNumeroNota.Size = new System.Drawing.Size(61, 20);
            this.mtbNumeroNota.TabIndex = 67;
            this.mtbNumeroNota.UseWaitCursor = true;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtbNumeroNota);
            this.Controls.Add(this.lblNumeroNota);
            this.Controls.Add(this.mtbHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.mtbValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.mtbValorEntrada);
            this.Controls.Add(this.lblValoEntrada);
            this.Controls.Add(this.mtbPrecoVista);
            this.Controls.Add(this.lblPrecoVista);
            this.Controls.Add(this.cbUnidadeMedida);
            this.Controls.Add(this.lblUnidadeMedida);
            this.Controls.Add(this.txtDescricaoResumida);
            this.Controls.Add(this.lblDescricaoResumida);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.mtbPrecoPrazo);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtDescricaoCompleta);
            this.Controls.Add(this.lblDescricaoCompleta);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.lblFornecedores);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblPrecoPrazo);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblDescricaoCompleta;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecoPrazo;
        private System.Windows.Forms.Label lblDescricaoResumida;
        private System.Windows.Forms.Label lblUnidadeMedida;
        private System.Windows.Forms.Label lblPrecoVista;
        private System.Windows.Forms.Label lblValoEntrada;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblNumeroNota;
        public System.Windows.Forms.PictureBox pbProduto;
        public System.Windows.Forms.MaskedTextBox mtbPrecoPrazo;
        public System.Windows.Forms.TextBox txtDescricaoCompleta;
        public System.Windows.Forms.ComboBox cbFornecedor;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtDescricaoResumida;
        public System.Windows.Forms.ComboBox cbUnidadeMedida;
        public System.Windows.Forms.MaskedTextBox mtbPrecoVista;
        public System.Windows.Forms.MaskedTextBox mtbValorEntrada;
        public System.Windows.Forms.MaskedTextBox mtbValorTotal;
        public System.Windows.Forms.MaskedTextBox mtbData;
        public System.Windows.Forms.MaskedTextBox mtbHora;
        public System.Windows.Forms.MaskedTextBox mtbNumeroNota;
    }
}