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
using Almoxarifado.DTO;

namespace Almoxarifado.Views
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto(int? id)
        {
            InitializeComponent(id.HasValue ? id : null);
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is DTO.CadastroProdutoDTO cadastroProdutoDTO)
            {
                if (cadastroProdutoDTO.Id != null)
                    Atualizar(cadastroProdutoDTO.Id.Value);
                else
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
            }
        }

        public void Atualizar(int id)
        {
            using (var db = new AlmoxEntities())
            {
                var modelAtt = db.Produto.FirstOrDefault(x => x.Id == id);
                modelAtt.Nome = txtNomeProd.Text;
                modelAtt.Especificacao = txtDescricaoProd.Text;
                modelAtt.ValorUn = txtValorUni.Text;
                modelAtt.DataAlteracao = DateTime.Now;
                db.Entry(modelAtt).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                string messageBoxText = "Produto Atualizado com Sucesso";
                string caption = "Sucesso!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(messageBoxText, caption, button);
                frmEntrProd controleProduto = new frmEntrProd();
                this.Hide();
                controleProduto.Show();
            }

        }

        public CadastroProdutoDTO ProcurarAtualizar(int id)
        {
            var cadastroProdDto = new CadastroProdutoDTO();
            using (var db = new AlmoxEntities())
            {
                var model = db.Produto.FirstOrDefault(x => x.Id == id);
                if (model != null)
                {
                    cadastroProdDto.Nome = model.Nome;
                    cadastroProdDto.Descricao = model.Especificacao;
                    cadastroProdDto.Valor = model.ValorUn.ToString();
                }
            }
            return cadastroProdDto;
        }

        private void btnSairProd_Click(object sender, EventArgs e)
        {
            frmEntrProd controleProduto = new frmEntrProd();
            this.Hide();
            controleProduto.Show();
        }
    }
}
