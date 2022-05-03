namespace Clinica
{
    partial class frmCadastro
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
            this.Casdastro = new System.Windows.Forms.GroupBox();
            this.btnVerSenha = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Casdastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Casdastro
            // 
            this.Casdastro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Casdastro.Controls.Add(this.btnVerSenha);
            this.Casdastro.Controls.Add(this.btnFinalizar);
            this.Casdastro.Controls.Add(this.txtRepetirSenha);
            this.Casdastro.Controls.Add(this.txtSenha);
            this.Casdastro.Controls.Add(this.txtEmail);
            this.Casdastro.Controls.Add(this.txtNome);
            this.Casdastro.Controls.Add(this.label4);
            this.Casdastro.Controls.Add(this.label3);
            this.Casdastro.Controls.Add(this.label2);
            this.Casdastro.Controls.Add(this.label1);
            this.Casdastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Casdastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Casdastro.Location = new System.Drawing.Point(11, 11);
            this.Casdastro.Margin = new System.Windows.Forms.Padding(2);
            this.Casdastro.Name = "Casdastro";
            this.Casdastro.Padding = new System.Windows.Forms.Padding(2);
            this.Casdastro.Size = new System.Drawing.Size(465, 358);
            this.Casdastro.TabIndex = 1;
            this.Casdastro.TabStop = false;
            this.Casdastro.Text = "Preencha todos os campos";
            // 
            // btnVerSenha
            // 
            this.btnVerSenha.BackgroundImage = global::Clinica.Properties.Resources.mostrar_senha;
            this.btnVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSenha.Location = new System.Drawing.Point(344, 200);
            this.btnVerSenha.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerSenha.Name = "btnVerSenha";
            this.btnVerSenha.Size = new System.Drawing.Size(23, 23);
            this.btnVerSenha.TabIndex = 7;
            this.btnVerSenha.UseVisualStyleBackColor = true;
            this.btnVerSenha.Click += new System.EventHandler(this.btnVerSenha_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinalizar.Location = new System.Drawing.Point(192, 262);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(91, 34);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtRepetirSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRepetirSenha.Location = new System.Drawing.Point(158, 194);
            this.txtRepetirSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = '*';
            this.txtRepetirSenha.Size = new System.Drawing.Size(162, 26);
            this.txtRepetirSenha.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSenha.Location = new System.Drawing.Point(158, 157);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(162, 26);
            this.txtSenha.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Location = new System.Drawing.Point(157, 119);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNome.Location = new System.Drawing.Point(158, 83);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(263, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Repita a senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(488, 382);
            this.Controls.Add(this.Casdastro);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de cadastro usuario";
            this.Casdastro.ResumeLayout(false);
            this.Casdastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Casdastro;
        private System.Windows.Forms.Button btnVerSenha;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}