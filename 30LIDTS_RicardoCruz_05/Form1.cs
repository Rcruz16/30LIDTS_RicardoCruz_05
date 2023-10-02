namespace _30LIDTS_RicardoCruz_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            //Crear cadena con los datos

            string datos = $"Nombres: {nombres}\r\n Apellidos:{apellidos} \r\n Telefono:{telefono} \r\n Estatura:{estatura} \r\n Edad :{edad}\r\n Genero:{genero}";
            //Guardar los datos en un archivo de texto
            string rutaArchivo = "C:/Users/ricar/Documents/datos.txt";
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter write = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    //Si el archivo existe, añadir un separador antes del nuevo registro
                    write.WriteLine();
                }
                write.WriteLine(datos);

                //Mensaje de que los datos fueron capturados
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
