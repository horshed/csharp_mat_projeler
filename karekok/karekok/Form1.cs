namespace karekok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            MessageBox.Show("sonuç bulundu"+sonuc);
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            int sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            MessageBox.Show("sonuç bulundu" + sonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double sayi = Double.Parse(textBox1.Text);
            Double Sonuc = Math.Sqrt(sayi);
            label2.Text = "sonuç bulundu"+Sonuc.ToString(); 
            
        }
    }
}