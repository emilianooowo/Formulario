using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = TB_Nombre.Text;
            string apellidos = TB_Apellido.Text;
            string edad = TB_Edad.Text;
            string estatura = TB_Estatura.Text;
            string telefono = TB_Telefono.Text;

            string genero = "";
            if (RDB_Hombre.Checked)
            {
                genero = "Hombre";
            }
            else if (RDB_Mujer.Checked)
            {
                genero = "Mujer";
            }
            string datos = $"Nombres: {nombre}\r\nApellidos: {apellidos} \r\nTelefono: +52 {telefono} \r\nEstatura:{estatura} cm\r\nEdad:{edad} años\r\nGenero: {genero}";
            string ruta = "C://Users//pato-//Documents/Datos.txt";
            //File.WriteAllText(ruta,datos);
            bool archivoExiste = File.Exists(ruta);
            Console.WriteLine(archivoExiste);
            if (archivoExiste==false)
            {
                File.WriteAllText(ruta, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
            }
            MessageBox.Show("Datos guardados correctamente:\n"+ datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
