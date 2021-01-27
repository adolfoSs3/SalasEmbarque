namespace EnvioMer.ambarque
{
    partial class FormFCL
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
            this.panelFCL = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboTipoCont = new System.Windows.Forms.ComboBox();
            this.textCostoXcontenedor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textCantidadPaquetesFCL = new System.Windows.Forms.TextBox();
            this.panelFCL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFCL
            // 
            this.panelFCL.Controls.Add(this.button1);
            this.panelFCL.Controls.Add(this.dataGridView1);
            this.panelFCL.Controls.Add(this.comboTipoCont);
            this.panelFCL.Controls.Add(this.textCostoXcontenedor);
            this.panelFCL.Controls.Add(this.label16);
            this.panelFCL.Controls.Add(this.label17);
            this.panelFCL.Controls.Add(this.label13);
            this.panelFCL.Controls.Add(this.label14);
            this.panelFCL.Controls.Add(this.label15);
            this.panelFCL.Controls.Add(this.textCantidadPaquetesFCL);
            this.panelFCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFCL.Location = new System.Drawing.Point(0, 0);
            this.panelFCL.Name = "panelFCL";
            this.panelFCL.Size = new System.Drawing.Size(683, 316);
            this.panelFCL.TabIndex = 31;
            this.panelFCL.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 192);
            this.dataGridView1.TabIndex = 20;
            // 
            // comboTipoCont
            // 
            this.comboTipoCont.FormattingEnabled = true;
            this.comboTipoCont.Items.AddRange(new object[] {
            "Contenedor DRY-VAN 20´",
            "Contenedor DRY-VAN 40´",
            "Contenedor DRY -VAN 40´    HIGH CUBE",
            "Contenedor Ventilado 20´",
            "Contenedor Refrigerado 20´",
            "Contenedor Refrigerado 40´",
            "Contenedor Flat Rack 20\'",
            "Contenedor Flat Rack 40\'",
            "Contenedor ABIERTO 20´    OPEN TOP"});
            this.comboTipoCont.Location = new System.Drawing.Point(40, 163);
            this.comboTipoCont.Name = "comboTipoCont";
            this.comboTipoCont.Size = new System.Drawing.Size(181, 21);
            this.comboTipoCont.TabIndex = 19;
            this.comboTipoCont.Text = "Contenedor DRY-VAN 20´";
            // 
            // textCostoXcontenedor
            // 
            this.textCostoXcontenedor.Location = new System.Drawing.Point(40, 254);
            this.textCostoXcontenedor.Name = "textCostoXcontenedor";
            this.textCostoXcontenedor.Size = new System.Drawing.Size(181, 20);
            this.textCostoXcontenedor.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Tipo de  contenedor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Costo por contenedor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(548, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 41);
            this.label13.TabIndex = 15;
            this.label13.Text = "00.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(552, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Costo total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Cantidad de paquetes";
            // 
            // textCantidadPaquetesFCL
            // 
            this.textCantidadPaquetesFCL.Location = new System.Drawing.Point(40, 82);
            this.textCantidadPaquetesFCL.Name = "textCantidadPaquetesFCL";
            this.textCantidadPaquetesFCL.Size = new System.Drawing.Size(181, 20);
            this.textCantidadPaquetesFCL.TabIndex = 2;
            // 
            // FormFCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 316);
            this.Controls.Add(this.panelFCL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFCL";
            this.Text = "FormFCL";
            this.panelFCL.ResumeLayout(false);
            this.panelFCL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelFCL;
        private System.Windows.Forms.ComboBox comboTipoCont;
        private System.Windows.Forms.TextBox textCostoXcontenedor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textCantidadPaquetesFCL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}