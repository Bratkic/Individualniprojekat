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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login_Stvarno loginko = new Login_Stvarno();
            loginko.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klasa m = new Klasa();
            int rezultat;
            rezultat = m.Registracija(usernametxt.Text, imetxt.Text, prezimetxt.Text, emailtxt.Text, passtxt.Text);

            if (rezultat == 0)
            {
                if (usernametxt.Text!="" && imetxt.Text!="" && prezimetxt.Text!="" && emailtxt.Text!="" && passtxt.Text!="")
                {
                    Login_Stvarno loginko = new Login_Stvarno();
                    loginko.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Neispravni podaci!");
                    imetxt.Text = "";
                    prezimetxt.Text = "";
                    usernametxt.Text = "";

                    emailtxt.Text = "";
                    passtxt.Text = "";


                }


            }
            else
            {
                MessageBox.Show("Neispravni podaci!");
                imetxt.Text = "";
                prezimetxt.Text = "";
                usernametxt.Text = "";

                emailtxt.Text = "";
                passtxt.Text = "";
            }
            
        }
    }
}
