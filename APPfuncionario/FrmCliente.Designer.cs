namespace APPfuncionario
{
    partial class FrmCliente
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
            this.gbcliente = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.gbcliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbcliente
            // 
            this.gbcliente.Controls.Add(this.txtname);
            this.gbcliente.Controls.Add(this.txtcodigo);
            this.gbcliente.Controls.Add(this.txtidade);
            this.gbcliente.Controls.Add(this.lblcodigo);
            this.gbcliente.Controls.Add(this.lblidade);
            this.gbcliente.Controls.Add(this.lblname);
            this.gbcliente.Location = new System.Drawing.Point(44, 31);
            this.gbcliente.Name = "gbcliente";
            this.gbcliente.Size = new System.Drawing.Size(427, 267);
            this.gbcliente.TabIndex = 0;
            this.gbcliente.TabStop = false;
            this.gbcliente.Text = "Dados do cliente";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(35, 47);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nome";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(35, 104);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(34, 13);
            this.lblidade.TabIndex = 1;
            this.lblidade.Text = "Idade";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(35, 161);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Código";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(76, 101);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(76, 158);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 5;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(139, 333);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(129, 58);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "Novo";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(342, 333);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(129, 58);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(533, 333);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(129, 58);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Voltar";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(482, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 266);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(76, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 6;
            this.txtname.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.gbcliente);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.gbcliente.ResumeLayout(false);
            this.gbcliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcliente;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtname;
    }
}