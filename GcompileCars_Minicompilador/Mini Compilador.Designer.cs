namespace Mini_Compilador
{
    partial class MiniCompilador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniCompilador));
            this.Compilar = new System.Windows.Forms.Button();
            this.IngresarLenguaje = new System.Windows.Forms.RichTextBox();
            this.TablaDeErrores = new System.Windows.Forms.DataGridView();
            this.TablaDeSimbolos = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // Compilar
            // 
            this.Compilar.BackColor = System.Drawing.Color.YellowGreen;
            this.Compilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Compilar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Compilar.FlatAppearance.BorderSize = 0;
            this.Compilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compilar.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compilar.ForeColor = System.Drawing.Color.Transparent;
            this.Compilar.Image = ((System.Drawing.Image)(resources.GetObject("Compilar.Image")));
            this.Compilar.Location = new System.Drawing.Point(1048, 467);
            this.Compilar.Margin = new System.Windows.Forms.Padding(2);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(149, 135);
            this.Compilar.TabIndex = 1;
            this.Compilar.UseVisualStyleBackColor = false;
            this.Compilar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IngresarLenguaje
            // 
            this.IngresarLenguaje.BackColor = System.Drawing.Color.Black;
            this.IngresarLenguaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IngresarLenguaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarLenguaje.ForeColor = System.Drawing.Color.Transparent;
            this.IngresarLenguaje.Location = new System.Drawing.Point(4, 432);
            this.IngresarLenguaje.Margin = new System.Windows.Forms.Padding(2);
            this.IngresarLenguaje.Name = "IngresarLenguaje";
            this.IngresarLenguaje.Size = new System.Drawing.Size(1040, 170);
            this.IngresarLenguaje.TabIndex = 2;
            this.IngresarLenguaje.Text = "";
            this.IngresarLenguaje.TextChanged += new System.EventHandler(this.IngresarLenguaje_TextChanged);
            // 
            // TablaDeErrores
            // 
            this.TablaDeErrores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TablaDeErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeErrores.Location = new System.Drawing.Point(586, 34);
            this.TablaDeErrores.Margin = new System.Windows.Forms.Padding(2);
            this.TablaDeErrores.Name = "TablaDeErrores";
            this.TablaDeErrores.RowHeadersWidth = 51;
            this.TablaDeErrores.RowTemplate.Height = 24;
            this.TablaDeErrores.Size = new System.Drawing.Size(611, 394);
            this.TablaDeErrores.TabIndex = 0;
            // 
            // TablaDeSimbolos
            // 
            this.TablaDeSimbolos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TablaDeSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeSimbolos.GridColor = System.Drawing.SystemColors.Highlight;
            this.TablaDeSimbolos.Location = new System.Drawing.Point(4, 34);
            this.TablaDeSimbolos.Margin = new System.Windows.Forms.Padding(2);
            this.TablaDeSimbolos.Name = "TablaDeSimbolos";
            this.TablaDeSimbolos.RowHeadersWidth = 51;
            this.TablaDeSimbolos.RowTemplate.Height = 24;
            this.TablaDeSimbolos.Size = new System.Drawing.Size(578, 394);
            this.TablaDeSimbolos.TabIndex = 3;
            this.TablaDeSimbolos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDeSimbolos_CellContentClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(130, 1);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(319, 36);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Tabla de Simbolos";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox2.Location = new System.Drawing.Point(778, 1);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(283, 36);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "Tabla de Errores";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // MiniCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 609);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Compilar);
            this.Controls.Add(this.IngresarLenguaje);
            this.Controls.Add(this.TablaDeErrores);
            this.Controls.Add(this.TablaDeSimbolos);
            this.Name = "MiniCompilador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Compilador";
            this.Load += new System.EventHandler(this.principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeSimbolos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button Compilar;
        public System.Windows.Forms.RichTextBox IngresarLenguaje;
        public System.Windows.Forms.DataGridView TablaDeErrores;
        public System.Windows.Forms.DataGridView TablaDeSimbolos;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RichTextBox richTextBox2;
    }
}

