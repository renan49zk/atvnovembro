namespace Projetopetcare
{
    partial class frmmenuprincipal
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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(346, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 64);
            this.button6.TabIndex = 2;
            this.button6.Text = "Cadastro Veterinário";
            this.button6.UseVisualStyleBackColor = false;
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
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(346, 395);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(189, 64);
            this.button8.TabIndex = 4;
            this.button8.Text = "Sair";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // frmmenuprincipal
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 471);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btncadastraranimal);
            this.Controls.Add(this.btncadastrocliente);
            this.Name = "frmmenuprincipal";
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}