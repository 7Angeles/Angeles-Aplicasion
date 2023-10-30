using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Angeles_Aplicasion.Formas;

namespace Angeles_Aplicasion
{
    public partial class Form1 : Form
    {
        private int intentos;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // si estan vasios
            if (usuario == "" || contraseña == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
                return;
            }

            // solo tienes 3
            if (usuario.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres");
                return;
            }

            // Comparar el usuario y contraseña con los correctos
            if (usuario == "Pato" && contraseña == "1234")
            {
                // Mostrar un mensaje de bienvenida y abrir la pantalla principal
                MessageBox.Show("Bienvenido " + usuario);
                FormaRefistros form2 = new FormaRefistros();
                form2.Show();
                this.Hide();
            }
            else
            {
                // Incrementar el número de intentos fallidos
                intentos++;

                // Mostrar un mensaje de error según el caso
                if (usuario == "Pato")
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                else if (contraseña == "1234")
                {
                    MessageBox.Show("Usuario incorrecto");
                }
                else
                {
                    MessageBox.Show("Usuario y contraseña incorrectos");
                }

                // máximo permitido
                if (intentos >= 3)
                {
                    MessageBox.Show("Has superado el número máximo de intentos. El programa se cerrará.");
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
