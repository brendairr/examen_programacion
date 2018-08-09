namespace CarreraHilos
{
    partial class Carrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrera));
            this.fototres = new System.Windows.Forms.PictureBox();
            this.botonIniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fotouno = new System.Windows.Forms.PictureBox();
            this.lblLiebre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fototres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotouno)).BeginInit();
            this.SuspendLayout();
            // 
            // fototres
            // 
            this.fototres.Image = ((System.Drawing.Image)(resources.GetObject("fototres.Image")));
            this.fototres.Location = new System.Drawing.Point(25, 180);
            this.fototres.Name = "fototres";
            this.fototres.Size = new System.Drawing.Size(59, 44);
            this.fototres.TabIndex = 2;
            this.fototres.TabStop = false;
            // 
            // botonIniciar
            // 
            this.botonIniciar.Location = new System.Drawing.Point(184, 286);
            this.botonIniciar.Name = "botonIniciar";
            this.botonIniciar.Size = new System.Drawing.Size(80, 23);
            this.botonIniciar.TabIndex = 3;
            this.botonIniciar.Text = "Iniciar Carrera";
            this.botonIniciar.UseVisualStyleBackColor = true;
            this.botonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 185);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fotouno
            // 
            this.fotouno.Image = ((System.Drawing.Image)(resources.GetObject("fotouno.Image")));
            this.fotouno.Location = new System.Drawing.Point(25, 50);
            this.fotouno.Name = "fotouno";
            this.fotouno.Size = new System.Drawing.Size(59, 46);
            this.fotouno.TabIndex = 0;
            this.fotouno.TabStop = false;
            // 
            // lblLiebre
            // 
            this.lblLiebre.AutoSize = true;
            this.lblLiebre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiebre.Location = new System.Drawing.Point(108, 9);
            this.lblLiebre.Name = "lblLiebre";
            this.lblLiebre.Size = new System.Drawing.Size(0, 20);
            this.lblLiebre.TabIndex = 5;
            this.lblLiebre.Visible = false;
            // 
            // Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.lblLiebre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonIniciar);
            this.Controls.Add(this.fototres);
            this.Controls.Add(this.fotouno);
            this.Name = "Carrera";
            this.Text = "Carrera Mortal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.fototres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotouno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox fototres;
        private System.Windows.Forms.Button botonIniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox fotouno;
        private System.Windows.Forms.Label lblLiebre;
    }
}

