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

            string clave = txtpass.Text;

            if (clave == "123")
                MessageBox.Show("Bienvenido al sistema");
            else
                MessageBox.Show("Usuario y/o Clave incorrecta");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnpass.Text == "Ver")
            {
                btnpass.Text = "Ocultar";
                txtpass.PasswordChar = '\0';
            }
            else
            {
                btnpass.Text = "Ver";
                txtpass.PasswordChar = '*';

            
        }

       
        }
    }
}
