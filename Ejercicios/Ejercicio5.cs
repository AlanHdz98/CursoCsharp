using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio5 : UserControl
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }
        int n1;
        int n2;
        public string titulo;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Asigarvalores();
            Calcular();
        }
        private void Asigarvalores()
        {
            n1 =Convert.ToInt32( txtn1.Text);
            n2 = Convert.ToInt32(txtn2.Text);

        }
        private void Calcular()
        {
            if(n1%2==0 && n2%2==0)
            {
                lblresultado.Text = "Ambos son pares";
            }
            else if(n1%2 ==0 && n2%2!=0)
            {
                lblresultado.Text = n1 + " es par";
            }
            else if(n1%2!=0 && n2%2==0)
            {
                lblresultado.Text = n2 + " es par";
            }
            else
            {
                lblresultado.Text = "Ambos son impares";
            }
        }
    }
}
