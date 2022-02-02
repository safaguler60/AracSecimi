using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(comboBox1.SelectedItem);
            listBox1.Items.Add(comboBox2.SelectedItem);
            if (checkBox1.Checked == true) listBox1.Items.Add("Elektrikli Aynalar");
            if (checkBox2.Checked == true) listBox1.Items.Add("Elektrikli Koltuklar");
            if (checkBox3.Checked == true) listBox1.Items.Add("Sunroof");
            if (checkBox4.Checked == true) listBox1.Items.Add("Çelik Jant");
            if (radioButton1.Checked == true) listBox1.Items.Add("Benzinli");
            if (radioButton2.Checked == true) listBox1.Items.Add("Dizel");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0)==true)
            {
                comboBox2.Items.Add("i20");
                comboBox2.Items.Add("i30");
                comboBox2.Items.Add("Tucson");
                comboBox2.Items.Add("Elantra");
            }
            else if (comboBox1.SelectedIndex.Equals(1) == true)
            {
                comboBox2.Items.Add("Focus");
                comboBox2.Items.Add("Mondeo");
                comboBox2.Items.Add("Transit");
            }
            else if (comboBox1.SelectedIndex.Equals(2) == true)
            {
                comboBox2.Items.Add("Astra");
                comboBox2.Items.Add("Vectra");
                comboBox2.Items.Add("İnsignia");
            }
            else if (comboBox1.SelectedIndex.Equals(3) == true)
            {
                comboBox2.Items.Add("Civic");
                comboBox2.Items.Add("City");
                comboBox2.Items.Add("Crv");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alınmıştır.");
            Close();
        }
    }
}
