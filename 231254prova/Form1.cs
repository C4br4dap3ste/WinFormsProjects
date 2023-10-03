using System.Drawing;

namespace _231254prova
{
    public partial class Form1 : Form
    {
        double total=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {

                //Move o conteudo da primeira celula da liinha selecionada para a caixa de texto
                txtAlt.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Add(txtDesc.Text, txtQuant.Text, txtUnit.Text);

            

            total += double.Parse(txtQuant.Text) * double.Parse(txtUnit.Text);
            txtTotal.Text = total.ToString();

            txtDesc.Clear();
            txtQuant.Clear();
            txtUnit.Clear();

         


            //Exibe uma mensagem ao usuario 
            
            MessageBox.Show("Produto Incluído com sucesso","",MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblQtdS_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.Rows.Count > 0)
            {

                



                double vlrNovo = int.Parse(txtAlt.Text) * 
                    double.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());


                double vlrAntigo = int.Parse(dgvProdutos.CurrentRow.Cells[1].Value.ToString()) * 
                    double.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());

                total = total + vlrNovo - vlrAntigo;
                txtTotal.Text = total.ToString();


                //Exibe a mensagem de alteracao com sucesso
                MessageBox.Show("Quantidade Alterada com sucesso", "Alteração",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                //Move o novo valor para a celula
                dgvProdutos.CurrentRow.Cells[1].Value = txtAlt.Text;
            }


        }

        void limpar()
        {
            txtDesc.Clear();
            txtQuant.Clear();
            txtUnit.Clear();
            dgvProdutos.Rows.Clear();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            lblVendas.Text=(int.Parse(lblVendas.Text) + 1).ToString();
            limpar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}