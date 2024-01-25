namespace Almoxarifado
{
    partial class frmEntrProd
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodUsado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAlterar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.almoxarifadoDataSet = new Almoxarifado.AlmoxarifadoDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Almoxarifado.AlmoxarifadoDataSetTableAdapters.ProdutoTableAdapter();
            this.excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.excluirProd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almoxarifadoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.excluirProd);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnProduto);
            this.groupBox1.Controls.Add(this.dgvProdutos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(7, 62);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(117, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(6, 104);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(117, 23);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(142, 374);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(715, 78);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(7, 20);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(117, 23);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Novo Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCodigo,
            this.Nome,
            this.valorUni,
            this.prodUsado,
            this.descricaoProd,
            this.checkAlterar,
            this.excluir});
            this.dgvProdutos.DataSource = this.almoxarifadoDataSet;
            this.dgvProdutos.Location = new System.Drawing.Point(142, 12);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(715, 356);
            this.dgvProdutos.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataPropertyName = "Id";
            this.txtCodigo.HeaderText = "Código";
            this.txtCodigo.Name = "txtCodigo";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome Produto";
            this.Nome.Name = "Nome";
            // 
            // valorUni
            // 
            this.valorUni.DataPropertyName = "ValorUn";
            this.valorUni.HeaderText = "Valor Unitario";
            this.valorUni.Name = "valorUni";
            this.valorUni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valorUni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prodUsado
            // 
            this.prodUsado.DataPropertyName = "Usado";
            this.prodUsado.HeaderText = "Usado?";
            this.prodUsado.Name = "prodUsado";
            this.prodUsado.ReadOnly = true;
            // 
            // descricaoProd
            // 
            this.descricaoProd.DataPropertyName = "Especificacao";
            this.descricaoProd.HeaderText = "Descrição";
            this.descricaoProd.Name = "descricaoProd";
            // 
            // checkAlterar
            // 
            this.checkAlterar.HeaderText = "Alterar?";
            this.checkAlterar.Name = "checkAlterar";
            // 
            // almoxarifadoDataSet
            // 
            this.almoxarifadoDataSet.DataSetName = "AlmoxarifadoDataSet";
            this.almoxarifadoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.almoxarifadoDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            // 
            // excluirProd
            // 
            this.excluirProd.Location = new System.Drawing.Point(5, 146);
            this.excluirProd.Name = "excluirProd";
            this.excluirProd.Size = new System.Drawing.Size(118, 23);
            this.excluirProd.TabIndex = 4;
            this.excluirProd.Text = "Excluir";
            this.excluirProd.UseVisualStyleBackColor = true;
            this.excluirProd.Click += new System.EventHandler(this.excluirProd_Click);
            // 
            // frmEntrProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 502);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEntrProd";
            this.Text = "Entrada de Produtos";
            this.Load += new System.EventHandler(this.frmEntrProd_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almoxarifadoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private AlmoxarifadoDataSet almoxarifadoDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private AlmoxarifadoDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prodUsado;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoProd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkAlterar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excluir;
        private System.Windows.Forms.Button excluirProd;
    }
}

