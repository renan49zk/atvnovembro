namespace Projetopetcare
{
    partial class frmcliente
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
            this.gppdadosdocliente = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.gppdadosdocliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gppdadosdocliente
            // 
            this.gppdadosdocliente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gppdadosdocliente.Controls.Add(this.txtcodigo);
            this.gppdadosdocliente.Controls.Add(this.txtidade);
            this.gppdadosdocliente.Controls.Add(this.txtnome);
            this.gppdadosdocliente.Controls.Add(this.lblcodigo);
            this.gppdadosdocliente.Controls.Add(this.lblidade);
            this.gppdadosdocliente.Controls.Add(this.lblnome);
            this.gppdadosdocliente.Location = new System.Drawing.Point(213, 52);
            this.gppdadosdocliente.Name = "gppdadosdocliente";
            this.gppdadosdocliente.Size = new System.Drawing.Size(363, 206);
            this.gppdadosdocliente.TabIndex = 1;
            this.gppdadosdocliente.TabStop = false;
            this.gppdadosdocliente.Text = "Dados do cliente";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(144, 146);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(155, 20);
            this.txtcodigo.TabIndex = 5;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(144, 107);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(155, 20);
            this.txtidade.TabIndex = 4;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(144, 65);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(155, 20);
            this.txtnome.TabIndex = 3;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(87, 150);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(51, 16);
            this.lblcodigo.TabIndex = 2;
            this.lblcodigo.Text = "Código";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidade.Location = new System.Drawing.Point(87, 107);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(42, 16);
            this.lblidade.TabIndex = 1;
            this.lblidade.Text = "Idade";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(87, 65);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(44, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome";
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(182, 305);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(188, 50);
            this.btnlimpar.TabIndex = 2;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Yellow;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(425, 305);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(188, 50);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.gppdadosdocliente);
            this.Name = "frmcliente";
            this.Text = "frmcliente";
            this.gppdadosdocliente.ResumeLayout(false);
            this.gppdadosdocliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gppdadosdocliente;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}