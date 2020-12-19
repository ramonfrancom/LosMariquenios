using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LosMariquenios.Clases;

namespace LosMariquenios
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string rfc = textBoxLoginRFC.Text;
            string nombre = null;
            if (Empleado.getPassOfUser(rfc, out nombre) == textBoxLoginContrasena.Text && nombre != "")
            {
                MainForm mainForm = new MainForm(rfc, nombre);
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
                mainForm.Dispose();
            }
            else
            {
                MessageBox.Show("Datos ingresados incorrectos", "Datos ingresados incorrectos");
            }

            
        }
    }
}
