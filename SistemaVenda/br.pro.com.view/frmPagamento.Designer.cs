namespace SistemaVenda.br.pro.com.view
{
    partial class frmPagamento
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
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblCartao = new System.Windows.Forms.Label();
            this.lblPix = new System.Windows.Forms.Label();
            this.lblCrediario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.mtbCartao = new System.Windows.Forms.MaskedTextBox();
            this.mtbDinheiro = new System.Windows.Forms.MaskedTextBox();
            this.mtbPix = new System.Windows.Forms.MaskedTextBox();
            this.mtbCrediario = new System.Windows.Forms.MaskedTextBox();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtbSubTotal = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(33, 95);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(49, 13);
            this.lblDinheiro.TabIndex = 0;
            this.lblDinheiro.Text = "Dinheiro:";
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Location = new System.Drawing.Point(41, 128);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(41, 13);
            this.lblCartao.TabIndex = 1;
            this.lblCartao.Text = "Cartão:";
            // 
            // lblPix
            // 
            this.lblPix.AutoSize = true;
            this.lblPix.Location = new System.Drawing.Point(58, 155);
            this.lblPix.Name = "lblPix";
            this.lblPix.Size = new System.Drawing.Size(24, 13);
            this.lblPix.TabIndex = 2;
            this.lblPix.Text = "Pix:";
            // 
            // lblCrediario
            // 
            this.lblCrediario.AutoSize = true;
            this.lblCrediario.Location = new System.Drawing.Point(33, 178);
            this.lblCrediario.Name = "lblCrediario";
            this.lblCrediario.Size = new System.Drawing.Size(51, 13);
            this.lblCrediario.TabIndex = 3;
            this.lblCrediario.Text = "Crediário:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(48, 274);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(33, 296);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "SubTotal:";
            // 
            // mtbCartao
            // 
            this.mtbCartao.Location = new System.Drawing.Point(88, 125);
            this.mtbCartao.Name = "mtbCartao";
            this.mtbCartao.Size = new System.Drawing.Size(100, 20);
            this.mtbCartao.TabIndex = 6;
            // 
            // mtbDinheiro
            // 
            this.mtbDinheiro.Location = new System.Drawing.Point(88, 88);
            this.mtbDinheiro.Name = "mtbDinheiro";
            this.mtbDinheiro.Size = new System.Drawing.Size(100, 20);
            this.mtbDinheiro.TabIndex = 7;
            // 
            // mtbPix
            // 
            this.mtbPix.Location = new System.Drawing.Point(88, 152);
            this.mtbPix.Name = "mtbPix";
            this.mtbPix.Size = new System.Drawing.Size(100, 20);
            this.mtbPix.TabIndex = 8;
            // 
            // mtbCrediario
            // 
            this.mtbCrediario.Location = new System.Drawing.Point(88, 178);
            this.mtbCrediario.Name = "mtbCrediario";
            this.mtbCrediario.Size = new System.Drawing.Size(100, 20);
            this.mtbCrediario.TabIndex = 9;
            // 
            // mtbTotal
            // 
            this.mtbTotal.Location = new System.Drawing.Point(88, 267);
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.Size = new System.Drawing.Size(100, 20);
            this.mtbTotal.TabIndex = 10;
            // 
            // mtbSubTotal
            // 
            this.mtbSubTotal.Location = new System.Drawing.Point(88, 296);
            this.mtbSubTotal.Name = "mtbSubTotal";
            this.mtbSubTotal.Size = new System.Drawing.Size(100, 20);
            this.mtbSubTotal.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 288);
            this.textBox1.TabIndex = 12;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(310, 72);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(68, 13);
            this.lblObservacao.TabIndex = 13;
            this.lblObservacao.Text = "Observação:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(511, 396);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(98, 42);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(213, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 42);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mtbSubTotal);
            this.Controls.Add(this.mtbTotal);
            this.Controls.Add(this.mtbCrediario);
            this.Controls.Add(this.mtbPix);
            this.Controls.Add(this.mtbDinheiro);
            this.Controls.Add(this.mtbCartao);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCrediario);
            this.Controls.Add(this.lblPix);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.lblDinheiro);
            this.Name = "frmPagamento";
            this.Text = "Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblPix;
        private System.Windows.Forms.Label lblCrediario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.MaskedTextBox mtbCartao;
        private System.Windows.Forms.MaskedTextBox mtbDinheiro;
        private System.Windows.Forms.MaskedTextBox mtbPix;
        private System.Windows.Forms.MaskedTextBox mtbCrediario;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.MaskedTextBox mtbSubTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}