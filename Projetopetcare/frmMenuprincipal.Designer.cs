namespace Projetopetcare
{
    partial class frmMenuprincipal
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
            this.btncadastrocliente = new System.Windows.Forms.Button();
            this.btncadastroanimal = new System.Windows.Forms.Button();
            this.btncadastroveterinario = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncadastrocliente
            // 
            this.btncadastrocliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncadastrocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrocliente.Location = new System.Drawing.Point(269, 12);
            this.btncadastrocliente.Name = "btncadastrocliente";
            this.btncadastrocliente.Size = new System.Drawing.Size(231, 67);
            this.btncadastrocliente.TabIndex = 0;
            this.btncadastrocliente.Text = "Cadastro Cliente";
            this.btncadastrocliente.UseVisualStyleBackColor = false;
            this.btncadastrocliente.Click += new System.EventHandler(this.btncadastrocliente_Click);
            // 
            // btncadastroanimal
            // 
            this.btncadastroanimal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncadastroanimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastroanimal.Location = new System.Drawing.Point(269, 102);
            this.btncadastroanimal.Name = "btncadastroanimal";
            this.btncadastroanimal.Size = new System.Drawing.Size(231, 67);
            this.btncadastroanimal.TabIndex = 1;
            this.btncadastroanimal.Text = "Cadastro Animal";
            this.btncadastroanimal.UseVisualStyleBackColor = false;
            this.btncadastroanimal.Click += new System.EventHandler(this.btncadastroanimal_Click);
            // 
            // btncadastroveterinario
            // 
            this.btncadastroveterinario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncadastroveterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastroveterinario.Location = new System.Drawing.Point(269, 196);
            this.btncadastroveterinario.Name = "btncadastroveterinario";
            this.btncadastroveterinario.Size = new System.Drawing.Size(231, 67);
            this.btncadastroveterinario.TabIndex = 2;
            this.btncadastroveterinario.Text = "Cadastro Veterinario";
            this.btncadastroveterinario.UseVisualStyleBackColor = false;
            this.btncadastroveterinario.Click += new System.EventHandler(this.btncadastroveterinario_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(269, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "Produtos";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(269, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btncadastroveterinario);
            this.Controls.Add(this.btncadastroanimal);
            this.Controls.Add(this.btncadastrocliente);
            this.Name = "frmMenuprincipal";
            this.Text = "frmMenuprincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadastrocliente;
        private System.Windows.Forms.Button btncadastroanimal;
        private System.Windows.Forms.Button btncadastroveterinario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}