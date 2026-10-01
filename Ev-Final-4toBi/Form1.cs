using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form1 : Form
    {
        public object TextUsuario { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
        
        } 
         
        private void TextContrasena_TextChanged(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "matilde" && TextContrasena.Text == "23")

                this.Hide();
            Form1 app = new Form1();
                 app.Show();
        
        }
    }   
}
