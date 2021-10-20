using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_system
{
    public partial class Form1 : Form
    {
        private object checkBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("yyyy.MM.dd");
            label5.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = default;
            comboBox2.SelectedItem = default;
            comboBox3.SelectedItem = default;
            comboBox1.Text = "請選擇班級";
            comboBox2.Text = "請選擇模式";
            comboBox3.Text = "請選擇地點";
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("即將推出...", "系統提示");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == default)
                {
                    MessageBox.Show("請選擇班級", "系統提示");
                }
                else if (comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("請選擇模式", "系統提示");
                }
                else if (comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("請選擇地點", "系統提示");
                }
                else if (textBox1.Text == null)
                {
                    MessageBox.Show("請輸入學號", "系統提示");
                }
                else if (textBox2.Text == null)
                {
                    MessageBox.Show("請輸入姓名", "系統提示");
                }
                else if (textBox3.Text == null)
                {
                    MessageBox.Show("請輸入手機", "系統提示");
                }

                else if (!(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked))
                {
                    MessageBox.Show("請至少輸入一樣設備", "系統提示");
                    //MessageBox.Show($"{checkBox1.Checked} {checkBox2.Checked} {checkBox3.Checked } {checkBox4.Checked}");
                    //MessageBox.Show($"{!checkBox1.Checked || !checkBox2.Checked || !checkBox3.Checked || !checkBox4.Checked}");
                }
                else
                {
                    string device = "";
                    if (checkBox1.Checked)
                    {
                        device = device.Insert(device.Length, $"{checkBox1.Text}");
                    }
                    else if (checkBox2.Checked)
                    {
                        device = device.Insert(device.Length, $"{checkBox2.Text}");
                    }
                    else if (checkBox3.Checked)
                    {
                        device = device.Insert(device.Length, $"{checkBox3.Text}");
                    }
                    else if (checkBox4.Checked)
                    {
                        device = device.Insert(device.Length, $"{checkBox4.Text}");
                    }
                    else if (checkBox5.Checked)
                    {
                        device = device.Insert(device.Length, $"{textBox4.Text}");
                    }
                    MessageBox.Show($"{comboBox1.SelectedItem} {textBox1.Text} \n {textBox2.Text} \n {textBox3.Text} \n {comboBox2.SelectedItem} {comboBox3.SelectedItem} \n {device}","借用資訊");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}