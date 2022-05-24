using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProgramiranjeDomaciIndivid
{
    public partial class Album : Form
    {
        public Album()
        {
            InitializeComponent();
        }

        private void Album_Load(object sender, EventArgs e)
        {
            Grid_Populate();
            Godine_Populate();
            Izdavac_Populate();
        }


        protected void Grid_Populate()
        {
            StringBuilder naredba = new StringBuilder("Select Album.naziv as Naziv, Godina_Izdanja.naziv as Godina_izdanja, Izdavac.naziv as Izdavac from Album");
            naredba.Append(" join Izdavac on Album.izdavac_id = Izdavac.id join Godina_Izdanja on Album.godina_izdanja_id=Godina_Izdanja.id");

            SqlConnection conn = new SqlConnection();
            string webConfig = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            conn.ConnectionString = webConfig;
            //textBox2.Text = naredba.ToString();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), conn);
                DataTable grid = new DataTable();
                adapter.Fill(grid);
                dataGridView1.DataSource = grid;
                

            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.ToString());

            }



        }
        protected void Godine_Populate()
        {
            StringBuilder naredba = new StringBuilder("Select id,naziv from Godina_Izdanja");

            //textBox2.Text = naredba.ToString();
            SqlConnection conn = new SqlConnection();
            string webConfig = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            conn.ConnectionString = webConfig;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), conn);
                DataTable god = new DataTable();
                adapter.Fill(god);
                Godine.DataSource = god;
                Godine.ValueMember = "id";
                Godine.DisplayMember = "naziv";
                

            }
            catch (Exception Greska)
            {

                MessageBox.Show(Greska.ToString());
            }
        }
        protected void Izdavac_Populate()
        {
            StringBuilder naredba = new StringBuilder("Select id,naziv from Izdavac");
            SqlConnection conn = new SqlConnection();
            string webConfig = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            conn.ConnectionString = webConfig;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), conn);
                DataTable god = new DataTable();
                adapter.Fill(god);
                Izdavaci.DataSource = god;
                Izdavaci.ValueMember = "id";
                Izdavaci.DisplayMember = "naziv";
                


            }
            catch (Exception Greska)
            {

                MessageBox.Show(Greska.ToString());
            }
        }
        protected void Dodaj_Album_Click(object sender, EventArgs e)
        {
            




        }

        private void Dodaj_Album_Click_1(object sender, EventArgs e)
        {
            Klasa m = new Klasa();
            int rezultat;
            MessageBox.Show(Godine.SelectedValue.ToString());
            MessageBox.Show(Izdavaci.SelectedValue.ToString());
            try
            {


                rezultat = m.Album_Insert(nazivAlbuma.Text, Convert.ToInt32(Godine.SelectedValue), Convert.ToInt32(Izdavaci.SelectedValue));
                if (rezultat == 0)
                {

                    Grid_Populate();

                }
                else
                {
                    MessageBox.Show("Greska u unosu!");
                }



            }
            catch (Exception Greska)
            {

                MessageBox.Show(Greska.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klasa m = new Klasa();
            int rezultat;
            rezultat = m.Godina_Izdanja_Insert(godtxt.Text);


            Godine_Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Klasa m = new Klasa();
            int rezultat;
            rezultat = m.Izdavac_Insert(izdavactxt.Text);

            Izdavac_Populate();
        }
    }
}
