using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generatorpassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int passwordLength = 12;
            string passwordChars = "abcdefghijklmnopqrstuvxyzABCDEFGHIJKLMNOPQSTUVWXYZ0123456789";

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                int index = random.Next(passwordChars.Length);
                password.Append(passwordChars[index]);
                textBox1.Text = password.ToString();
            }
            listBox1.Items.Add(textBox1.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                string selectedText = listBox1.SelectedItems[0].ToString();
                Clipboard.SetText(selectedText);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
