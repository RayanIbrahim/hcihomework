using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_work_HCI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum){


                progressBar1.Value += 1;}

            else
            {
                timer1.Stop();


                MessageBox.Show("compleate","Message",MessageBoxButtons.OK);}
}
















        

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
}

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
