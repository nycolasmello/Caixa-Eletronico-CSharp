
namespace app_banco_faculdade1.FORMS
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.btnDepositar_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(81, 21);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(212, 23);
            this.txtDeposito.TabIndex = 2;
            // 
            // btnDepositar_add
            // 
            this.btnDepositar_add.Location = new System.Drawing.Point(313, 20);
            this.btnDepositar_add.Name = "btnDepositar_add";
            this.btnDepositar_add.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar_add.TabIndex = 3;
            this.btnDepositar_add.Text = "DEPOSITAR";
            this.btnDepositar_add.UseVisualStyleBackColor = true;
            // 
            // deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 65);
            this.Controls.Add(this.btnDepositar_add);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "deposito";
            this.ShowIcon = false;
            this.Text = "DEPOSITO A EL CUENTA XIRA!!";
            this.Load += new System.EventHandler(this.deposito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Button btnDepositar_add;
    }
}