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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.picturMaximizar = new System.Windows.Forms.PictureBox();
            this.picturRestaurar = new System.Windows.Forms.PictureBox();
            this.picturMenos = new System.Windows.Forms.PictureBox();
            this.picturX = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAbrir = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTNEmbarque = new System.Windows.Forms.Button();
            this.BTNMapa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMenos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbrir)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.BTNMapa);
            this.MenuVertical.Controls.Add(this.BTNEmbarque);
            this.MenuVertical.Controls.Add(this.pictureBox2);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 584);
            this.MenuVertical.TabIndex = 0;
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
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
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
            // BTNEmbarque
            // 
            this.BTNEmbarque.FlatAppearance.BorderSize = 0;
            this.BTNEmbarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEmbarque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEmbarque.ForeColor = System.Drawing.Color.White;
            this.BTNEmbarque.Image = global::EnvioMer.Properties.Resources.compras;
            this.BTNEmbarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEmbarque.Location = new System.Drawing.Point(0, 87);
            this.BTNEmbarque.Name = "BTNEmbarque";
            this.BTNEmbarque.Size = new System.Drawing.Size(250, 49);
            this.BTNEmbarque.TabIndex = 11;
            this.BTNEmbarque.Text = "Embarque";
            this.BTNEmbarque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNEmbarque.UseVisualStyleBackColor = true;
            this.BTNEmbarque.Click += new System.EventHandler(this.BTNEmbarque_Click);
            // 
            // BTNMapa
            // 
            this.BTNMapa.FlatAppearance.BorderSize = 0;
            this.BTNMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMapa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMapa.ForeColor = System.Drawing.Color.White;
            this.BTNMapa.Image = global::EnvioMer.Properties.Resources.compras;
            this.BTNMapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMapa.Location = new System.Drawing.Point(0, 153);
            this.BTNMapa.Name = "BTNMapa";
            this.BTNMapa.Size = new System.Drawing.Size(250, 49);
            this.BTNMapa.TabIndex = 12;
            this.BTNMapa.Text = "Mapa";
            this.BTNMapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMapa.UseVisualStyleBackColor = true;
            this.BTNMapa.Click += new System.EventHandler(this.BTNMapa_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::EnvioMer.Properties.Resources.compras;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Incoterm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 584);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturMenos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbrir)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTNMapa;
        private System.Windows.Forms.Button BTNEmbarque;
        private System.Windows.Forms.Button button1;
    }
}

