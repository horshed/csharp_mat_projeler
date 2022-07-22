namespace asalsayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }
            if (sayac == 0)
            {
                label2.Text = "Sayı Asaldır.";
            }
            else
            {
                label2.Text = "Sayı Asal Değil";
            }
        }
    }
}