﻿namespace EnvioMer
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
            this.BTNMapa = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIncoterm = new System.Windows.Forms.Button();
            this.BTNEmbarque = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.picturMaximizar = new System.Windows.Forms.PictureBox();
            this.picturRestaurar = new System.Windows.Forms.PictureBox();
            this.picturMenos = new System.Windows.Forms.PictureBox();
            this.picturX = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.BarraTitulo.SuspendLayout();
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
            this.MenuVertical.Controls.Add(this.BTNMapa);
            this.MenuVertical.Controls.Add(this.panelLogo);
            this.MenuVertical.Controls.Add(this.btnIncoterm);
            this.MenuVertical.Controls.Add(this.BTNEmbarque);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(200, 720);
            this.MenuVertical.TabIndex = 0;
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
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.BarraTitulo.Controls.Add(this.picturMaximizar);
            this.BarraTitulo.Controls.Add(this.picturRestaurar);
            this.BarraTitulo.Controls.Add(this.picturMenos);
            this.BarraTitulo.Controls.Add(this.picturX);
            this.BarraTitulo.Controls.Add(this.pictureBoxCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1080, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // picturMaximizar
            // 
            this.picturMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.picturMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturMaximizar.Image = global::EnvioMer.Properties.Resources.maximize;
            this.picturMaximizar.Location = new System.Drawing.Point(1006, 7);
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
            this.picturRestaurar.Location = new System.Drawing.Point(1006, 7);
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
            this.picturMenos.Location = new System.Drawing.Point(968, 7);
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
            this.picturX.Location = new System.Drawing.Point(1044, 7);
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
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1080, 670);
            this.panelContenedor.TabIndex = 2;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.DoubleBuffered = true;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
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
        private System.Windows.Forms.Panel panelContenedor;
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
    }
}