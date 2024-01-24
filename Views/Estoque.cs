using Almoxarifado.Views;
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

namespace Almoxarifado
{
    public partial class frmEntrProd : Form
    {
        public frmEntrProd()
        {
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto(null);
            this.Hide();
            cadastroProduto.Show();



        }



        private void frmEntrProd_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'almoxarifadoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter.Fill(this.almoxarifadoDataSet.Produto);
            AtualizarGrid();


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            using(var db = new AlmoxEntities())
            {
                //Procura no banco os registro digitado na caixa de pesquisa.
                var produtosModel = db.Produto.Where(x => x.Ativo == true).ToList();

                //Exibi no Grid os nomes pesquisados no banco de dados.
                var bindingList = produtosModel;
                var source = new BindingSource(bindingList, null);

                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = source;

                //Atualiza o Grid.
                dgvProdutos.Update();
                dgvProdutos.Refresh();

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvProdutos.Rows)
            {
                if (item.Cells[5].Value != null)
                {
                    var idConversao = item.Cells[0].Value.ToString();
                    var id = int.Parse(idConversao);
                    CadastroProduto cadastroProduto = new CadastroProduto(id);
                    this.Hide();
                    cadastroProduto.Show();
                }
            }

        }   
    }
}
