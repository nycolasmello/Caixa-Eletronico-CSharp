using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_banco_faculdade1
{
    public partial class form_login : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=NYCOLAS;Initial Catalog=app_banco;Integrated Security=True");
        public form_login()
        {
            InitializeComponent();
            txtConta.Select();

            
        }

        private void form_login_Load(object sender, EventArgs e)
        {

          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cn.Open();
            string query = "SELECT * FROM TB_CLIENTES WHERE CLI_CONTA ='" + txtConta.Text + "' AND CLI_CPF='" + txtCpf.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                opcoes op = new opcoes(txtCpf.Text);
                this.Hide();
                op.Show();
            }
            else
            {
                MessageBox.Show("Conta ou CPF incorreto!", "ERRO!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConta.Text = "";
                txtCpf.Text = "";
                txtConta.Select();
            }
            cn.Close();
        
            

        }


    }
}
