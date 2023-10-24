namespace compito_24_10_2023
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Quadrato quadrato = new Quadrato();
            Rettangolo rettangolo = new Rettangolo();
            if (comboBox1.Text == "quadrato")
            {


                try
                {

                    quadrato.Lato = textBox1.Text;
                    if (textBox2.Text != "")
                    {
                        MessageBox.Show("il lato 2 è da lascire vuoto non si conta");
                    }

                    int perimetro = int.Parse(quadrato.Lato) * 4;  //int.Parse() per convertire string in int
                    string p = perimetro.ToString(); // ToString() converte da int a stringa

                    MessageBox.Show("il perimetro è: " + p);

                }
                catch (Exception)
                {
                    MessageBox.Show("inserire solo numeri");
                }




            }

            if (comboBox1.Text == "rettangolo")
            {

                try
                {

                    rettangolo.Lato1 = textBox1.Text;
                    rettangolo.Lato2 = textBox2.Text;


                    int perimetro = int.Parse(rettangolo.Lato1) * 2 + int.Parse(rettangolo.Lato2) * 2;  //int.Parse() per convertire string in int
                    string p = perimetro.ToString(); // ToString() converte da int a stringa

                    MessageBox.Show("il perimetro è: " + p);

                }
                catch (Exception)
                {
                    MessageBox.Show("inserire solo numeri");
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quadrato quadrato = new Quadrato();
            Rettangolo rettangolo = new Rettangolo();
            if (comboBox1.Text == "quadrato")
            {


                try
                {

                    quadrato.Lato = textBox1.Text;
                    if (textBox2.Text != "")
                    {
                        MessageBox.Show("il lato 2 è da lascire vuoto non si conta");
                    }

                    int area = int.Parse(quadrato.Lato) * int.Parse(quadrato.Lato);  //int.Parse() per convertire string in int
                    string p = area.ToString(); // ToString() converte da int a stringa

                    MessageBox.Show("l'area è: " + p);

                }
                catch (Exception)
                {
                    MessageBox.Show("inserire solo numeri");
                }




            }

            if (comboBox1.Text == "rettangolo")
            {

                try
                {

                    rettangolo.Lato1 = textBox1.Text;
                    rettangolo.Lato2 = textBox2.Text;


                    int area = int.Parse(rettangolo.Lato1) * int.Parse(rettangolo.Lato2);  //int.Parse() per convertire string in int
                    string p = area.ToString(); // ToString() converte da int a stringa

                    MessageBox.Show("l'area è: " + p);

                }
                catch (Exception)
                {
                    MessageBox.Show("inserire solo numeri");
                }

            }
        }
    }
}