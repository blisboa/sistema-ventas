using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clave = textclave.Text;

            if(clave=="123")
                MessageBox.Show("bienvenido al sistema");
            else
            MessageBox.Show("usuario y/o constraseña es incorrectos");
        }

        private void Btnclave_Click(object sender, EventArgs e)
        {
            if (Btnclave.Text == "ocultar")
            {
                Btnclave.Text = "ver";
                textclave.PasswordChar = '*';
            }
            else
            {
                Btnclave.Text = "ocultar";
                textclave.PasswordChar = '\0';
            }
        }
    }
}
