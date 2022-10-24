namespace Almoxarifado.Views
{
    partial class CadastroProduto
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
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtDescricaoProd = new System.Windows.Forms.TextBox();
            this.txtValorUni = new System.Windows.Forms.NumericUpDown();
            this.rbUsado = new System.Windows.Forms.RadioButton();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.lblDescricaoProd = new System.Windows.Forms.Label();
            this.lblValorUniProd = new System.Windows.Forms.Label();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.btnLimparProd = new System.Windows.Forms.Button();
            this.btnSairProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUni)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Location = new System.Drawing.Point(300, 97);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(174, 20);
            this.txtNomeProd.TabIndex = 0;
            // 
            // txtDescricaoProd
            // 
            this.txtDescricaoProd.Location = new System.Drawing.Point(262, 201);
            this.txtDescricaoProd.Multiline = true;
            this.txtDescricaoProd.Name = "txtDescricaoProd";
            this.txtDescricaoProd.Size = new System.Drawing.Size(300, 113);
            this.txtDescricaoProd.TabIndex = 1;
            // 
            // txtValorUni
            // 
            this.txtValorUni.Location = new System.Drawing.Point(300, 145);
            this.txtValorUni.Name = "txtValorUni";
            this.txtValorUni.Size = new System.Drawing.Size(174, 20);
            this.txtValorUni.TabIndex = 2;
            // 
            // rbUsado
            // 
            this.rbUsado.AutoSize = true;
            this.rbUsado.Location = new System.Drawing.Point(506, 125);
            this.rbUsado.Name = "rbUsado";
            this.rbUsado.Size = new System.Drawing.Size(56, 17);
            this.rbUsado.TabIndex = 3;
            this.rbUsado.TabStop = true;
            this.rbUsado.Text = "Usado";
            this.rbUsado.UseVisualStyleBackColor = true;
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Location = new System.Drawing.Point(297, 81);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProd.TabIndex = 4;
            this.lblNomeProd.Text = "Nome";
            // 
            // lblDescricaoProd
            // 
            this.lblDescricaoProd.AutoSize = true;
            this.lblDescricaoProd.Location = new System.Drawing.Point(374, 185);
            this.lblDescricaoProd.Name = "lblDescricaoProd";
            this.lblDescricaoProd.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoProd.TabIndex = 4;
            this.lblDescricaoProd.Text = "Descrição";
            // 
            // lblValorUniProd
            // 
            this.lblValorUniProd.AutoSize = true;
            this.lblValorUniProd.Location = new System.Drawing.Point(297, 129);
            this.lblValorUniProd.Name = "lblValorUniProd";
            this.lblValorUniProd.Size = new System.Drawing.Size(70, 13);
            this.lblValorUniProd.TabIndex = 4;
            this.lblValorUniProd.Text = "Valor Unitario";
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.Location = new System.Drawing.Point(282, 393);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(126, 33);
            this.btnSalvarProd.TabIndex = 5;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.UseVisualStyleBackColor = true;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // btnLimparProd
            // 
            this.btnLimparProd.Location = new System.Drawing.Point(414, 393);
            this.btnLimparProd.Name = "btnLimparProd";
            this.btnLimparProd.Size = new System.Drawing.Size(126, 33);
            this.btnLimparProd.TabIndex = 5;
            this.btnLimparProd.Text = "Limpar";
            this.btnLimparProd.UseVisualStyleBackColor = true;
            // 
            // btnSairProd
            // 
            this.btnSairProd.Location = new System.Drawing.Point(751, 12);
            this.btnSairProd.Name = "btnSairProd";
            this.btnSairProd.Size = new System.Drawing.Size(37, 25);
            this.btnSairProd.TabIndex = 5;
            this.btnSairProd.Text = "button1";
            this.btnSairProd.UseVisualStyleBackColor = true;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSairProd);
            this.Controls.Add(this.btnLimparProd);
            this.Controls.Add(this.btnSalvarProd);
            this.Controls.Add(this.lblValorUniProd);
            this.Controls.Add(this.lblDescricaoProd);
            this.Controls.Add(this.lblNomeProd);
            this.Controls.Add(this.rbUsado);
            this.Controls.Add(this.txtValorUni);
            this.Controls.Add(this.txtDescricaoProd);
            this.Controls.Add(this.txtNomeProd);
            this.Name = "CadastroProduto";
            this.Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)(this.txtValorUni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtDescricaoProd;
        private System.Windows.Forms.NumericUpDown txtValorUni;
        private System.Windows.Forms.RadioButton rbUsado;
        private System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.Label lblDescricaoProd;
        private System.Windows.Forms.Label lblValorUniProd;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.Button btnLimparProd;
        private System.Windows.Forms.Button btnSairProd;
    }
}