namespace SistemaVenda.br.pro.com.view
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadatrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocaDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatasistema = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 10);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.toolStripMenuItem1});
            this.clientesToolStripMenuItem.Image = global::SistemaVenda.Properties.Resources.cliente;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(101, 44);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Cadastrar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarFuncionario,
            this.cadastrarFuncionario});
            this.funcionáriosToolStripMenuItem.Image = global::SistemaVenda.Properties.Resources.Funcionario;
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(127, 44);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // consultarFuncionario
            // 
            this.consultarFuncionario.Name = "consultarFuncionario";
            this.consultarFuncionario.Size = new System.Drawing.Size(180, 22);
            this.consultarFuncionario.Text = "Consultar";
            this.consultarFuncionario.Click += new System.EventHandler(this.consultarFuncionario_Click);
            // 
            // cadastrarFuncionario
            // 
            this.cadastrarFuncionario.Name = "cadastrarFuncionario";
            this.cadastrarFuncionario.Size = new System.Drawing.Size(180, 22);
            this.cadastrarFuncionario.Text = "Cadastrar";
            this.cadastrarFuncionario.Click += new System.EventHandler(this.cadastrarFuncionario_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem2,
            this.cadastrarToolStripMenuItem2});
            this.fornecedoresToolStripMenuItem.Image = global::SistemaVenda.Properties.Resources.Forncedores;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(130, 44);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            this.consultarToolStripMenuItem2.Click += new System.EventHandler(this.consultarToolStripMenuItem2_Click);
            // 
            // cadastrarToolStripMenuItem2
            // 
            this.cadastrarToolStripMenuItem2.Name = "cadastrarToolStripMenuItem2";
            this.cadastrarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cadastrarToolStripMenuItem2.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem2.Click += new System.EventHandler(this.cadastrarToolStripMenuItem2_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem3,
            this.cadatrarToolStripMenuItem});
            this.produtosToolStripMenuItem.Image = global::SistemaVenda.Properties.Resources.Produtos;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(107, 44);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem3.Text = "Consultar Produto";
            this.consultarToolStripMenuItem3.Click += new System.EventHandler(this.consultarToolStripMenuItem3_Click);
            // 
            // cadatrarToolStripMenuItem
            // 
            this.cadatrarToolStripMenuItem.Name = "cadatrarToolStripMenuItem";
            this.cadatrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadatrarToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadatrarToolStripMenuItem.Click += new System.EventHandler(this.cadatrarToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoDeVendaToolStripMenuItem,
            this.produrarVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Image = global::SistemaVenda.Properties.Resources.Venda;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(96, 44);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // históricoDeVendaToolStripMenuItem
            // 
            this.históricoDeVendaToolStripMenuItem.Name = "históricoDeVendaToolStripMenuItem";
            this.históricoDeVendaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.históricoDeVendaToolStripMenuItem.Text = "Histórico de Venda";
            this.históricoDeVendaToolStripMenuItem.Click += new System.EventHandler(this.históricoDeVendaToolStripMenuItem_Click);
            // 
            // produrarVendaToolStripMenuItem
            // 
            this.produrarVendaToolStripMenuItem.Name = "produrarVendaToolStripMenuItem";
            this.produrarVendaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.produrarVendaToolStripMenuItem.Text = "Venda";
            this.produrarVendaToolStripMenuItem.Click += new System.EventHandler(this.produrarVendaToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(48, 44);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocaDeUsuárioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Image = global::SistemaVenda.Properties.Resources.Configuração1;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(136, 44);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // trocaDeUsuárioToolStripMenuItem
            // 
            this.trocaDeUsuárioToolStripMenuItem.Name = "trocaDeUsuárioToolStripMenuItem";
            this.trocaDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.trocaDeUsuárioToolStripMenuItem.Text = "Troca de Usuário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Usuário:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(91, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // lblDatasistema
            // 
            this.lblDatasistema.AutoSize = true;
            this.lblDatasistema.Location = new System.Drawing.Point(44, 88);
            this.lblDatasistema.Name = "lblDatasistema";
            this.lblDatasistema.Size = new System.Drawing.Size(28, 13);
            this.lblDatasistema.TabIndex = 4;
            this.lblDatasistema.Text = "data";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatasistema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Tela Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cadatrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocaDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblDatasistema;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}