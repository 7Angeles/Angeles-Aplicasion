using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Angeles_Aplicasion;

namespace Angeles_Aplicasion.Formas
{
    public partial class FormaRefistros : Form
    {
        private object dataEstudiante;

        public static object Rows { get; private set; }

        public FormaRefistros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo objeto DataGridViewRow
                DataGridViewRow row = new DataGridViewRow();

                // Asignar valores a las celdas del objeto DataGridViewRow
                row.Cells[0].Value = textBox1.Text; // Primera Columna
                row.Cells[1].Value = textBox2.Text; // Segunda columna
                row.Cells[2].Value = textBox3.Text; // Tercera Columna
                row.Cells[3].Value = comboBox1.Text; // Cuarta Columna
                row.Cells[4].Value = comboBox2.Text; // Quinta Columna

                // Agregar el objeto DataGridViewRow al control DataGridView
                dataEstudiante.Rows.Add(row);

            }

            catch (Exception ex) //En caso que ocurra un error

            {

                MessageBox.Show(ex.Message, "Agregando Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";

            string titulo = "Eliminando el registro";
            if (!(dataEstudiante.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                    }
                    catch (Exception ex)

                    {

                        MessageBox.Show(ex.Message, "Eliminado Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglón", "Eliminado Estudiante",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataEstudiante.SelectedRows.Count <= 0) //En caso que no exista renglón seleccionado 
            {


                MessageBox.Show("Debes seleccionar un renglón", "Modificando Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else

            {
                textBox1.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Apellidos"].Value.ToString();
                textBox3.Text = dataEstudiante.CurrentRow.Cells["Matricula"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();
            }
        }
    }
}
    


