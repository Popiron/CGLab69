
using CGLab69.Lab6;
using CGLab69.Lab7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab69
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void lab6Button_Click(object sender, EventArgs e)
        {
            Lab6Form form = new Lab6Form();
            form.ShowDialog();
        }

        private void lab7Button_Click(object sender, EventArgs e)
        {
            Lab7Form form = new Lab7Form();
            form.ShowDialog();
        }
    }
}
