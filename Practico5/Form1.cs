namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            //SUBIR UNA IMAGEN
            OpenFileDialog ofdSleccionar = new OpenFileDialog();
            ofdSleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSleccionar.Title = "Seleccionar Foto de Perfil";


            if (ofdSleccionar.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = null;
                pictureBox1.Image = Image.FromFile(ofdSleccionar.FileName);
                TxTFoto.Text = ofdSleccionar.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TEXTO NOMBRE CON PRIMERA LETRA MAYUSCULA AUTOMATICAMENTE
            TxTnombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxTnombre.Text);
            TxTnombre.SelectionStart = TxTnombre.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TEXTO APELLIDO CON PRIMERA LETRA MAYUSCULA AUTOMATICAMENTE
            TxTapellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxTapellido.Text);
            TxTapellido.SelectionStart = TxTapellido.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CONOCER EL SEXO
            string sexo;
            if (RBHombre.Checked)
            {
                sexo = RBHombre.Text;
            }
            else
            {
                sexo = RBMujer.Text;
            }

            Image imagen = pictureBox1.Image;
            string saldo = TxTsaldo.Text.ToString();
            if (!string.IsNullOrWhiteSpace(TxTnombre.Text) && !string.IsNullOrEmpty(TxTapellido.Text) && RBHombre.Checked
                || RBMujer.Checked && !string.IsNullOrWhiteSpace(TxTsaldo.Text) && TxTFoto.Text != "")
            {
                //añadir las columnas al grid
               int filas = dataGridView1.Rows.Add(TxTnombre.Text, TxTapellido.Text, DTNacimiento.Text, sexo, "ELIMINAR", saldo, imagen, TxTFoto.Text);

                //llamado a la funcion de borrado
                EliminarCampos();

                //permite que luego de cargar los datos, el picture box vuelve a su imagen original
                pictureBox1.Image = Properties.Resources.avatar;
                
                //color rojo cuando saldo < 50
                if(Int32.Parse(saldo) < 50) {
                dataGridView1.Rows[filas].DefaultCellStyle.BackColor = Color.Red;
                dataGridView1.Rows[filas].DefaultCellStyle.SelectionBackColor = Color.Red;
                dataGridView1.Rows[filas].DefaultCellStyle.ForeColor = Color.Red;
             }
        }
            else
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo letras
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //ELIMINAR FILA DE DATOS
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult result = MessageBox.Show("Seguro que desea eliminar?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    MessageBox.Show("Usuarlio eliminado", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //FUNCION DE BORRADO
        private void EliminarCampos()
        {
            TxTnombre.Clear();
            TxTapellido.Clear();
            DTNacimiento.Checked = false;
            RBHombre.Checked = false;
            RBMujer.Checked = false;
            DTNacimiento.Value = DateTime.UtcNow;
            TxTFoto.Clear();
            TxTsaldo.Clear();
        }
    }
}