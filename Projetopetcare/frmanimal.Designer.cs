namespace Projetopetcare
{
    partial class frmanimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmanimal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblcor = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lbldetalhe = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdetalhe = new System.Windows.Forms.TextBox();
            this.mskcor = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados do Animal";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(77, 174);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(22, 18);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(77, 232);
            this.lblpeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(43, 18);
            this.lblpeso.TabIndex = 2;
            this.lblpeso.Text = "Peso";
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcor.Location = new System.Drawing.Point(77, 287);
            this.lblcor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(33, 18);
            this.lblcor.TabIndex = 3;
            this.lblcor.Text = "Cor";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(77, 343);
            this.lblnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 18);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "Nome";
            // 
            // lbldetalhe
            // 
            this.lbldetalhe.AutoSize = true;
            this.lbldetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalhe.Location = new System.Drawing.Point(77, 404);
            this.lbldetalhe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldetalhe.Name = "lbldetalhe";
            this.lbldetalhe.Size = new System.Drawing.Size(58, 18);
            this.lbldetalhe.TabIndex = 5;
            this.lbldetalhe.Text = "Detalhe";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(139, 166);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(241, 21);
            this.txtid.TabIndex = 6;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(139, 232);
            this.txtpeso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(241, 21);
            this.txtpeso.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(139, 343);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(241, 21);
            this.txtnome.TabIndex = 8;
            // 
            // txtdetalhe
            // 
            this.txtdetalhe.Location = new System.Drawing.Point(139, 404);
            this.txtdetalhe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdetalhe.Name = "txtdetalhe";
            this.txtdetalhe.Size = new System.Drawing.Size(241, 21);
            this.txtdetalhe.TabIndex = 9;
            // 
            // mskcor
            // 
            this.mskcor.Location = new System.Drawing.Point(139, 284);
            this.mskcor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mskcor.Name = "mskcor";
            this.mskcor.Size = new System.Drawing.Size(241, 21);
            this.mskcor.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(469, 433);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(224, 58);
            this.btnvoltar.TabIndex = 12;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(738, 433);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(224, 58);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frmanimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskcor);
            this.Controls.Add(this.txtdetalhe);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbldetalhe);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmanimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lbldetalhe;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdetalhe;
        private System.Windows.Forms.MaskedTextBox mskcor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}