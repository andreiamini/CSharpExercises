using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise14CC
{
    public partial class frmExerciseC : Form
    {
        public frmExerciseC()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            String name = txtInput.Text;
            label1.Text = "Hello " + name + ", nice to meet you";
        }
    }
}
