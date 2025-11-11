namespace APPfuncionario
{
    partial class FrmMenuPrincipal1
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btnproduto = new System.Windows.Forms.Button();
            this.btnForne = new System.Windows.Forms.Button();
            this.btnnf = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncliente.Location = new System.Drawing.Point(293, 72);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(146, 50);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnproduto
            // 
            this.btnproduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnproduto.Location = new System.Drawing.Point(293, 128);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(146, 50);
            this.btnproduto.TabIndex = 1;
            this.btnproduto.Text = "Produto";
            this.btnproduto.UseVisualStyleBackColor = true;
            // 
            // btnForne
            // 
            this.btnForne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnForne.Location = new System.Drawing.Point(293, 184);
            this.btnForne.Name = "btnForne";
            this.btnForne.Size = new System.Drawing.Size(146, 50);
            this.btnForne.TabIndex = 2;
            this.btnForne.Text = "Fornecedor";
            this.btnForne.UseVisualStyleBackColor = true;
            // 
            // btnnf
            // 
            this.btnnf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnnf.Location = new System.Drawing.Point(293, 240);
            this.btnnf.Name = "btnnf";
            this.btnnf.Size = new System.Drawing.Size(146, 50);
            this.btnnf.TabIndex = 3;
            this.btnnf.Text = "Nota Fiscal";
            this.btnnf.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsair.Location = new System.Drawing.Point(293, 296);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(146, 50);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            // 
            // FrmMenuPrincipal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnnf);
            this.Controls.Add(this.btnForne);
            this.Controls.Add(this.btnproduto);
            this.Controls.Add(this.btncliente);
            this.Name = "FrmMenuPrincipal1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal1";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Button btnForne;
        private System.Windows.Forms.Button btnnf;
        private System.Windows.Forms.Button btnsair;
    }
}