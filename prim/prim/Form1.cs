namespace prim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m, p,pp=0, n=0 ;
            m=Convert.ToDouble(textBox1.Text);
            p=Convert.ToDouble(textBox2.Text);
            n =Convert.ToDouble(m+(pp * p));
            

            if (p <= 10 && p>=1)
                pp = 7;
            

            else if (p <= 25 && p >= 11) 
                pp = 15;
            


            else if (p <= 40 && p >= 26) 
                pp = 25;
            


            else
                pp = 50;
            n = m + (p * pp);
            textBox3.Text = n.ToString();
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}