namespace not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final,sonuc;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            sonuc = Convert.ToDouble(vize * 0.4) + (final * 0.6) / 2;
            
            if (sonuc >= 60) 
            {
                MessageBox.Show("GEÇTÝ",""+ sonuc );
            }

            else 
            {
                MessageBox.Show("KALDI",""+ sonuc );
            }
            

        }
    }
}