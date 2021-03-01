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
            this.btnFactCom = new System.Windows.Forms.Button();
            this.btnCartaPorte = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnRastreoProd = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.BTNMapa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIncoterm = new System.Windows.Forms.Button();
            this.BTNEmbarque = new System.Windows.Forms.Button();
            this.picturMaximizar = new System.Windows.Forms.PictureBox();
            this.picturRestaurar = new System.Windows.Forms.PictureBox();
            this.picturMenos = new System.Windows.Forms.PictureBox();
            this.picturX = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMenos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.MenuVertical.Controls.Add(this.btnFactCom);
            this.MenuVertical.Controls.Add(this.btnCartaPorte);
            this.MenuVertical.Controls.Add(this.btnRastreoProd);
            this.MenuVertical.Controls.Add(this.btnNewUser);
            this.MenuVertical.Controls.Add(this.BTNMapa);
            this.MenuVertical.Controls.Add(this.panelLogo);
            this.MenuVertical.Controls.Add(this.btnIncoterm);
            this.MenuVertical.Controls.Add(this.BTNEmbarque);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 50);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(200, 670);
            this.MenuVertical.TabIndex = 2;
            this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuVertical_Paint);
            // 
            // btnFactCom
            // 
            this.btnFactCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnFactCom.FlatAppearance.BorderSize = 0;
            this.btnFactCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactCom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactCom.ForeColor = System.Drawing.Color.White;
            this.btnFactCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactCom.Location = new System.Drawing.Point(0, 397);
            this.btnFactCom.Name = "btnFactCom";
            this.btnFactCom.Size = new System.Drawing.Size(200, 70);
            this.btnFactCom.TabIndex = 18;
            this.btnFactCom.Text = "Factura\r\nComercial";
            this.btnFactCom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFactCom.UseVisualStyleBackColor = false;
            this.btnFactCom.Click += new System.EventHandler(this.btnFactCom_Click);
            // 
            // btnCartaPorte
            // 
            this.btnCartaPorte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCartaPorte.FlatAppearance.BorderSize = 0;
            this.btnCartaPorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartaPorte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartaPorte.ForeColor = System.Drawing.Color.White;
            this.btnCartaPorte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartaPorte.Location = new System.Drawing.Point(0, 472);
            this.btnCartaPorte.Name = "btnCartaPorte";
            this.btnCartaPorte.Size = new System.Drawing.Size(200, 70);
            this.btnCartaPorte.TabIndex = 17;
            this.btnCartaPorte.Text = "Carta Porte";
            this.btnCartaPorte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCartaPorte.UseVisualStyleBackColor = false;
            this.btnCartaPorte.Click += new System.EventHandler(this.btnCartaPorte_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 14;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.picturMaximizar);
            this.BarraTitulo.Controls.Add(this.picturRestaurar);
            this.BarraTitulo.Controls.Add(this.picturMenos);
            this.BarraTitulo.Controls.Add(this.picturX);
            this.BarraTitulo.Controls.Add(this.pictureBoxCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1280, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestión y Envio de Mercancias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 670);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnRastreoProd
            // 
            this.btnRastreoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnRastreoProd.FlatAppearance.BorderSize = 0;
            this.btnRastreoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRastreoProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRastreoProd.ForeColor = System.Drawing.Color.White;
            this.btnRastreoProd.Image = global::EnvioMer.Properties.Resources.escaneoCodigo;
            this.btnRastreoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRastreoProd.Location = new System.Drawing.Point(0, 323);
            this.btnRastreoProd.Name = "btnRastreoProd";
            this.btnRastreoProd.Size = new System.Drawing.Size(200, 70);
            this.btnRastreoProd.TabIndex = 16;
            this.btnRastreoProd.Text = "Rastreo del\r\nProducto";
            this.btnRastreoProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRastreoProd.UseVisualStyleBackColor = false;
            this.btnRastreoProd.Click += new System.EventHandler(this.btnRastreoProd_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Image = global::EnvioMer.Properties.Resources.usuario;
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.Location = new System.Drawing.Point(0, 546);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(198, 70);
            this.btnNewUser.TabIndex = 15;
            this.btnNewUser.Text = "Nuevo Usuario";
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // BTNMapa
            // 
            this.BTNMapa.FlatAppearance.BorderSize = 0;
            this.BTNMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMapa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMapa.ForeColor = System.Drawing.Color.White;
            this.BTNMapa.Image = global::EnvioMer.Properties.Resources.mapa;
            this.BTNMapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMapa.Location = new System.Drawing.Point(0, 174);
            this.BTNMapa.Name = "BTNMapa";
            this.BTNMapa.Size = new System.Drawing.Size(200, 70);
            this.BTNMapa.TabIndex = 12;
            this.BTNMapa.Text = "Mapa";
            this.BTNMapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMapa.UseVisualStyleBackColor = true;
            this.BTNMapa.Click += new System.EventHandler(this.BTNMapa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::EnvioMer.Properties.Resources.nombre;
            this.pictureBox2.Location = new System.Drawing.Point(62, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnIncoterm
            // 
            this.btnIncoterm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnIncoterm.FlatAppearance.BorderSize = 0;
            this.btnIncoterm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncoterm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncoterm.ForeColor = System.Drawing.Color.White;
            this.btnIncoterm.Image = global::EnvioMer.Properties.Resources.incoterms;
            this.btnIncoterm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncoterm.Location = new System.Drawing.Point(0, 248);
            this.btnIncoterm.Name = "btnIncoterm";
            this.btnIncoterm.Size = new System.Drawing.Size(200, 70);
            this.btnIncoterm.TabIndex = 13;
            this.btnIncoterm.Text = "Incoterm";
            this.btnIncoterm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncoterm.UseVisualStyleBackColor = false;
            this.btnIncoterm.Click += new System.EventHandler(this.btnIncoterm_Click);
            // 
            // BTNEmbarque
            // 
            this.BTNEmbarque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BTNEmbarque.FlatAppearance.BorderSize = 0;
            this.BTNEmbarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEmbarque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEmbarque.ForeColor = System.Drawing.Color.White;
            this.BTNEmbarque.Image = global::EnvioMer.Properties.Resources.embarcacion;
            this.BTNEmbarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEmbarque.Location = new System.Drawing.Point(0, 100);
            this.BTNEmbarque.Name = "BTNEmbarque";
            this.BTNEmbarque.Size = new System.Drawing.Size(200, 70);
            this.BTNEmbarque.TabIndex = 11;
            this.BTNEmbarque.Text = "Embarque";
            this.BTNEmbarque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNEmbarque.UseVisualStyleBackColor = false;
            this.BTNEmbarque.Click += new System.EventHandler(this.BTNEmbarque_Click);
            // 
            // picturMaximizar
            // 
            this.picturMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.picturMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturMaximizar.Image = global::EnvioMer.Properties.Resources.maximize;
            this.picturMaximizar.Location = new System.Drawing.Point(1206, 7);
            this.picturMaximizar.Name = "picturMaximizar";
            this.picturMaximizar.Size = new System.Drawing.Size(32, 32);
            this.picturMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturMaximizar.TabIndex = 2;
            this.picturMaximizar.TabStop = false;
            this.picturMaximizar.Click += new System.EventHandler(this.picturMaximizar_Click);
            // 
            // picturRestaurar
            // 
            this.picturRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.picturRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturRestaurar.Image = global::EnvioMer.Properties.Resources.restaurar;
            this.picturRestaurar.Location = new System.Drawing.Point(1206, 7);
            this.picturRestaurar.Name = "picturRestaurar";
            this.picturRestaurar.Size = new System.Drawing.Size(32, 32);
            this.picturRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturRestaurar.TabIndex = 4;
            this.picturRestaurar.TabStop = false;
            this.picturRestaurar.Click += new System.EventHandler(this.picturRestaurar_Click);
            // 
            // picturMenos
            // 
            this.picturMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturMenos.BackColor = System.Drawing.Color.Transparent;
            this.picturMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturMenos.Image = global::EnvioMer.Properties.Resources.minimize;
            this.picturMenos.Location = new System.Drawing.Point(1168, 7);
            this.picturMenos.Name = "picturMenos";
            this.picturMenos.Size = new System.Drawing.Size(32, 32);
            this.picturMenos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturMenos.TabIndex = 3;
            this.picturMenos.TabStop = false;
            this.picturMenos.Click += new System.EventHandler(this.picturMenos_Click);
            // 
            // picturX
            // 
            this.picturX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturX.BackColor = System.Drawing.Color.Transparent;
            this.picturX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturX.Image = global::EnvioMer.Properties.Resources.eliminar;
            this.picturX.Location = new System.Drawing.Point(1244, 7);
            this.picturX.Name = "picturX";
            this.picturX.Size = new System.Drawing.Size(32, 32);
            this.picturX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturX.TabIndex = 0;
            this.picturX.TabStop = false;
            this.picturX.Click += new System.EventHandler(this.picturX_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = global::EnvioMer.Properties.Resources.menuBarraWhite;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(6, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(47, 44);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.DoubleBuffered = true;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMenos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox picturX;
        private System.Windows.Forms.PictureBox picturMenos;
        private System.Windows.Forms.PictureBox picturMaximizar;
        private System.Windows.Forms.PictureBox picturRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNMapa;
        private System.Windows.Forms.Button BTNEmbarque;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIncoterm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnRastreoProd;
        private System.Windows.Forms.Button btnFactCom;
        private System.Windows.Forms.Button btnCartaPorte;
    }
}