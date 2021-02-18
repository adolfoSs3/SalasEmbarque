namespace EnvioMer
{
    partial class Mapa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMapa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtlatitud2 = new System.Windows.Forms.TextBox();
            this.txtLongitud2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewPrueba = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBAvion = new System.Windows.Forms.RadioButton();
            this.radioBCamion = new System.Windows.Forms.RadioButton();
            this.radioBBarco = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrueba)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1038, 338);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(3, 34);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(166, 20);
            this.txtLatitud.TabIndex = 3;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(3, 74);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(166, 20);
            this.txtLongitud.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Latitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longitud";
            // 
            // dataGridViewMapa
            // 
            this.dataGridViewMapa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMapa.Location = new System.Drawing.Point(649, 412);
            this.dataGridViewMapa.Name = "dataGridViewMapa";
            this.dataGridViewMapa.ReadOnly = true;
            this.dataGridViewMapa.Size = new System.Drawing.Size(191, 150);
            this.dataGridViewMapa.TabIndex = 9;
            this.dataGridViewMapa.Visible = false;
            this.dataGridViewMapa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLatitud);
            this.panel1.Controls.Add(this.txtLongitud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 98);
            this.panel1.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 375);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(166, 20);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "Del punto A al Punto B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(438, 412);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(120, 53);
            this.BtnAgregar.TabIndex = 15;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(438, 490);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(120, 53);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtlatitud2);
            this.panel2.Controls.Add(this.txtLongitud2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(237, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 98);
            this.panel2.TabIndex = 15;
            // 
            // txtlatitud2
            // 
            this.txtlatitud2.Location = new System.Drawing.Point(15, 34);
            this.txtlatitud2.Name = "txtlatitud2";
            this.txtlatitud2.Size = new System.Drawing.Size(166, 20);
            this.txtlatitud2.TabIndex = 3;
            // 
            // txtLongitud2
            // 
            this.txtLongitud2.Location = new System.Drawing.Point(15, 74);
            this.txtLongitud2.Name = "txtLongitud2";
            this.txtLongitud2.Size = new System.Drawing.Size(166, 20);
            this.txtLongitud2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Latitud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Longitud";
            // 
            // dataGridViewPrueba
            // 
            this.dataGridViewPrueba.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrueba.EnableHeadersVisualStyles = false;
            this.dataGridViewPrueba.Location = new System.Drawing.Point(575, 412);
            this.dataGridViewPrueba.Name = "dataGridViewPrueba";
            this.dataGridViewPrueba.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewPrueba.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPrueba.Size = new System.Drawing.Size(464, 150);
            this.dataGridViewPrueba.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBBarco);
            this.groupBox1.Controls.Add(this.radioBCamion);
            this.groupBox1.Controls.Add(this.radioBAvion);
            this.groupBox1.Location = new System.Drawing.Point(60, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 42);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioBAvion
            // 
            this.radioBAvion.AutoSize = true;
            this.radioBAvion.Checked = true;
            this.radioBAvion.Location = new System.Drawing.Point(7, 20);
            this.radioBAvion.Name = "radioBAvion";
            this.radioBAvion.Size = new System.Drawing.Size(52, 17);
            this.radioBAvion.TabIndex = 0;
            this.radioBAvion.TabStop = true;
            this.radioBAvion.Text = "Avión";
            this.radioBAvion.UseVisualStyleBackColor = true;
            // 
            // radioBCamion
            // 
            this.radioBCamion.AutoSize = true;
            this.radioBCamion.Location = new System.Drawing.Point(99, 20);
            this.radioBCamion.Name = "radioBCamion";
            this.radioBCamion.Size = new System.Drawing.Size(60, 17);
            this.radioBCamion.TabIndex = 1;
            this.radioBCamion.Text = "Camión";
            this.radioBCamion.UseVisualStyleBackColor = true;
            // 
            // radioBBarco
            // 
            this.radioBBarco.AutoSize = true;
            this.radioBBarco.Location = new System.Drawing.Point(191, 20);
            this.radioBBarco.Name = "radioBBarco";
            this.radioBBarco.Size = new System.Drawing.Size(53, 17);
            this.radioBBarco.TabIndex = 2;
            this.radioBBarco.Text = "Barco";
            this.radioBBarco.UseVisualStyleBackColor = true;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1051, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dataGridViewPrueba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMapa);
            this.Controls.Add(this.gMapControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mapa_FormClosing);
            this.Load += new System.EventHandler(this.Mapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMapa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrueba)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMapa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtlatitud2;
        private System.Windows.Forms.TextBox txtLongitud2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewPrueba;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBBarco;
        private System.Windows.Forms.RadioButton radioBCamion;
        private System.Windows.Forms.RadioButton radioBAvion;
    }
}