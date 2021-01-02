using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_Billing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.Text.Length>0)
            {
                textBox6.Text = (Convert.ToInt32(textBox4.Text) - Convert.ToInt32(textBox5.Text)).ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("JALEBI - GHEE");
            comboBox1.Items.Add("MOHANTHAL");
            comboBox1.Items.Add("PENDA");
            comboBox1.Items.Add("THABI");
            comboBox1.Items.Add("KALAKAND");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton1.ForeColor = System.Drawing.Color.Red;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("SAMOSA");
            comboBox1.Items.Add("KACHORI");
            comboBox1.Items.Add("DHOKLA");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "KALAKAND")
            {
                textBox1.Text = "360";
            }
            else if (comboBox1.SelectedItem.ToString()=="JALEBI - GHEE")
            {
                textBox1.Text = "300";
            }
            else if (comboBox1.SelectedItem.ToString() == "MOHANTHAL")
            {
                textBox1.Text = "360";
            }
            else if (comboBox1.SelectedItem.ToString() == "PENDA")
            {
                textBox1.Text = "360";
            }
            else if (comboBox1.SelectedItem.ToString() == "THABI")
            {
                textBox1.Text = "400";
            }
            else if (comboBox1.SelectedItem.ToString() == "DHOKLA")
            {
                textBox1.Text = "20";
            }
            else if (comboBox1.SelectedItem.ToString() == "KACHORI")
            {
                textBox1.Text = "10";
            }
            else if (comboBox1.SelectedItem.ToString() == "SAMOSA")
            {
                textBox1.Text = "10";
            }
            else
            {
                textBox1.Text = "0";
            }
            textBox4.Text = "";
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
                textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arraynew = new string[4];
            arraynew[0] = comboBox1.SelectedItem.ToString();
            arraynew[1] = textBox1.Text;
            arraynew[2] = textBox2.Text;
            arraynew[3] = textBox3.Text;

            ListViewItem lvi = new ListViewItem(arraynew);
            listView1.Items.Add(lvi);
            
            if(textBox4.Text=="")
            textBox4.Text = (0 + Convert.ToInt32(textBox3.Text)).ToString();
            else
            {
                textBox4.Text = (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox3.Text)).ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if(textBox7.Text.Length>0)
            {
                if (Convert.ToInt32(textBox7.Text) < Convert.ToInt32(textBox6.Text))
                {
                    textBox8.Text = (Convert.ToInt32(textBox6.Text) - Convert.ToInt32(textBox7.Text)).ToString();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
