using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (var db = new AlmoxarifadoEntities1())
            {
                var model = new Produto();

                model.Nome = txtNomeProd.Text;
                model.Especificacao = txtDescricaoProd.Text;
                model.Ativo = true;
                var valorUni = txtValorUni.Value;
                model.ValorUn = Convert.ToInt32(valorUni);
                model.Usado = rbUsado.Checked;
                model.DataInclusao = DateTime.UtcNow;

                var salvo = db.Produto.Add(model);
                db.SaveChanges();

                if (salvo != null)
                {
                    string messageBoxText = "Produto Cadastrado com Sucesso";
                    string caption = "Word Processor";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(messageBoxText, caption, button);

                }
                else
                {
                    MessageBox.Show("Produto não Inserido");
                }
            }
        }
    }
}
