using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Calculo_de_pedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Menu.Items.Add("1.Calcular pedidos");
            Menu.Items.Add("2.Consultar registros previos");

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Seleccion();
        }

        

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Seleccion()
        {
            while (Menu.Items != null)
            {

                if (Menu.SelectedItem.ToString() == "1.Calcular pedidos")
                {
                    Calculo Op1 = new Calculo();
                    Op1.Show();

                }
                else if (Menu.SelectedItem.ToString() == "2.Consultar registros previos")
                {
                    Registro Op2 = new Registro();
                    Op2.Show();

                }

                break;
            }
        }
    }
}
