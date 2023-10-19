using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _30LIDTS_RicardoCruz_05
{
    public partial class Form1 : Form
    {
        //Datos de conexion a Mysql
        string conexionSQL = "Server= localhost;Port=3306;Database = programacionavanzada; Uid=root; Pwd=;";
        // Metodo para insertar registros
        public Form1()
        {
            InitializeComponent();

            tb_Edad.TextChanged += ValidarEdad;
            tb_Estatura.TextChanged += ValidarEstatura;
            tb_Telefono.TextChanged += ValidarTelefono;
            tb_Nombre.TextChanged += ValidarNombre;
            tb_Apellido.TextChanged += ValidarApellidos;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void InsertarRegistro(string nombre, string apellidos, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(conexionSQL))
            {
                conection.Open();

                string insertQuery = "INSERT INTO registros (Nombre, Apellidos, Edad, Estatura, Telefono, Genero)" + "VALUES (@Nombre, @Apellidos, @Edad, @Estatura, @Telefono, @Genero)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Genero", genero);
                }

                conection.Close();
            }
        }
        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string input)
        {
            if (input.Length != 10)
            {
                return false;
            }
            if (!input.All(char.IsDigit))
            {
                return false;
            }
            return true;

        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }
        public void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsEnteroValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        public void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una Estatura Válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();

            }
        }

        public void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string input = textbox.Text;
            if (input.Length < 10)
            {
                return;
            }
            else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor, ingrese una numero de telefono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();

            }
        }

        public void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una Nombre Válida (Solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();

            }

        }

        public void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una Apellido Válida ( Solo letras y espacios ).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();

            }

        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombres = tb_Nombre.Text;
            string apellidos = tb_Apellido.Text;
            string edad = tb_Edad.Text;
            string estatura = tb_Estatura.Text;
            string telefono = tb_Telefono.Text;
            //Obtenemos genero seleccionado 
            string genero = " ";

            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            //Validar que los campos tengan el formato corrdcto
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsTextoValido(nombres) && EsTextoValido(apellidos))
            {
                
                if ( telefono.Length == 10 && EsEnteroValidoDe10Digitos(telefono))
                {
                    //Crear cadena con los datos 
                    string datos = $"Nombres: {nombres}\r\n Apellidos:{apellidos} \r\n Telefono:{telefono} \r\n Estatura:{estatura} \r\n Edad :{edad}\r\n Genero:{genero}";
                     //Guardar los datos en un archivo de texto
                    string rutaArchivo = "C:/Users/ricar/Documents/datos.txt";
                    bool archivoExiste = File.Exists(rutaArchivo);
                    if (archivoExiste == false) 
                    {
                    File.WriteAllText(rutaArchivo, datos);
                    }
                    else
                    {
                       using (StreamWriter write = new StreamWriter(rutaArchivo, true))
                       {
                         if (archivoExiste)
                         {
                            //Si el archivo existe, añadir un separador antes del nuevo registro
                            write.WriteLine();
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                            MessageBox.Show("Datos registrados correctamente");
                         }
                         else
                         {
                                write.WriteLine(datos);
                                InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telefono, genero);
                                MessageBox.Show("Datos registrados correctamente");
                         }
                            
                       }

                    }
                    //Mensaje de que los datos fueron capturados
                    MessageBox.Show("Datos guardados con exito:\n\n" + datos, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ingrese un telefono valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
                                        
            {
                MessageBox.Show("Por favor, Ingrese datos válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Limpieza
            tb_Nombre.Clear();
            tb_Apellido.Clear();
            tb_Edad.Clear();
            tb_Telefono.Clear();
            tb_Estatura.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }


    }
}
