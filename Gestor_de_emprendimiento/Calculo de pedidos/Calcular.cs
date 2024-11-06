using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_pedidos
{
    internal class Calcular
    {
        public int Num {  get; set; }
        public double Cantidad { get; set; }

        

        public double Operacion() {

            double precio1 = 1500;
            double precio2 = 1700;
            double precio3 = 350;
            double precio4 = 350;
            double precio5 = 400;
            double precio6 = 3000;
            double precio7 = 3500;
            double precio8 = 150;
            double precio9 = 4000;
            double precio10 = 3000;

            double Total = 0;



       

                switch (Num)
                {
                    case 1:
                        Total = Cantidad * precio1;
                        break;
                    case 2:
                        Total = Cantidad * precio2;
                        break;
                    case 3:
                        Total = Cantidad * precio3;
                        break;
                    case 4:
                        Total = Cantidad * precio4;
                        break;
                    case 5:
                        Total = Cantidad * precio5;
                        break;
                    case 6:
                        Total = Cantidad * precio6;
                        break;
                    case 7:
                        Total = Cantidad * precio7;
                        break;
                    case 8:
                        Total = Cantidad * precio8;
                        break;
                    case 9:
                        Total = Cantidad * precio9;
                        break;
                    case 10:
                        Total = Cantidad * precio10;
                        break;
                }
                

            return Total;
        }

       
    }
}
