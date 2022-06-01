
namespace app_banco_faculdade1
{
    partial class saque
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
            this.txtCpf2 = new System.Windows.Forms.TextBox();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpf2
            // 
            this.txtCpf2.Location = new System.Drawing.Point(58, 12);
            this.txtCpf2.Name = "txtCpf2";
            this.txtCpf2.ReadOnly = true;
            this.txtCpf2.Size = new System.Drawing.Size(247, 23);
            this.txtCpf2.TabIndex = 0;
            this.txtCpf2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(124, 55);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(100, 23);
            this.txtSaque.TabIndex = 1;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(230, 58);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "VALOR A SACAR:";
            // 
            // saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.txtSaque);
            this.Controls.Add(this.txtCpf2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "saque";
            this.ShowIcon = false;
            this.Text = "SAQUE DE LA CUENTA XIRA!!";
            this.Load += new System.EventHandler(this.saque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpf2;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}