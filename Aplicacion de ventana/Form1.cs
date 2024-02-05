using Matematicas;

namespace Aplicacion_de_ventana
{
    public partial class Form1 : Form
    {
        OpMat ClaseMatematica = new OpMat();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("El resultado es: " + ClaseMatematica.Sumar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("El resultado es: " + ClaseMatematica.Multiplicar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}