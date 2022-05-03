namespace Clinica
{
    partial class frmConsultarAtendimento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbIdentificar = new System.Windows.Forms.GroupBox();
            this.cbFiltrarConsutaAtendimento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFiltrarFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFiltrarInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grdFiltroAtendimento = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbIdentificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiltroAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 546);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica.Properties.Resources.baixados;
            this.pictureBox1.Location = new System.Drawing.Point(19, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbIdentificar
            // 
            this.gbIdentificar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gbIdentificar.Controls.Add(this.cbFiltrarConsutaAtendimento);
            this.gbIdentificar.Controls.Add(this.label6);
            this.gbIdentificar.Controls.Add(this.btnFiltrar);
            this.gbIdentificar.Controls.Add(this.label8);
            this.gbIdentificar.Controls.Add(this.dtFiltrarFinal);
            this.gbIdentificar.Controls.Add(this.dtFiltrarInicio);
            this.gbIdentificar.Controls.Add(this.label1);
            this.gbIdentificar.Controls.Add(this.label14);
            this.gbIdentificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentificar.Location = new System.Drawing.Point(234, 15);
            this.gbIdentificar.Name = "gbIdentificar";
            this.gbIdentificar.Size = new System.Drawing.Size(647, 208);
            this.gbIdentificar.TabIndex = 4;
            this.gbIdentificar.TabStop = false;
            this.gbIdentificar.Text = "Filtrar por Procedimentos";
            // 
            // cbFiltrarConsutaAtendimento
            // 
            this.cbFiltrarConsutaAtendimento.BackColor = System.Drawing.SystemColors.Menu;
            this.cbFiltrarConsutaAtendimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrarConsutaAtendimento.FormattingEnabled = true;
            this.cbFiltrarConsutaAtendimento.Location = new System.Drawing.Point(9, 115);
            this.cbFiltrarConsutaAtendimento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbFiltrarConsutaAtendimento.Name = "cbFiltrarConsutaAtendimento";
            this.cbFiltrarConsutaAtendimento.Size = new System.Drawing.Size(633, 24);
            this.cbFiltrarConsutaAtendimento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selecione o tipo de Procedimento:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrar.Location = new System.Drawing.Point(540, 160);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(102, 34);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(222, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data Final:";
            // 
            // dtFiltrarFinal
            // 
            this.dtFiltrarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFiltrarFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltrarFinal.Location = new System.Drawing.Point(225, 50);
            this.dtFiltrarFinal.Name = "dtFiltrarFinal";
            this.dtFiltrarFinal.Size = new System.Drawing.Size(118, 26);
            this.dtFiltrarFinal.TabIndex = 2;
            // 
            // dtFiltrarInicio
            // 
            this.dtFiltrarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFiltrarInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFiltrarInicio.Location = new System.Drawing.Point(12, 50);
            this.dtFiltrarInicio.Name = "dtFiltrarInicio";
            this.dtFiltrarInicio.Size = new System.Drawing.Size(117, 26);
            this.dtFiltrarInicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Data Inicial:";
            // 
            // grdFiltroAtendimento
            // 
            this.grdFiltroAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiltroAtendimento.Location = new System.Drawing.Point(234, 229);
            this.grdFiltroAtendimento.Name = "grdFiltroAtendimento";
            this.grdFiltroAtendimento.Size = new System.Drawing.Size(647, 336);
            this.grdFiltroAtendimento.TabIndex = 7;
            // 
            // frmConsultarAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(894, 577);
            this.Controls.Add(this.grdFiltroAtendimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbIdentificar);
            this.Name = "frmConsultarAtendimento";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Filtro";
            this.Load += new System.EventHandler(this.frmConsultarAtendimento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbIdentificar.ResumeLayout(false);
            this.gbIdentificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiltroAtendimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbIdentificar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFiltrarFinal;
        private System.Windows.Forms.DateTimePicker dtFiltrarInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdFiltroAtendimento;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbFiltrarConsutaAtendimento;
        private System.Windows.Forms.Label label6;
    }
}