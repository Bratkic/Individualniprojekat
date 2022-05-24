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
    public partial class Login_Stvarno : Form
    {
        public Login_Stvarno()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login loginko = new Login();
            loginko.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klasa m = new Klasa();
            int rezultat;
            rezultat = m.Provera_Korisnika(emailtxt.Text, passtxt.Text);

            if (rezultat == 0)
            {
                Glavna glavko = new Glavna();
                glavko.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Neispravni podaci!");
                emailtxt.Text = "";
                passtxt.Text = "";
                
            }
        }
    }
}
