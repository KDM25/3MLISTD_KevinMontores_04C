using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLISTD_KevinMontores_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los TexBox
            string nombres = tbNombre.Text;
            string apellidos = tbApellido.Text;
            string telefono = tbTelefono.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;

            string genero = "";

            if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbOtro.Checked)
            {
                genero = "Otro";
            }


            string mensaje = $"Nombre: {nombres}\nApellido: {apellidos}\nTeléfono: {telefono}\nEdad: {edad}\nEstatura: {estatura}\nGénero: {genero}";

            //Ruta del alamacenamiento de archivo TXT
            string rutaFile = "C:\\Users\\monto\\Documents\\#3MAgoDic26.txt";
            bool ArchivoExiste = File.Exists(rutaFile);

            // Instanciacion de la Clase/objeto StreamWriter para escribir archivo TXT.
            using (StreamWriter Escritor = new StreamWriter(rutaFile, true))
            {
                if(ArchivoExiste)
                {
                    Escritor.WriteLine();
                }
                Escritor.WriteLine(mensaje);
            }

            MessageBox.Show(mensaje, "Registro de Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellido.Clear();
            tbTelefono.Clear();
            tbEdad.Clear();
            tbEstatura.Clear();
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            rbOtro.Checked = false;
        }
    }
}
