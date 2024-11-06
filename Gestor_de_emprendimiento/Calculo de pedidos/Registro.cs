using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_pedidos
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

            for (int i = 0; i < 1; i++)
            { 
                Calcular datos = new Calcular();

                string dato1 = Convert.ToString(datos.Num);
                string dato2 = Convert.ToString(datos.Cantidad);
                string dato3 = Convert.ToString(datos.Operacion());

                Lista.Items.Add(dato1 + dato2 + dato3);
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VolverR_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
