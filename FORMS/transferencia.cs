using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_banco_faculdade1
{
    public partial class transferencia : Form
    {
        int contador=0;
        SqlConnection cn = new SqlConnection(@"Data Source=NYCOLAS;Initial Catalog=app_banco;Integrated Security=True");
        public transferencia(string Cpf)
        {
            InitializeComponent();
            txtCpf2.Text = Cpf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu desposito será realizado em alguns instantes!!");
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            label5.Text = contador.ToString();
            if (contador >= 10)
            {
                contador = 0;
                timer1.Enabled = false;
                try
                {
                    string conta = txtContaDestino.Text;
                    int conta_num = int.Parse(conta);       
                    string transfer = txtValor.Text;
                    double transfer_num = double.Parse(transfer);
                    if (transfer_num > 0)
                    {
                        string query = "update tb_clientes set cli_saldo=cli_saldo - '" + transfer_num + "' where cli_cpf='" + txtCpf2.Text + "';update tb_clientes set cli_saldo=cli_saldo + '" + transfer_num + "' where cli_conta='" + conta_num + "' ";
                        SqlDataAdapter dp = new SqlDataAdapter(query, cn);
                        DataTable dt = new DataTable();
                        dp.Fill(dt);
                        cn.Open();

                        if (dt.Rows.Count == 1)
                        {
                            MessageBox.Show("Transferencia não foi realizada!");
                        }
                        else
                        {
                            MessageBox.Show("Transferencia realizada com sucesso!");
                            txtValor.Text = "";
                            this.Hide();
                        }
                        cn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não é possível realizar esta transferencia");
                        txtValor.Text = "";
                        txtValor.Select();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            }
            

        }
    }
}
