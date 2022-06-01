using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_banco_faculdade1
{
    public partial class opcoes : Form
    {
        int contador = 0;   
        SqlConnection cn = new SqlConnection(@"Data Source=NYCOLAS;Initial Catalog=app_banco;Integrated Security=True");
        DataTable dt = new DataTable();
        public opcoes(string Cpf)
        {
            InitializeComponent();
            CarregarDados(Cpf);
            txtCpf2.Text = Cpf;
            timer1.Enabled = true;
           
        }

        private void CarregarDados(string Cpf)
        {
            txtCpf2.Text = Cpf;
            cn.Open();
            string query = "SELECT CLI_NOME,CLI_SALDO FROM TB_CLIENTES WHERE CLI_CPF='" + txtCpf2.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, cn);
            dp.Fill(dt);
            dgDados.DataSource = dt;
            dgDados.Columns["CLI_NOME"].HeaderText = "Nome";
            dgDados.Columns["CLI_SALDO"].HeaderText = "Saldo";
            

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            deposito depositar = new deposito(txtCpf2.Text);
            depositar.Show();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;      
            if(contador > 1)
            {
                string refresh = "SELECT CLI_NOME,CLI_SALDO FROM TB_CLIENTES WHERE CLI_CPF='" + txtCpf2.Text + "'";
                SqlDataAdapter dp = new SqlDataAdapter(refresh, cn);
                DataSet DS = new System.Data.DataSet();
                dp.Fill(DS, "tb_clientes");
                dgDados.DataSource = DS.Tables[0];
                foreach (DataGridViewColumn column in dgDados.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                contador = 0;
                timer1.Start();
            }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            saque sacar = new saque(txtCpf2.Text);
            sacar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            transferencia transfer = new transferencia(txtCpf2.Text);
            transfer.Show();

        }
    }
}
