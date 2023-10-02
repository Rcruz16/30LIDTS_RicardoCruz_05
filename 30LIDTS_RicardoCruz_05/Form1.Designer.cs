namespace _30LIDTS_RicardoCruz_05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Nombre = new TextBox();
            tb_Apellido = new TextBox();
            tb_Telefono = new TextBox();
            tb_Estatura = new TextBox();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            lbl_Telefono = new Label();
            lbl_Estatura = new Label();
            lbl_Edad = new Label();
            tb_Edad = new TextBox();
            rbHombre = new RadioButton();
            rbMujer = new RadioButton();
            btn_Guardar = new Button();
            btn_Cancelar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Nombre
            // 
            tb_Nombre.Location = new Point(122, 9);
            tb_Nombre.Name = "tb_Nombre";
            tb_Nombre.Size = new Size(125, 27);
            tb_Nombre.TabIndex = 0;
            // 
            // tb_Apellido
            // 
            tb_Apellido.Location = new Point(122, 58);
            tb_Apellido.Name = "tb_Apellido";
            tb_Apellido.Size = new Size(125, 27);
            tb_Apellido.TabIndex = 1;
            // 
            // tb_Telefono
            // 
            tb_Telefono.Location = new Point(122, 102);
            tb_Telefono.Name = "tb_Telefono";
            tb_Telefono.Size = new Size(125, 27);
            tb_Telefono.TabIndex = 2;
            // 
            // tb_Estatura
            // 
            tb_Estatura.Location = new Point(122, 145);
            tb_Estatura.Name = "tb_Estatura";
            tb_Estatura.Size = new Size(125, 27);
            tb_Estatura.TabIndex = 3;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.SteelBlue;
            lbl_Nombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Nombre.ForeColor = Color.DarkKhaki;
            lbl_Nombre.Location = new Point(26, 9);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(88, 28);
            lbl_Nombre.TabIndex = 4;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Apellido.ForeColor = Color.DarkKhaki;
            lbl_Apellido.Location = new Point(26, 54);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(90, 28);
            lbl_Apellido.TabIndex = 5;
            lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Telefono.ForeColor = Color.DarkKhaki;
            lbl_Telefono.Location = new Point(26, 98);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(94, 28);
            lbl_Telefono.TabIndex = 6;
            lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Estatura
            // 
            lbl_Estatura.AutoSize = true;
            lbl_Estatura.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Estatura.ForeColor = Color.DarkKhaki;
            lbl_Estatura.Location = new Point(28, 145);
            lbl_Estatura.Name = "lbl_Estatura";
            lbl_Estatura.Size = new Size(92, 28);
            lbl_Estatura.TabIndex = 7;
            lbl_Estatura.Text = "Estatura";
            // 
            // lbl_Edad
            // 
            lbl_Edad.AutoSize = true;
            lbl_Edad.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Edad.ForeColor = Color.DarkKhaki;
            lbl_Edad.Location = new Point(31, 188);
            lbl_Edad.Name = "lbl_Edad";
            lbl_Edad.Size = new Size(59, 28);
            lbl_Edad.TabIndex = 8;
            lbl_Edad.Text = "Edad";
            // 
            // tb_Edad
            // 
            tb_Edad.Location = new Point(122, 192);
            tb_Edad.Name = "tb_Edad";
            tb_Edad.Size = new Size(125, 27);
            tb_Edad.TabIndex = 9;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.Location = new Point(18, 42);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(108, 32);
            rbHombre.TabIndex = 11;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.Location = new Point(133, 42);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(85, 32);
            rbMujer.TabIndex = 12;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(77, 332);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(126, 68);
            btn_Guardar.TabIndex = 13;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(77, 419);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(126, 68);
            btn_Cancelar.TabIndex = 14;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMujer);
            groupBox1.Controls.Add(rbHombre);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkKhaki;
            groupBox1.Location = new Point(26, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 83);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genero";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(306, 499);
            Controls.Add(groupBox1);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Guardar);
            Controls.Add(tb_Edad);
            Controls.Add(lbl_Edad);
            Controls.Add(lbl_Estatura);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(tb_Estatura);
            Controls.Add(tb_Telefono);
            Controls.Add(tb_Apellido);
            Controls.Add(tb_Nombre);
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Nombre;
        private TextBox tb_Apellido;
        private TextBox tb_Telefono;
        private TextBox tb_Estatura;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_Telefono;
        private Label lbl_Estatura;
        private Label lbl_Edad;
        private TextBox tb_Edad;
        private RadioButton rbHombre;
        private RadioButton rbMujer;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private GroupBox groupBox1;
    }
}