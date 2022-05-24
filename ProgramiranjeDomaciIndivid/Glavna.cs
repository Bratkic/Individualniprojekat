using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramiranjeDomaciIndivid
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Album albumko = new Album();
            albumko.Show();
            this.Hide();
        }
    }
}
