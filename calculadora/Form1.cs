namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtresolver_Click(object sender, EventArgs e)
        {
            if (cmbOpcciones.SelectedIndex == -1)
            {
                MessageBox.Show("no seleccionaste nada");



            }
            else
            {
                int valor1 = Convert.ToInt32(txtvalor1.Text);
                int valor2 = Convert.ToInt32(txtvalor2.Text);
                string opcion = cmbOpcciones.SelectedItem.ToString();
                int respuesta = this.resolverOpercaion(valor1, valor2, opcion);
                txtres.Text = respuesta.ToString();


            }
        }
        public int resolverOpercaion(int valor1, int valor2, String op)
        {

            int res = 0;
            switch (op)
            {
                case "suma":
                    res = valor1 + valor2;
                    break;
                case "resta":
                    res = valor1 - valor2;
                    break;
                case "multiplicacion":
                    res = valor1 * valor2;
                    break;
                case "division":
                    res = valor1 / valor2;
                    break;

            }
            return res;

        }

    }
}