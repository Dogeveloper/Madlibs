using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs
{
    public partial class MadLibOutput : Form
    {
        public MadLibOutput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputText.Text);
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
