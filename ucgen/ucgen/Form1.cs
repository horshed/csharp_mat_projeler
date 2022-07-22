namespace ucgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k1, k2, k3;
            k1 = Convert.ToInt32(textBox1.Text);
            k2 = Convert.ToInt32(textBox2.Text);
            k3 = Convert.ToInt32(textBox3.Text);

            if (k1 == k2 && k1 == k3)
            {
                MessageBox.Show("Eþkenar Üçgen");
            }
            else if (k1 == k2 || k1 == k3 || k2 == k1 || k2 == k3 || k3 == k1 || k3 == k2)
            {
                MessageBox.Show("Ýkizkenar üçgen");

            }
            else
            {
                MessageBox.Show("Çeþitkenar üçgen");
            }
        }
    }
}