using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_banco_faculdade1
{
    public partial class saque : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NYCOLAS;Initial Catalog=app_banco;Integrated Security=True");
        public saque(string Cpf)
        {

            InitializeComponent();
            txtCpf2.Text = Cpf;
        }

        private void saque_Load(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string saque = txtSaque.Text;
                double saque_num = double.Parse(saque);
                if (saque_num > 0)
                {
                    string query = "update tb_clientes set cli_saldo=cli_saldo - '" +saque_num + "' where cli_cpf='" + txtCpf2.Text + "'";
                    SqlDataAdapter dp = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    dp.Fill(dt);

                    cn.Open();
                    if (dt.Rows.Count == 1)
                    {

                        MessageBox.Show("Saque não foi realizado!");

                    }
                    else
                    {
                        MessageBox.Show("Saque realizado com sucesso!");
                        txtSaque.Text = "";
                        this.Hide();


                    }
                    cn.Close();

                }
                else
                {
                    MessageBox.Show("Não é possível realizar este saque");
                    txtSaque.Text = "";
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
