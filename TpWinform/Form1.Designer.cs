namespace TpWinform
{
    partial class Form1
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
            this.LbCodigo = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.LbDescrip = new System.Windows.Forms.Label();
            this.LbMarca = new System.Windows.Forms.Label();
            this.LbCateg = new System.Windows.Forms.Label();
            this.LbPrecio = new System.Windows.Forms.Label();
            this.LbImagen = new System.Windows.Forms.Label();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.ButtonAgregar = new System.Windows.Forms.Button();
            this.ButtonListar = new System.Windows.Forms.Button();
            this.ButtonMod = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.CmbCateg = new System.Windows.Forms.ComboBox();
            this.ListMain = new System.Windows.Forms.ListView();
            this.ButtonImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbCodigo
            // 
            this.LbCodigo.AutoSize = true;
            this.LbCodigo.Location = new System.Drawing.Point(249, 13);
            this.LbCodigo.Name = "LbCodigo";
            this.LbCodigo.Size = new System.Drawing.Size(40, 13);
            this.LbCodigo.TabIndex = 1;
            this.LbCodigo.Text = "Codigo";
            this.LbCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(249, 39);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(44, 13);
            this.LbName.TabIndex = 2;
            this.LbName.Text = "Nombre";
            this.LbName.Click += new System.EventHandler(this.label2_Click);
            // 
            // LbDescrip
            // 
            this.LbDescrip.AutoSize = true;
            this.LbDescrip.Location = new System.Drawing.Point(248, 68);
            this.LbDescrip.Name = "LbDescrip";
            this.LbDescrip.Size = new System.Drawing.Size(63, 13);
            this.LbDescrip.TabIndex = 3;
            this.LbDescrip.Text = "Descripción";
            this.LbDescrip.Click += new System.EventHandler(this.label3_Click);
            // 
            // LbMarca
            // 
            this.LbMarca.AutoSize = true;
            this.LbMarca.Location = new System.Drawing.Point(248, 100);
            this.LbMarca.Name = "LbMarca";
            this.LbMarca.Size = new System.Drawing.Size(37, 13);
            this.LbMarca.TabIndex = 4;
            this.LbMarca.Text = "Marca";
            this.LbMarca.Click += new System.EventHandler(this.label4_Click);
            // 
            // LbCateg
            // 
            this.LbCateg.AutoSize = true;
            this.LbCateg.Location = new System.Drawing.Point(248, 131);
            this.LbCateg.Name = "LbCateg";
            this.LbCateg.Size = new System.Drawing.Size(54, 13);
            this.LbCateg.TabIndex = 5;
            this.LbCateg.Text = "Categoría";
            // 
            // LbPrecio
            // 
            this.LbPrecio.AutoSize = true;
            this.LbPrecio.Location = new System.Drawing.Point(248, 166);
            this.LbPrecio.Name = "LbPrecio";
            this.LbPrecio.Size = new System.Drawing.Size(37, 13);
            this.LbPrecio.TabIndex = 6;
            this.LbPrecio.Text = "Precio";
            // 
            // LbImagen
            // 
            this.LbImagen.AutoSize = true;
            this.LbImagen.Location = new System.Drawing.Point(248, 203);
            this.LbImagen.Name = "LbImagen";
            this.LbImagen.Size = new System.Drawing.Size(42, 13);
            this.LbImagen.TabIndex = 7;
            this.LbImagen.Text = "Imagen";
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(318, 6);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(100, 20);
            this.TxtCod.TabIndex = 8;
            this.TxtCod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(318, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 9;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Location = new System.Drawing.Point(318, 61);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(100, 20);
            this.TxtDescrip.TabIndex = 10;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(318, 159);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 13;
            // 
            // ButtonAgregar
            // 
            this.ButtonAgregar.Location = new System.Drawing.Point(670, 221);
            this.ButtonAgregar.Name = "ButtonAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAgregar.TabIndex = 14;
            this.ButtonAgregar.Text = "Agregar";
            this.ButtonAgregar.UseVisualStyleBackColor = true;
            this.ButtonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // ButtonListar
            // 
            this.ButtonListar.Location = new System.Drawing.Point(751, 221);
            this.ButtonListar.Name = "ButtonListar";
            this.ButtonListar.Size = new System.Drawing.Size(75, 23);
            this.ButtonListar.TabIndex = 15;
            this.ButtonListar.Text = "Listar";
            this.ButtonListar.UseVisualStyleBackColor = true;
            // 
            // ButtonMod
            // 
            this.ButtonMod.Location = new System.Drawing.Point(833, 220);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.Size = new System.Drawing.Size(75, 23);
            this.ButtonMod.TabIndex = 16;
            this.ButtonMod.Text = "Modificar";
            this.ButtonMod.UseVisualStyleBackColor = true;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Location = new System.Drawing.Point(915, 219);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.ButtonEliminar.TabIndex = 17;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            // 
            // CmbMarca
            // 
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(318, 97);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(100, 21);
            this.CmbMarca.TabIndex = 18;
            this.CmbMarca.SelectedIndexChanged += new System.EventHandler(this.CmbMarca_SelectedIndexChanged);
            // 
            // CmbCateg
            // 
            this.CmbCateg.FormattingEnabled = true;
            this.CmbCateg.Location = new System.Drawing.Point(318, 128);
            this.CmbCateg.Name = "CmbCateg";
            this.CmbCateg.Size = new System.Drawing.Size(100, 21);
            this.CmbCateg.TabIndex = 19;
            this.CmbCateg.SelectedIndexChanged += new System.EventHandler(this.CmbCateg_SelectedIndexChanged);
            // 
            // ListMain
            // 
            this.ListMain.HideSelection = false;
            this.ListMain.Location = new System.Drawing.Point(12, 261);
            this.ListMain.Name = "ListMain";
            this.ListMain.Size = new System.Drawing.Size(1006, 252);
            this.ListMain.TabIndex = 20;
            this.ListMain.UseCompatibleStateImageBehavior = false;
            this.ListMain.SelectedIndexChanged += new System.EventHandler(this.ListMain_SelectedIndexChanged);
            // 
            // ButtonImage
            // 
            this.ButtonImage.Location = new System.Drawing.Point(318, 198);
            this.ButtonImage.Name = "ButtonImage";
            this.ButtonImage.Size = new System.Drawing.Size(75, 23);
            this.ButtonImage.TabIndex = 21;
            this.ButtonImage.Text = "Cargar";
            this.ButtonImage.UseVisualStyleBackColor = true;
            this.ButtonImage.Click += new System.EventHandler(this.ButtonImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(670, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 171);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 525);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonImage);
            this.Controls.Add(this.ListMain);
            this.Controls.Add(this.CmbCateg);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonMod);
            this.Controls.Add(this.ButtonListar);
            this.Controls.Add(this.ButtonAgregar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtCod);
            this.Controls.Add(this.LbImagen);
            this.Controls.Add(this.LbPrecio);
            this.Controls.Add(this.LbCateg);
            this.Controls.Add(this.LbMarca);
            this.Controls.Add(this.LbDescrip);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.LbCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbCodigo;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbDescrip;
        private System.Windows.Forms.Label LbMarca;
        private System.Windows.Forms.Label LbCateg;
        private System.Windows.Forms.Label LbPrecio;
        private System.Windows.Forms.Label LbImagen;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonListar;
        private System.Windows.Forms.Button ButtonMod;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.ComboBox CmbCateg;
        private System.Windows.Forms.ListView ListMain;
        private System.Windows.Forms.Button ButtonImage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

