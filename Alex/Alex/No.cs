using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alex
{
    public partial class No : Form
    {
        public No()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Magic_bear().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Mnt_wolf().ShowDialog();
        }
    }
}
