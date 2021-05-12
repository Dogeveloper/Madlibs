using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs
{
    public partial class MadLibEditor : Form
    {
        public MadLibEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager.Get().OpenMadLib(MadLibBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            Stream s;

            sfd.Filter = "Mad Lib Files|*.madlib";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, MadLibBox.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = Manager.Get().GetFromFile();
            if(text != "")
            {
                MadLibBox.Text = text;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
