using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Listas
{
    public partial class Frmlistas : Form
    {
        public Frmlistas()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarArray();
        }
        private void AgregarListas()
        {
        
            List<string> nombres = new List<string>();
            nombres.Add("Frank");
            nombres.Add("pablo");
            nombres.Add("carlos");
            nombres.Add("5");
            foreach (string data in nombres)
            {
                listadatos.Items.Add(data);
            }

        }
        private void AgregarArray()
        {
            string[] nombres = { "Frank", "pablo", "Carlos", "5"};
            foreach(string data in nombres)
            {
                listadatos.Items.Add(data);

            }
        }

        private void Frmlistas_Load(object sender, EventArgs e)
        {
            Dibujartecladonumerico();
        }
        private void Dibujartecladonumerico()
        {
            char[] numeros;
            numeros = "0123456789".ToCharArray();
            panelnumerico.Controls.Clear();
            foreach(char numero in numeros)
            {
                Button btnnumero = new Button();
                btnnumero.Text = numero.ToString();
                btnnumero.Size = new Size(72, 67);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.FromArgb(192, 192, 255);
                btnnumero.FlatAppearance.BorderSize = 3;
                panelnumerico.Controls.Add(btnnumero);
                btnnumero.Click += Btnnumero_Click;

            }
        }

        private void Btnnumero_Click(object sender, EventArgs e)
        {
            string numero = ((Button)sender).Text;
            txtpantalla.Text += numero;
        }
    }
}
