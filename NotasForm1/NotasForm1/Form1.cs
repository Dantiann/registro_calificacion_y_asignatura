using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasForm1
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, asignatura;
            float nota1 = 0.0f, nota2 = 0.0f, nota3 = 0.0f, promedio = 0.0f;

            nombres = txtNombres.Text;
            apellidos = txtApellidos.Text;
            asignatura = txtAsignatura.Text;

            // Validación de notas
            nota1 = float.Parse(txtNota1.Text, CultureInfo.InvariantCulture);
            nota2 = float.Parse(txtNota2.Text, CultureInfo.InvariantCulture);
            nota3 = float.Parse(txtNota3.Text, CultureInfo.InvariantCulture);

            if (nota1 >= 1 && nota1 <= 5 && nota2 >= 1 && nota2 <= 5 && nota3 >= 1 && nota3 <= 5)
            {
                promedio = (nota1 + nota2 + nota3) / 3;

                var estado = "";
                if (promedio >= 3.0 && promedio <= 5.0)
                {
                    estado = "APROBO";
                }
                else if (promedio >= 1.0 && promedio < 3.0)
                {
                    estado = "NO APROBO";
                }

                IstEstudiantes.Items.Add($"Estudiante: {nombres} {apellidos}");
                IstEstudiantes.Items.Add($"Notas: {nota1}; {nota2}; {nota3}");
                IstEstudiantes.Items.Add($"Asignatura: {asignatura}");
                IstEstudiantes.Items.Add($"Promedio: {Math.Round(promedio, 2)}");
                IstEstudiantes.Items.Add($"Estado: {estado}");

                MessageBox.Show("         "+estado);

                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtAsignatura.Text = "";
                txtNota1.Text = "";
                txtNota2.Text = "";
                txtNota3.Text = "";
            }
            else
            {
                MessageBox.Show("Error: Las notas deben estar entre 1 y 5.");
            }
            
        }
    
    }
}



