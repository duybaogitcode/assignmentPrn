using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class progressBarForm : Form
    {
        public progressBarForm()
        {

            InitializeComponent();
            loading();
        }

        private void loading()
        {
            progressBar1.Maximum = 10000;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Blocks;

            for (int i = 0; i < 10000; i++)
            {
                progressBar1.Value = i;
            }
        }
    }
}
