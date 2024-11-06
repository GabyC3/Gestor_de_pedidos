using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculo_de_pedidos
{
    public partial class Calculo : Form
    {
        public Calculo()
        {
            InitializeComponent();

            Resultado.Hide();
            
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            Convertir();

            Limpiar();
        }

         

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Lista_Click(object sender, EventArgs e)
        {

        }

        private void Texto1_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            Resultado.Show();
            Producto.Text = " ";
            Cantidad.Text = " ";
        }

        public void Convertir()
        {
            Resultado.Text = "El resultado de esta operacion es de:  $ ";
            
            int num = Convert.ToInt32(Producto.Text);
            double cant = Convert.ToDouble(Cantidad.Text);


            Calcular calcular = new Calcular { Num = num, Cantidad = cant };

            
            double total = calcular.Operacion();

            Resultado.Text += total;
        }

        private void Operaciones_Click(object sender, EventArgs e)
        {

        }

        private void Operar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
