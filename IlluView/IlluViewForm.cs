using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IESNA;

namespace IlluView
{
    public partial class IlluViewForm : Form
    {
        public IlluViewForm()
        {
            InitializeComponent();
        }

        LM63 _ies = null;

        public void SetIES(LM63 ies)
        {
            _ies = ies;
            _ies.data.PropertyChanged += DataChanged;
        }

        public void DataChanged(string prop)
        {

        }
    }
}
