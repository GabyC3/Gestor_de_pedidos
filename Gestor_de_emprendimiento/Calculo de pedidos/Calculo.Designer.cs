namespace Calculo_de_pedidos
{
    partial class Calculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculo));
            this.Texto1 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.TextBox();
            this.Texto2 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Volver = new System.Windows.Forms.Button();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.BackColor = System.Drawing.Color.Gainsboro;
            this.Texto1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto1.Location = new System.Drawing.Point(41, 62);
            this.Texto1.Name = "Texto1";
            this.Texto1.Padding = new System.Windows.Forms.Padding(5);
            this.Texto1.Size = new System.Drawing.Size(223, 25);
            this.Texto1.TabIndex = 2;
            this.Texto1.Text = "Ingrese el numero del producto:";
            this.Texto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Texto1.Click += new System.EventHandler(this.Texto1_Click);
            // 
            // Lista
            // 
            this.Lista.AutoSize = true;
            this.Lista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lista.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.Location = new System.Drawing.Point(401, 18);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(5);
            this.Lista.Size = new System.Drawing.Size(243, 207);
            this.Lista.TabIndex = 3;
            this.Lista.Text = resources.GetString("Lista.Text");
            this.Lista.Click += new System.EventHandler(this.Lista_Click);
            // 
            // Producto
            // 
            this.Producto.Location = new System.Drawing.Point(44, 116);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(32, 20);
            this.Producto.TabIndex = 4;
            this.Producto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Texto2
            // 
            this.Texto2.AutoSize = true;
            this.Texto2.BackColor = System.Drawing.Color.Gainsboro;
            this.Texto2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto2.Location = new System.Drawing.Point(41, 164);
            this.Texto2.Name = "Texto2";
            this.Texto2.Padding = new System.Windows.Forms.Padding(5);
            this.Texto2.Size = new System.Drawing.Size(145, 25);
            this.Texto2.TabIndex = 5;
            this.Texto2.Text = "Ingrese la cantidad:";
            this.Texto2.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(44, 215);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(32, 20);
            this.Cantidad.TabIndex = 6;
            this.Cantidad.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.Location = new System.Drawing.Point(429, 276);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(81, 36);
            this.Volver.TabIndex = 8;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCalcular.Location = new System.Drawing.Point(545, 276);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(81, 36);
            this.BotonCalcular.TabIndex = 9;
            this.BotonCalcular.Text = "Calcular";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.Color.Gainsboro;
            this.Resultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(41, 260);
            this.Resultado.Name = "Resultado";
            this.Resultado.Padding = new System.Windows.Forms.Padding(5);
            this.Resultado.Size = new System.Drawing.Size(272, 25);
            this.Resultado.TabIndex = 10;
            this.Resultado.Text = "El resultado de esta operacion es de:  $ ";
            this.Resultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(676, 338);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Texto1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Texto2);
            this.Controls.Add(this.Cantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculo";
            this.Text = "Calculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto1;
        private System.Windows.Forms.Label Lista;
        private System.Windows.Forms.TextBox Producto;
        private System.Windows.Forms.Label Texto2;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button BotonCalcular;
        private System.Windows.Forms.Label Resultado;
    }
}