using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kalkulator.Properties;
using Microsoft.JScript;
using Microsoft.JScript.Vsa;

namespace kalkulator
{
    
    public partial class Form1 : Form
    {
        Font formax = new Font("Times New Roman", 20.0f, FontStyle.Bold);

        Font formin = new Font("Times New Roman", 40.0f, FontStyle.Bold);

        int clicks = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OnClicks();
        }
        void OnClicks()
        {
            clicks++;
            if (clicks > 14)
            {
                textBox1.Font = formax;
            }
            else { textBox1.Font = formin; }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string exp = textBox1.Text;


                DataTable dt = new DataTable();
                var v = dt.Compute(exp, "");

                string ans = v.ToString();

                if (ans.Length > 39)
                {
                    textBox1.Text = "ЧИСЛО СЛИШКОМ БОЛЬШОЕ";
                }
                else
                {
                    textBox1.Text = ans;
                }

                if (ans.Length < 14) { textBox1.Font = formin; }
                else { textBox1.Font = formax; }
            }
            catch
            {
                textBox1.Text = "ВЫ СЛОМАЛИ КАЛЬКУЛЯТОР";
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Font = formin;
            clicks = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes("KalkCon.exe", Properties.Resources.KalkCon);
            Process.Start("KalkCon.exe");
            this.Close();
        }
    }
}
