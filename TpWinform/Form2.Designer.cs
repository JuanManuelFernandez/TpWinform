namespace TpWinform
{
    partial class FrmAgregar
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
            this.ButtonImageAgr = new System.Windows.Forms.Button();
            this.TxtPrecioAgr = new System.Windows.Forms.TextBox();
            this.TxtDescripAgr = new System.Windows.Forms.TextBox();
            this.TxtNameAgr = new System.Windows.Forms.TextBox();
            this.TxtCodAgr = new System.Windows.Forms.TextBox();
            this.LbImagen = new System.Windows.Forms.Label();
            this.LbPrecio = new System.Windows.Forms.Label();
            this.LbCateg = new System.Windows.Forms.Label();
            this.LbMarca = new System.Windows.Forms.Label();
            this.LbDescrip = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.LbCodigo = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtMarcaAgr = new System.Windows.Forms.TextBox();
            this.TxtCategAgr = new System.Windows.Forms.TextBox();
            this.PcbImagenAgr = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagenAgr)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonImageAgr
            // 
            this.ButtonImageAgr.Location = new System.Drawing.Point(294, 206);
            this.ButtonImageAgr.Name = "ButtonImageAgr";
            this.ButtonImageAgr.Size = new System.Drawing.Size(248, 23);
            this.ButtonImageAgr.TabIndex = 35;
            this.ButtonImageAgr.Text = "Cargar";
            this.ButtonImageAgr.UseVisualStyleBackColor = true;
            this.ButtonImageAgr.Click += new System.EventHandler(this.ButtonImageAgr_Click);
            // 
            // TxtPrecioAgr
            // 
            this.TxtPrecioAgr.Location = new System.Drawing.Point(294, 171);
            this.TxtPrecioAgr.Name = "TxtPrecioAgr";
            this.TxtPrecioAgr.Size = new System.Drawing.Size(248, 20);
            this.TxtPrecioAgr.TabIndex = 32;
            // 
            // TxtDescripAgr
            // 
            this.TxtDescripAgr.Location = new System.Drawing.Point(294, 73);
            this.TxtDescripAgr.Name = "TxtDescripAgr";
            this.TxtDescripAgr.Size = new System.Drawing.Size(248, 20);
            this.TxtDescripAgr.TabIndex = 31;
            // 
            // TxtNameAgr
            // 
            this.TxtNameAgr.Location = new System.Drawing.Point(294, 44);
            this.TxtNameAgr.Name = "TxtNameAgr";
            this.TxtNameAgr.Size = new System.Drawing.Size(248, 20);
            this.TxtNameAgr.TabIndex = 30;
            // 
            // TxtCodAgr
            // 
            this.TxtCodAgr.Location = new System.Drawing.Point(294, 14);
            this.TxtCodAgr.Name = "TxtCodAgr";
            this.TxtCodAgr.Size = new System.Drawing.Size(248, 20);
            this.TxtCodAgr.TabIndex = 29;
            // 
            // LbImagen
            // 
            this.LbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbImagen.AutoSize = true;
            this.LbImagen.Location = new System.Drawing.Point(224, 211);
            this.LbImagen.Name = "LbImagen";
            this.LbImagen.Size = new System.Drawing.Size(42, 13);
            this.LbImagen.TabIndex = 28;
            this.LbImagen.Text = "Imagen";
            // 
            // LbPrecio
            // 
            this.LbPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPrecio.AutoSize = true;
            this.LbPrecio.Location = new System.Drawing.Point(224, 174);
            this.LbPrecio.Name = "LbPrecio";
            this.LbPrecio.Size = new System.Drawing.Size(37, 13);
            this.LbPrecio.TabIndex = 27;
            this.LbPrecio.Text = "Precio";
            // 
            // LbCateg
            // 
            this.LbCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCateg.AutoSize = true;
            this.LbCateg.Location = new System.Drawing.Point(224, 139);
            this.LbCateg.Name = "LbCateg";
            this.LbCateg.Size = new System.Drawing.Size(54, 13);
            this.LbCateg.TabIndex = 26;
            this.LbCateg.Text = "Categoría";
            // 
            // LbMarca
            // 
            this.LbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbMarca.AutoSize = true;
            this.LbMarca.Location = new System.Drawing.Point(224, 108);
            this.LbMarca.Name = "LbMarca";
            this.LbMarca.Size = new System.Drawing.Size(37, 13);
            this.LbMarca.TabIndex = 25;
            this.LbMarca.Text = "Marca";
            // 
            // LbDescrip
            // 
            this.LbDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbDescrip.AutoSize = true;
            this.LbDescrip.Location = new System.Drawing.Point(224, 76);
            this.LbDescrip.Name = "LbDescrip";
            this.LbDescrip.Size = new System.Drawing.Size(63, 13);
            this.LbDescrip.TabIndex = 24;
            this.LbDescrip.Text = "Descripción";
            // 
            // LbName
            // 
            this.LbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(225, 47);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(44, 13);
            this.LbName.TabIndex = 23;
            this.LbName.Text = "Nombre";
            // 
            // LbCodigo
            // 
            this.LbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Location = new System.Drawing.Point(225, 21);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(40, 13);
            this.LbCodigo.TabIndex = 22;
            this.LbCodigo.Text = "Codigo";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(381, 253);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 36;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtMarcaAgr
            // 
            this.TxtMarcaAgr.Location = new System.Drawing.Point(294, 105);
            this.TxtMarcaAgr.Name = "TxtMarcaAgr";
            this.TxtMarcaAgr.Size = new System.Drawing.Size(248, 20);
            this.TxtMarcaAgr.TabIndex = 37;
            // 
            // TxtCategAgr
            // 
            this.TxtCategAgr.Location = new System.Drawing.Point(294, 136);
            this.TxtCategAgr.Name = "TxtCategAgr";
            this.TxtCategAgr.Size = new System.Drawing.Size(248, 20);
            this.TxtCategAgr.TabIndex = 38;
            // 
            // PcbImagenAgr
            // 
            this.PcbImagenAgr.Location = new System.Drawing.Point(548, 206);
            this.PcbImagenAgr.Name = "PcbImagenAgr";
            this.PcbImagenAgr.Size = new System.Drawing.Size(100, 50);
            this.PcbImagenAgr.TabIndex = 39;
            this.PcbImagenAgr.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(119, 77);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PcbImagenAgr);
            this.Controls.Add(this.TxtCategAgr);
            this.Controls.Add(this.TxtMarcaAgr);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.ButtonImageAgr);
            this.Controls.Add(this.TxtPrecioAgr);
            this.Controls.Add(this.TxtDescripAgr);
            this.Controls.Add(this.TxtNameAgr);
            this.Controls.Add(this.TxtCodAgr);
            this.Controls.Add(this.LbImagen);
            this.Controls.Add(this.LbPrecio);
            this.Controls.Add(this.LbCateg);
            this.Controls.Add(this.LbMarca);
            this.Controls.Add(this.LbDescrip);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.LbCodigo);
            this.Name = "FrmAgregar";
            this.Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagenAgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonImageAgr;
        private System.Windows.Forms.TextBox TxtPrecioAgr;
        private System.Windows.Forms.TextBox TxtDescripAgr;
        private System.Windows.Forms.TextBox TxtNameAgr;
        private System.Windows.Forms.TextBox TxtCodAgr;
        private System.Windows.Forms.Label LbImagen;
        private System.Windows.Forms.Label LbPrecio;
        private System.Windows.Forms.Label LbCateg;
        private System.Windows.Forms.Label LbMarca;
        private System.Windows.Forms.Label LbDescrip;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtMarcaAgr;
        private System.Windows.Forms.TextBox TxtCategAgr;
        private System.Windows.Forms.PictureBox PcbImagenAgr;
        private System.Windows.Forms.ListView listView1;
    }
}