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
            this.btncadastraranimal = new System.Windows.Forms.Button();
            this.btncadastroveterinario = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncadastrocliente
            // 
            this.btncadastrocliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncadastrocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrocliente.Location = new System.Drawing.Point(346, 31);
            this.btncadastrocliente.Name = "btncadastrocliente";
            this.btncadastrocliente.Size = new System.Drawing.Size(189, 64);
            this.btncadastrocliente.TabIndex = 0;
            this.btncadastrocliente.Text = "Cadastro cliente";
            this.btncadastrocliente.UseVisualStyleBackColor = false;
            this.btncadastrocliente.Click += new System.EventHandler(this.btncadastrocliente_Click);
            // 
            // btncadastraranimal
            // 
            this.btncadastraranimal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncadastraranimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastraranimal.Location = new System.Drawing.Point(346, 127);
            this.btncadastraranimal.Name = "btncadastraranimal";
            this.btncadastraranimal.Size = new System.Drawing.Size(189, 59);
            this.btncadastraranimal.TabIndex = 5;
            this.btncadastraranimal.Text = "Cadastro Animal";
            this.btncadastraranimal.UseVisualStyleBackColor = false;
            this.btncadastraranimal.Click += new System.EventHandler(this.btncadastraranimal_Click);
            // 
            // btncadastroveterinario
            // 
            this.btncadastroveterinario.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncadastroveterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastroveterinario.Location = new System.Drawing.Point(346, 212);
            this.btncadastroveterinario.Name = "btncadastroveterinario";
            this.btncadastroveterinario.Size = new System.Drawing.Size(189, 64);
            this.btncadastroveterinario.TabIndex = 2;
            this.btncadastroveterinario.Text = "Cadastro Veterinário";
            this.btncadastroveterinario.UseVisualStyleBackColor = false;
            this.btncadastroveterinario.Click += new System.EventHandler(this.btncadastroveterinario_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(346, 300);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(189, 64);
            this.button7.TabIndex = 3;
            this.button7.Text = "Produtos";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(346, 395);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(189, 64);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmMenuprincipal
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(906, 471);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btncadastroveterinario);
            this.Controls.Add(this.btncadastraranimal);
            this.Controls.Add(this.btncadastrocliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadastroclientes;
        private System.Windows.Forms.Button btncadastroanimal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btncadastrocliente;
        private System.Windows.Forms.Button btncadastraranimal;
        private System.Windows.Forms.Button btncadastroveterinario;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnsair;
    }
}