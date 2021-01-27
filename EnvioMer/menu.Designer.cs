namespace EnvioMer
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picturMaximizar = new System.Windows.Forms.PictureBox();
            this.picturRestaurar = new System.Windows.Forms.PictureBox();
            this.picturMenos = new System.Windows.Forms.PictureBox();
            this.picturX = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAbrir = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButtonCosto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMenos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.separador);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.bunifuFlatButton3);
            this.MenuVertical.Controls.Add(this.bunifuFlatButton2);
            this.MenuVertical.Controls.Add(this.bunifuFlatButtonCosto);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 584);
            this.MenuVertical.TabIndex = 0;
            // 
            // separador
            // 
            this.separador.BackColor = System.Drawing.Color.Transparent;
            this.separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.separador.LineThickness = 4;
            this.separador.Location = new System.Drawing.Point(12, 93);
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(238, 14);
            this.separador.TabIndex = 11;
            this.separador.Transparency = 255;
            this.separador.Vertical = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BarraTitulo.Controls.Add(this.picturMaximizar);
            this.BarraTitulo.Controls.Add(this.picturRestaurar);
            this.BarraTitulo.Controls.Add(this.picturMenos);
            this.BarraTitulo.Controls.Add(this.picturX);
            this.BarraTitulo.Controls.Add(this.pictureBoxCerrar);
            this.BarraTitulo.Controls.Add(this.pictureBoxAbrir);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(749, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox3);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(749, 534);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EnvioMer.Properties.Resources.nombre;
            this.pictureBox3.Location = new System.Drawing.Point(201, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(339, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // picturMaximizar
            // 
            this.picturMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturMaximizar.Image = global::EnvioMer.Properties.Resources.maxi;
            this.picturMaximizar.Location = new System.Drawing.Point(701, 7);
            this.picturMaximizar.Name = "picturMaximizar";
            this.picturMaximizar.Size = new System.Drawing.Size(20, 20);
            this.picturMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturMaximizar.TabIndex = 2;
            this.picturMaximizar.TabStop = false;
            this.picturMaximizar.Click += new System.EventHandler(this.picturMaximizar_Click);
            // 
            // picturRestaurar
            // 
            this.picturRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturRestaurar.Image = global::EnvioMer.Properties.Resources.res;
            this.picturRestaurar.Location = new System.Drawing.Point(701, 7);
            this.picturRestaurar.Name = "picturRestaurar";
            this.picturRestaurar.Size = new System.Drawing.Size(20, 20);
            this.picturRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturRestaurar.TabIndex = 4;
            this.picturRestaurar.TabStop = false;
            this.picturRestaurar.Click += new System.EventHandler(this.picturRestaurar_Click);
            // 
            // picturMenos
            // 
            this.picturMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturMenos.Image = global::EnvioMer.Properties.Resources.minimazar;
            this.picturMenos.Location = new System.Drawing.Point(676, 7);
            this.picturMenos.Name = "picturMenos";
            this.picturMenos.Size = new System.Drawing.Size(20, 20);
            this.picturMenos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturMenos.TabIndex = 3;
            this.picturMenos.TabStop = false;
            this.picturMenos.Click += new System.EventHandler(this.picturMenos_Click);
            // 
            // picturX
            // 
            this.picturX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturX.Image = global::EnvioMer.Properties.Resources.cerrar;
            this.picturX.Location = new System.Drawing.Point(725, 7);
            this.picturX.Name = "picturX";
            this.picturX.Size = new System.Drawing.Size(20, 20);
            this.picturX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturX.TabIndex = 0;
            this.picturX.TabStop = false;
            this.picturX.Click += new System.EventHandler(this.picturX_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = global::EnvioMer.Properties.Resources.MenuSF;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(47, 44);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // pictureBoxAbrir
            // 
            this.pictureBoxAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbrir.Image = global::EnvioMer.Properties.Resources.Menu2SF;
            this.pictureBoxAbrir.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAbrir.Name = "pictureBoxAbrir";
            this.pictureBoxAbrir.Size = new System.Drawing.Size(47, 44);
            this.pictureBoxAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAbrir.TabIndex = 1;
            this.pictureBoxAbrir.TabStop = false;
            this.pictureBoxAbrir.Visible = false;
            this.pictureBoxAbrir.Click += new System.EventHandler(this.pictureBoxAbrir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EnvioMer.Properties.Resources.nombre;
            this.pictureBox2.Location = new System.Drawing.Point(76, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton3.ButtonText = "Incoterms";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 286);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(250, 75);
            this.bunifuFlatButton3.TabIndex = 5;
            this.bunifuFlatButton3.Text = "Incoterms";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "Cálculo del tiempo de envío ";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::EnvioMer.Properties.Resources.compras;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 225);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(250, 75);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "Cálculo del tiempo de envío ";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButtonCosto
            // 
            this.bunifuFlatButtonCosto.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButtonCosto.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCosto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButtonCosto.BorderRadius = 0;
            this.bunifuFlatButtonCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButtonCosto.ButtonText = "Costos del embarque";
            this.bunifuFlatButtonCosto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonCosto.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonCosto.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCosto.Iconimage = global::EnvioMer.Properties.Resources.pagos;
            this.bunifuFlatButtonCosto.Iconimage_right = null;
            this.bunifuFlatButtonCosto.Iconimage_right_Selected = null;
            this.bunifuFlatButtonCosto.Iconimage_Selected = null;
            this.bunifuFlatButtonCosto.IconMarginLeft = 0;
            this.bunifuFlatButtonCosto.IconMarginRight = 0;
            this.bunifuFlatButtonCosto.IconRightVisible = true;
            this.bunifuFlatButtonCosto.IconRightZoom = 0D;
            this.bunifuFlatButtonCosto.IconVisible = true;
            this.bunifuFlatButtonCosto.IconZoom = 90D;
            this.bunifuFlatButtonCosto.IsTab = false;
            this.bunifuFlatButtonCosto.Location = new System.Drawing.Point(0, 148);
            this.bunifuFlatButtonCosto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButtonCosto.Name = "bunifuFlatButtonCosto";
            this.bunifuFlatButtonCosto.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonCosto.OnHovercolor = System.Drawing.Color.Maroon;
            this.bunifuFlatButtonCosto.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonCosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButtonCosto.selected = false;
            this.bunifuFlatButtonCosto.Size = new System.Drawing.Size(250, 75);
            this.bunifuFlatButtonCosto.TabIndex = 3;
            this.bunifuFlatButtonCosto.Text = "Costos del embarque";
            this.bunifuFlatButtonCosto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonCosto.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonCosto.TextFont = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.bunifuFlatButtonCosto.Click += new System.EventHandler(this.bunifuFlatButtonCosto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 584);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMenos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBoxAbrir;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox picturX;
        private System.Windows.Forms.PictureBox picturMenos;
        private System.Windows.Forms.PictureBox picturMaximizar;
        private System.Windows.Forms.PictureBox picturRestaurar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonCosto;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator separador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

