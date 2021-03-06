using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace app_banco_faculdade1
{
    public partial class deposito : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NYCOLAS;Initial Catalog=app_banco;Integrated Security=True");
        
        public deposito(string Cpf)
          
        {
            InitializeComponent();
            txtCpf2.Text = Cpf;
        }

        private void deposito_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnDeposito_acc_Click(object sender, EventArgs e)
        {
            try
            {
                
                string deposito = txtDeposito.Text;
                double deposito_num = double.Parse(deposito);
                if(deposito_num > 0)
                {
                    string query = "update tb_clientes set cli_saldo=cli_saldo + '" + deposito_num + "' where cli_cpf='" + txtCpf2.Text + "'";
                    SqlDataAdapter dp = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    dp.Fill(dt);

                    cn.Open();
                    if (dt.Rows.Count == 1)
                    {

                        MessageBox.Show("Deposito não foi realizado!");

                    }
                    else
                    {
                        MessageBox.Show("Deposito realizado com sucesso!");
                        txtDeposito.Text = "";
                        this.Hide();


                    }
                    cn.Close();

                }
                else
                {
                    MessageBox.Show("Não é possível realizar este depósito");
                    txtDeposito.Text = "";
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
