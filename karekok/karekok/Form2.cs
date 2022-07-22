using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karekok
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k1, k2, k3;
            k1 = Convert.ToInt32(textBox1.Text);
            k2 = Convert.ToInt32(textBox2.Text);
            k3 = Convert.ToInt32(textBox3.Text);

            if(k1 == k2 && k1==k3)
            {
                MessageBox.Show("Eşkenar Üçgen");
            }
            else if(k1==k2 || k1==k3 || k2==k1 || k2==k3 || k3==k1 || k3==k2 )
            {
                MessageBox.Show("İkizkenar üçgen");

            }
            else
            {
                MessageBox.Show("Çeşitkenar üçgen");
            }
        }
    }
}
