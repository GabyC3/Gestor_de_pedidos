namespace Calculo_de_pedidos
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.Lista = new System.Windows.Forms.ListView();
            this.Referencia = new System.Windows.Forms.Label();
            this.VolverR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.HideSelection = false;
            this.Lista.Location = new System.Drawing.Point(28, 32);
            this.Lista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(404, 284);
            this.Lista.TabIndex = 0;
            this.Lista.UseCompatibleStateImageBehavior = false;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Referencia
            // 
            this.Referencia.AutoSize = true;
            this.Referencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Referencia.Location = new System.Drawing.Point(452, 32);
            this.Referencia.Name = "Referencia";
            this.Referencia.Padding = new System.Windows.Forms.Padding(5);
            this.Referencia.Size = new System.Drawing.Size(221, 192);
            this.Referencia.TabIndex = 1;
            this.Referencia.Text = resources.GetString("Referencia.Text");
            // 
            // VolverR
            // 
            this.VolverR.Location = new System.Drawing.Point(512, 248);
            this.VolverR.Name = "VolverR";
            this.VolverR.Padding = new System.Windows.Forms.Padding(5);
            this.VolverR.Size = new System.Drawing.Size(80, 35);
            this.VolverR.TabIndex = 2;
            this.VolverR.Text = "Volver";
            this.VolverR.UseVisualStyleBackColor = true;
            this.VolverR.Click += new System.EventHandler(this.VolverR_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(693, 364);
            this.Controls.Add(this.VolverR);
            this.Controls.Add(this.Referencia);
            this.Controls.Add(this.Lista);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lista;
        private System.Windows.Forms.Label Referencia;
        private System.Windows.Forms.Button VolverR;
    }
}