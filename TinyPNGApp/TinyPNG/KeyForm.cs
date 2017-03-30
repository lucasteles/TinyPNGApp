using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinifyAPI;

namespace TinyPNG
{
    public partial class KeyForm : Form
    {
        public KeyForm()
        {
            InitializeComponent();

            textBox1.Text = Tinify.Key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newKey = textBox1.Text;
            if (string.IsNullOrEmpty(newKey))
            {
                MessageBox.Show("invalid key");
                return;
            }

            Main.LoadKey(newKey);
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = "https://tinypng.com/developers";
            System.Diagnostics.Process.Start(url);
        }
    }
}
