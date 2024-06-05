using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            string adsoyad=textBox1.Text.ToString();
            string koltukno=textBox2.Text.ToString();
            if (koltukno=="A1")
            {
                button1.BackColor = Color.Red;
            }
            if (koltukno=="A2")
            {
                button2.BackColor = Color.Red;
            }
            if (koltukno == "A3")
            {
                button3.BackColor = Color.Red;
            }
            if (koltukno == "A4")
            {
                button4.BackColor = Color.Red;
            }
            if (koltukno == "A5")
            {
                button5.BackColor = Color.Red;
            }
            if (koltukno == "A6")
            {
                button6.BackColor = Color.Red;
            }
            if (koltukno == "B1")
            {
                button7.BackColor = Color.Red;
            }
            if (koltukno == "B2")
            {
                button8.BackColor = Color.Red;
            }
            if (koltukno == "B3")
            {
                button9.BackColor = Color.Red;
            }
            if (koltukno == "B4")
            {
                button10.BackColor = Color.Red;
            }
            if (koltukno == "B5")
            {
                button11.BackColor = Color.Red;
            }
            if (koltukno == "B6")
            {
                button12.BackColor = Color.Red;
            }
            if (koltukno == "C1")
            {
                button13.BackColor = Color.Red;
            }
            if (koltukno == "C2")
            {
                button14.BackColor = Color.Red;
            }
            if (koltukno == "C3")
            {
                button15.BackColor = Color.Red;
            }
            if (koltukno == "C4")
            {
                button16.BackColor = Color.Red;
            }
            if(koltukno =="C5")
            {
                button17.BackColor = Color.Red;
            }
            if (koltukno == "C6")
            {
                button18.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli bir koltuk numarası giriniz örn=A1");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
