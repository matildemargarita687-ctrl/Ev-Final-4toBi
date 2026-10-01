using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public object TextNum1 { get; private set; }
        public object TextNum2 { get; private set; }
        public object TextLunes { get; private set; }
        public object TexMartes { get; private set; }

        private void Producto_Click(object sender, EventArgs e)
        {
            byte Num1 = byte.Parse(TextVar1.Text);
            byte Num2 = byte.Parse(TextVar2.Text);
            int Producto = Num1 + Num2;
            MessageBox.Show("El R// es" + Producto);


        }

        private void TextVar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            byte Num1 = byte.Parse(TextVar1.Text);
            byte Num2 = byte.Parse(TextVar2.Text);
            int suma = Num1 + Num2;
            MessageBox.Show("El R//es" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            byte num1 = Byte.Parse(TextLunes.Text);
            byte num2 = byte.Parse(TexMartes.Text);
            int Potencia = num1 / num2;
            MessageBox.Show("el R//"+ Potencia);

        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextLunes.Text);
            float Num2 = float.Parse(TexMartes.Text);
            if (Num2 < 0)
                float division = Num1 / Num2;
               MessageBox.Show("el resultado R// es" + divicion)
        }
    }
}
