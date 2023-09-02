namespace Practico5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LNombre = new Label();
            LApellido = new Label();
            label1 = new Label();
            DTNacimiento = new DateTimePicker();
            LSexo = new Label();
            RBHombre = new RadioButton();
            RBMujer = new RadioButton();
            LSaldo = new Label();
            BFoto = new Button();
            button1 = new Button();
            TxTnombre = new TextBox();
            TxTapellido = new TextBox();
            TxTsaldo = new TextBox();
            TxTFoto = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Fechanacimiento = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNombre.Location = new Point(72, 7);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(79, 25);
            LNombre.TabIndex = 0;
            LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LApellido.Location = new Point(72, 37);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(80, 25);
            LApellido.TabIndex = 1;
            LApellido.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 75);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 2;
            label1.Text = "Fecha nacimiento:";
            // 
            // DTNacimiento
            // 
            DTNacimiento.Location = new Point(257, 81);
            DTNacimiento.Name = "DTNacimiento";
            DTNacimiento.Size = new Size(162, 23);
            DTNacimiento.TabIndex = 3;
            // 
            // LSexo
            // 
            LSexo.AutoSize = true;
            LSexo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LSexo.Location = new Point(72, 121);
            LSexo.Name = "LSexo";
            LSexo.Size = new Size(62, 30);
            LSexo.TabIndex = 4;
            LSexo.Text = "Sexo:";
            // 
            // RBHombre
            // 
            RBHombre.AutoSize = true;
            RBHombre.BackColor = Color.Transparent;
            RBHombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBHombre.ForeColor = Color.White;
            RBHombre.Location = new Point(156, 121);
            RBHombre.Name = "RBHombre";
            RBHombre.Size = new Size(106, 34);
            RBHombre.TabIndex = 5;
            RBHombre.Text = "Hombre";
            RBHombre.UseVisualStyleBackColor = false;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.BackColor = Color.Transparent;
            RBMujer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RBMujer.ForeColor = Color.White;
            RBMujer.Location = new Point(268, 121);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(85, 34);
            RBMujer.TabIndex = 6;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = false;
            // 
            // LSaldo
            // 
            LSaldo.AutoSize = true;
            LSaldo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LSaldo.Location = new Point(70, 166);
            LSaldo.Name = "LSaldo";
            LSaldo.Size = new Size(69, 30);
            LSaldo.TabIndex = 7;
            LSaldo.Text = "Saldo:";
            // 
            // BFoto
            // 
            BFoto.Location = new Point(69, 214);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(70, 31);
            BFoto.TabIndex = 8;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = true;
            BFoto.Click += BFoto_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(230, 248);
            button1.Name = "button1";
            button1.Size = new Size(142, 57);
            button1.TabIndex = 9;
            button1.Text = "Agregar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxTnombre
            // 
            TxTnombre.Location = new Point(170, 11);
            TxTnombre.Name = "TxTnombre";
            TxTnombre.Size = new Size(265, 23);
            TxTnombre.TabIndex = 10;
            TxTnombre.TextAlign = HorizontalAlignment.Center;
            TxTnombre.TextChanged += textBox1_TextChanged;
            TxTnombre.KeyPress += textBox1_KeyPress;
            // 
            // TxTapellido
            // 
            TxTapellido.Location = new Point(170, 39);
            TxTapellido.Name = "TxTapellido";
            TxTapellido.Size = new Size(265, 23);
            TxTapellido.TabIndex = 11;
            TxTapellido.TextAlign = HorizontalAlignment.Center;
            TxTapellido.TextChanged += textBox2_TextChanged;
            TxTapellido.KeyPress += textBox2_KeyPress;
            // 
            // TxTsaldo
            // 
            TxTsaldo.Location = new Point(170, 173);
            TxTsaldo.Name = "TxTsaldo";
            TxTsaldo.Size = new Size(265, 23);
            TxTsaldo.TabIndex = 12;
            TxTsaldo.TextAlign = HorizontalAlignment.Center;
            TxTsaldo.KeyPress += textBox3_KeyPress;
            // 
            // TxTFoto
            // 
            TxTFoto.Enabled = false;
            TxTFoto.Location = new Point(170, 219);
            TxTFoto.Name = "TxTFoto";
            TxTFoto.Size = new Size(265, 23);
            TxTFoto.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(525, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, Fechanacimiento, Sexo, Eliminar, Saldo, Foto, Ruta });
            dataGridView1.Location = new Point(20, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(847, 220);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TxTFoto);
            panel1.Controls.Add(TxTsaldo);
            panel1.Controls.Add(TxTapellido);
            panel1.Controls.Add(TxTnombre);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BFoto);
            panel1.Controls.Add(LSaldo);
            panel1.Controls.Add(RBMujer);
            panel1.Controls.Add(RBHombre);
            panel1.Controls.Add(LSexo);
            panel1.Controls.Add(DTNacimiento);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(20, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 316);
            panel1.TabIndex = 16;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 95;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 94;
            // 
            // Fechanacimiento
            // 
            Fechanacimiento.HeaderText = "Fecha nacimiento";
            Fechanacimiento.Name = "Fechanacimiento";
            Fechanacimiento.ReadOnly = true;
            Fechanacimiento.Width = 95;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Width = 94;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 95;
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            Saldo.ReadOnly = true;
            Saldo.Width = 95;
            // 
            // Foto
            // 
            Foto.FillWeight = 150F;
            Foto.HeaderText = "Foto";
            Foto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            Foto.Resizable = DataGridViewTriState.True;
            Foto.SortMode = DataGridViewColumnSortMode.Automatic;
            Foto.Width = 141;
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            Ruta.ReadOnly = true;
            Ruta.Resizable = DataGridViewTriState.True;
            Ruta.SortMode = DataGridViewColumnSortMode.NotSortable;
            Ruta.Width = 95;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 560);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "TP 5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LNombre;
        private Label LApellido;
        private Label label1;
        private DateTimePicker DTNacimiento;
        private Label LSexo;
        private RadioButton RBHombre;
        private RadioButton RBMujer;
        private Label LSaldo;
        private Button BFoto;
        private Button button1;
        private TextBox TxTnombre;
        private TextBox TxTapellido;
        private TextBox TxTsaldo;
        private TextBox TxTFoto;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fechanacimiento;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}