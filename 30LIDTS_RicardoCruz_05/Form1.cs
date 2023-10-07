using System.Drawing;
using System.Text.RegularExpressions;

namespace _30LIDTS_RicardoCruz_05
{
    public partial class Form1 : Form
    {
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
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) && EsTextoValido(nombres) && EsTextoValido(apellidos))
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
                        }
                        write.WriteLine(datos);
                    }

                }
                //Mensaje de que los datos fueron capturados
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                                        
            {
                MessageBox.Show("Por favor, Ingrese datos válidos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
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
            if (input.Length > 10)
            {
                if (!EsEnteroValidoDe10Digitos(input))
                {
                    MessageBox.Show("Por favor, ingrese una numero de telefono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textbox.Clear();

                }
            }
            else if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor, ingrese una numero de telefono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

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
