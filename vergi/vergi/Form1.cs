namespace vergi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maas,sonuc=0 ;
            maas=Convert.ToInt32(textBox1.Text);

            if (maas <= 10000)
                sonuc = maas - (maas * 10)/100;
            

            
                else if(maas <= 12000)
                    sonuc= maas - (maas * 15)/100;
            
            
            else 
                sonuc=maas - (maas * 20)/100;
            textBox2.Text = sonuc.ToString();
            

               
                                   
                
        }
    }
}