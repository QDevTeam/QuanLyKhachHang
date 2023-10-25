using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau1
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }
        public void UpdateProgress(int percent)
        {
            progressBar1.Value = percent;
        }
    }
}
