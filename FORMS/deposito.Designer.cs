
namespace app_banco_faculdade1
{
    partial class deposito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.btnDeposito_acc = new System.Windows.Forms.Button();
            this.txtCpf2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "VALOR A DEPOSITAR";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(135, 47);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(66, 23);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeposito_acc
            // 
            this.btnDeposito_acc.Location = new System.Drawing.Point(218, 47);
            this.btnDeposito_acc.Name = "btnDeposito_acc";
            this.btnDeposito_acc.Size = new System.Drawing.Size(75, 23);
            this.btnDeposito_acc.TabIndex = 2;
            this.btnDeposito_acc.Text = "Depositar";
            this.btnDeposito_acc.UseVisualStyleBackColor = true;
            this.btnDeposito_acc.Click += new System.EventHandler(this.btnDeposito_acc_Click);
            // 
            // txtCpf2
            // 
            this.txtCpf2.Location = new System.Drawing.Point(50, 12);
            this.txtCpf2.Name = "txtCpf2";
            this.txtCpf2.ReadOnly = true;
            this.txtCpf2.Size = new System.Drawing.Size(252, 23);
            this.txtCpf2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF:";
            // 
            // deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 81);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpf2);
            this.Controls.Add(this.btnDeposito_acc);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "deposito";
            this.ShowIcon = false;
            this.Text = "DEPOSITO EN EL CUENTA XIRA!!";
            this.Load += new System.EventHandler(this.deposito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Button btnDeposito_acc;
        private System.Windows.Forms.TextBox txtCpf2;
        private System.Windows.Forms.Label label2;
    }
}