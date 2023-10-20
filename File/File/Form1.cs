using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Yönetici" && textBox2.Text == "1234")
            {
                Form3 frm3seyahat = new Form3();
                frm3seyahat.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

       
    }
}
