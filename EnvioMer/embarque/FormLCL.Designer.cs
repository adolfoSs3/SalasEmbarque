namespace EnvioMer.ambarque
{
    partial class FormLCL
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPesoLCL = new System.Windows.Forms.TextBox();
            this.textCostoLCL = new System.Windows.Forms.TextBox();
            this.textVolumenLCL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CostoTotalLCL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBCantidadPaquetesLCL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(11, 283);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(268, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 199);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(12, 243);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(267, 33);
            this.btnAgrega.TabIndex = 16;
            this.btnAgrega.Text = "Agregar";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textPesoLCL);
            this.panel1.Controls.Add(this.textCostoLCL);
            this.panel1.Controls.Add(this.textVolumenLCL);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(23, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 169);
            this.panel1.TabIndex = 15;
            // 
            // textPesoLCL
            // 
            this.textPesoLCL.Location = new System.Drawing.Point(136, 14);
            this.textPesoLCL.Name = "textPesoLCL";
            this.textPesoLCL.Size = new System.Drawing.Size(100, 20);
            this.textPesoLCL.TabIndex = 12;
            // 
            // textCostoLCL
            // 
            this.textCostoLCL.Location = new System.Drawing.Point(136, 98);
            this.textCostoLCL.Name = "textCostoLCL";
            this.textCostoLCL.Size = new System.Drawing.Size(100, 20);
            this.textCostoLCL.TabIndex = 14;
            // 
            // textVolumenLCL
            // 
            this.textVolumenLCL.Location = new System.Drawing.Point(136, 55);
            this.textVolumenLCL.Name = "textVolumenLCL";
            this.textVolumenLCL.Size = new System.Drawing.Size(100, 20);
            this.textVolumenLCL.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Peso (kg)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Volumen (M3)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Costo";
            // 
            // CostoTotalLCL
            // 
            this.CostoTotalLCL.AutoSize = true;
            this.CostoTotalLCL.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoTotalLCL.ForeColor = System.Drawing.Color.Red;
            this.CostoTotalLCL.Location = new System.Drawing.Point(339, 262);
            this.CostoTotalLCL.Name = "CostoTotalLCL";
            this.CostoTotalLCL.Size = new System.Drawing.Size(81, 41);
            this.CostoTotalLCL.TabIndex = 14;
            this.CostoTotalLCL.Text = "00.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(352, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Costo total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cantidad de paquetes o cargas";
            // 
            // textBCantidadPaquetesLCL
            // 
            this.textBCantidadPaquetesLCL.Location = new System.Drawing.Point(191, 5);
            this.textBCantidadPaquetesLCL.Name = "textBCantidadPaquetesLCL";
            this.textBCantidadPaquetesLCL.Size = new System.Drawing.Size(100, 20);
            this.textBCantidadPaquetesLCL.TabIndex = 2;
            // 
            // FormLCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBCantidadPaquetesLCL);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.CostoTotalLCL);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormLCL";
            this.Text = "FormLCL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPesoLCL;
        private System.Windows.Forms.TextBox textCostoLCL;
        private System.Windows.Forms.TextBox textVolumenLCL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CostoTotalLCL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBCantidadPaquetesLCL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
    }
}