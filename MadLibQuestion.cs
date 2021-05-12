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
    public partial class MadLibQuestion : Form
    {
        public MadLibQuestion()
        {
            InitializeComponent();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            IsButtonPressed = true;
        }
    }
}
