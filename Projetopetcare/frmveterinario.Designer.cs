namespace Projetopetcare
{
    partial class frmveterinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmveterinario));
            this.gppdadosdoveterinario = new System.Windows.Forms.GroupBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gppdadosdoveterinario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gppdadosdoveterinario
            // 
            this.gppdadosdoveterinario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gppdadosdoveterinario.Controls.Add(this.cbbUF);
            this.gppdadosdoveterinario.Controls.Add(this.txtemail);
            this.gppdadosdoveterinario.Controls.Add(this.txtcpf);
            this.gppdadosdoveterinario.Controls.Add(this.label2);
            this.gppdadosdoveterinario.Controls.Add(this.label1);
            this.gppdadosdoveterinario.Controls.Add(this.lblcpf);
            this.gppdadosdoveterinario.Controls.Add(this.txtcodigo);
            this.gppdadosdoveterinario.Controls.Add(this.txtidade);
            this.gppdadosdoveterinario.Controls.Add(this.txtnome);
            this.gppdadosdoveterinario.Controls.Add(this.lblcodigo);
            this.gppdadosdoveterinario.Controls.Add(this.lblidade);
            this.gppdadosdoveterinario.Controls.Add(this.lblnome);
            this.gppdadosdoveterinario.Location = new System.Drawing.Point(12, 12);
            this.gppdadosdoveterinario.Name = "gppdadosdoveterinario";
            this.gppdadosdoveterinario.Size = new System.Drawing.Size(532, 210);
            this.gppdadosdoveterinario.TabIndex = 0;
            this.gppdadosdoveterinario.TabStop = false;
            this.gppdadosdoveterinario.Text = "Dados do Veterinário";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(34, 59);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(44, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(34, 101);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(42, 16);
            this.lblidade.TabIndex = 1;
            this.lblidade.Text = "Idade";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(34, 144);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(51, 16);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Código";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(91, 59);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(155, 20);
            this.txtnome.TabIndex = 3;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(91, 101);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(155, 20);
            this.txtidade.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(91, 140);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(155, 20);
            this.txtcodigo.TabIndex = 5;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(303, 63);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(33, 16);
            this.lblcpf.TabIndex = 6;
            this.lblcpf.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "UF";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(363, 63);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(155, 20);
            this.txtcpf.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(363, 104);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(155, 20);
            this.txtemail.TabIndex = 10;
            // 
            // cbbUF
            // 
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MS",
            "MT",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(363, 143);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(155, 21);
            this.cbbUF.TabIndex = 11;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.DarkRed;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(173, 307);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(187, 53);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Yellow;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(409, 307);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(187, 53);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmveterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.gppdadosdoveterinario);
            this.Name = "frmveterinario";
            this.Text = "frmveterinario";
            this.gppdadosdoveterinario.ResumeLayout(false);
            this.gppdadosdoveterinario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gppdadosdoveterinario;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}