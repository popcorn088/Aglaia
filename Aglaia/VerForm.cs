using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aglaia
{
    public partial class VerForm : Form
    {
        public VerForm()
        {
            InitializeComponent();
        }

        private void Version_Load(object sender, EventArgs e)
        {

        }

        private void llabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llabel.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:popcorn088@gmail.com");
        }
    }
}
