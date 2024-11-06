namespace Calculo_de_pedidos
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu = new System.Windows.Forms.ComboBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Continuar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.FormattingEnabled = true;
            this.Menu.Location = new System.Drawing.Point(115, 135);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(193, 22);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Seleccione una opcion:";
            this.Menu.SelectedIndexChanged += new System.EventHandler(this.Menu_SelectedIndexChanged);
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(114, 200);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(80, 35);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "SALIR";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Continuar
            // 
            this.Continuar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continuar.Location = new System.Drawing.Point(213, 200);
            this.Continuar.Name = "Continuar";
            this.Continuar.Size = new System.Drawing.Size(95, 35);
            this.Continuar.TabIndex = 7;
            this.Continuar.Text = "CONTINUAR";
            this.Continuar.UseVisualStyleBackColor = true;
            this.Continuar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(137, 64);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(158, 25);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "CALCULO DE PEDIDOS ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(446, 328);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Continuar);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Salir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox Menu;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Continuar;
        private System.Windows.Forms.Label Titulo;
    }
}

