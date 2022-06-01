
namespace app_banco_faculdade1
{
    partial class opcoes
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
            this.components = new System.ComponentModel.Container();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.txtCpf2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackgroundImage = global::app_banco_faculdade1.Properties.Resources.cofrinho;
            this.btnDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeposito.Location = new System.Drawing.Point(27, 157);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(96, 50);
            this.btnDeposito.TabIndex = 0;
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnPix
            // 
            this.btnPix.BackgroundImage = global::app_banco_faculdade1.Properties.Resources.dinheiro_de_volta;
            this.btnPix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPix.Location = new System.Drawing.Point(27, 266);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(96, 53);
            this.btnPix.TabIndex = 1;
            this.btnPix.UseVisualStyleBackColor = true;
            // 
            // btnSaque
            // 
            this.btnSaque.BackgroundImage = global::app_banco_faculdade1.Properties.Resources.apenas_a_dinheiro;
            this.btnSaque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaque.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaque.Location = new System.Drawing.Point(171, 157);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(96, 50);
            this.btnSaque.TabIndex = 2;
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::app_banco_faculdade1.Properties.Resources.forma_de_pagamento;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(171, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 53);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEPOSITO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "PIX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(189, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "SAQUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(171, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "TRANSFERENCIA";
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToOrderColumns = true;
            this.dgDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(27, 69);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.RowTemplate.Height = 25;
            this.dgDados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgDados.Size = new System.Drawing.Size(240, 49);
            this.dgDados.TabIndex = 8;

            // 
            // txtCpf2
            // 
            this.txtCpf2.Location = new System.Drawing.Point(27, 40);
            this.txtCpf2.Name = "txtCpf2";
            this.txtCpf2.ReadOnly = true;
            this.txtCpf2.Size = new System.Drawing.Size(240, 23);
            this.txtCpf2.TabIndex = 9;
            this.txtCpf2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 339);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCpf2);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.btnDeposito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "opcoes";
            this.ShowIcon = false;
            this.Text = "OPCOES BANCO EL LOKO";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnPix;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpf2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Timer timer1;
    }
}