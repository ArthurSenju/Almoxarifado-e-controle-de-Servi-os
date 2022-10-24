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
            CadastroProduto cadastroProduto = new CadastroProduto();
            this.Hide();
            cadastroProduto.Show();



        }
    }
}
