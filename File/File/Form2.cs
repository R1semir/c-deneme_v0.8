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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listbKoltuk.Items.Add("1");
            listbAdi.Items.Add(textBox1.Text);
            listbTel.Items.Add(textBox2.Text);
            listbIlce.Items.Add(comboBox1.Text);
            listBSaat.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listbCinsiyet.Items.Add("Bay");
            }
            else
            {
                listbCinsiyet.Items.Add("Bayan");
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listbKoltuk.Items.Add("2");
            listbAdi.Items.Add(textBox1.Text);
            listbTel.Items.Add(textBox2.Text);
            listbIlce.Items.Add(comboBox1.Text);
            listBSaat.Items.Add(comboBox2.Text);
            if(radioButton1.Checked == true)
            {
                listbCinsiyet.Items.Add(radioButton1.Text);
            }
            else
            {
                listbCinsiyet.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listbKoltuk.Items.Add("3");
            listbAdi.Items.Add(textBox1.Text);
            listbTel.Items.Add(textBox2.Text);
            listbIlce.Items.Add(comboBox1.Text);
            listBSaat.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listbCinsiyet.Items.Add(radioButton1.Text);
            }
            else
            {
                listbCinsiyet.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            listbKoltuk.Items.Add("4");
            listbAdi.Items.Add(textBox1.Text);
            listbTel.Items.Add(textBox2.Text);
            listbIlce.Items.Add(comboBox1.Text);
            listBSaat.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listbCinsiyet.Items.Add(radioButton1.Text);
            }
            else
            {
                listbCinsiyet.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            listbKoltuk.Items.Add("5");
            listbAdi.Items.Add(textBox1.Text);
            listbTel.Items.Add(textBox2.Text);
            listbIlce.Items.Add(comboBox1.Text);
            listBSaat.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listbCinsiyet.Items.Add(radioButton1.Text);
            }
            else
            {
                listbCinsiyet.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            listbKoltuk.Items.Add("6");
            listbAdi.Items.Add(textBox1.Text);
            listbTel.Items.Add(textBox2.Text);
            listbIlce.Items.Add(comboBox1.Text);
            listBSaat.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listbCinsiyet.Items.Add(radioButton1.Text);
            }
            else
            {
                listbCinsiyet.Items.Add(radioButton2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            btn6.Enabled = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            listBSoför.Items.Add(textBox1.Text);
            btn0.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 geri = new Form3();
            geri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
        }
    }
}
