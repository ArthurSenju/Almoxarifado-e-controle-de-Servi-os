using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almoxarifado;

namespace Almoxarifado.Views
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {

            using (var db = new AlmoxEntities())
            {
                var model = new Produto();

                model.Nome = txtNomeProd.Text;
                model.Especificacao = txtDescricaoProd.Text;
                model.Ativo = true;
                model.ValorUn = txtValorUni.Text;
                model.Usado = rbUsado.Checked;
                model.DataInclusao = DateTime.UtcNow;

                var salvo = db.Produto.Add(model);
                db.SaveChanges();

                if (salvo != null)
                {
                    string messageBoxText = "Produto Cadastrado com Sucesso";
                    string caption = "Sucesso!";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(messageBoxText, caption, button);
                    frmEntrProd controleProduto = new frmEntrProd();
                    this.Hide();
                    controleProduto.Show();

                }
                else
                {
                    MessageBox.Show("Produto não Inserido");
                }
            }
        }

        public void Atualizar(int id)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.Show();
            
            using (var db = new AlmoxEntities())
            {
                var model = db.Produto.FirstOrDefault(x => x.Id == id);
                if (model != null)
                {
                    txtNomeProd.Text = model.Nome;
                    txtDescricaoProd.Text = model.Especificacao;
                    txtValorUni.Text = model.ValorUn.ToString();
                    rbUsado.Checked = model.Usado.Value;

                }
            }
        }

        private void btnSairProd_Click(object sender, EventArgs e)
        {
            frmEntrProd controleProduto = new frmEntrProd();
            this.Hide();
            controleProduto.Show();
        }
    }
}
