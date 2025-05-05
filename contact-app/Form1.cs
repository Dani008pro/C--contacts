using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_app
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

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contactFPath = "C:/Users/pc/Desktop/contacts.txt";

            string allData = File.ReadAllText(contactFPath, Encoding.UTF8);

            string requireWord= searchbar.Text;

            var lines = allData.Split('\n');

            var thatLine = "not found";
            foreach (var line in lines)
            {
                if (line.Contains(requireWord))
                    thatLine = line;
            }

            MessageBox.Show(thatLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contactFPath = "C:/Users/pc/Desktop/contacts.txt";
            if( name.Text != "" && lastname.Text != "" && phone.Text != "" && address.Text != "")
            {
                string fullinformation = $"{name.Text}\t|||\t{lastname.Text}\t|||\t{phone.Text}\t|||\t{address.Text} \n";
                File.AppendAllText(contactFPath,fullinformation);
            }
            else
            {
                MessageBox.Show("you have to fill all inputs");
            }

            string data = File.ReadAllText(contactFPath);

            richTextBox2.Text = data;

            //MessageBox.Show(data);
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
