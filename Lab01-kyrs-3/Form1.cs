using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_kyrs_3
{
    public partial class Form1 : Form
    {
        int count = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, str, Password, pas = "";
            Password = textBox2.Text;
            login = textBox1.Text;
            if (login == "Katya")
            {
                label3.BackColor = Color.Green;
                if (Password == "1111")
                {
                    str = "Привіт " + login;
                    label4.BackColor = Color.Green;
                    MessageBox.Show(str, "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count--;
                    pas = "Спробуйте ще раз. " +
                        "У вас залишилося " + count.ToString() + " спроби";
                    if (count == 0)
                    {
                        this.Enabled = false;
                    }
                    label3.BackColor = Color.Red;
                    MessageBox.Show(pas, "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (login != "Katya")
            {
                str = "Ви хто?";
                label3.BackColor = Color.Red;
                label4.BackColor = Color.Red;
                MessageBox.Show(str, "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
    }
