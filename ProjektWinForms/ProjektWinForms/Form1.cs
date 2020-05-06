using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektWinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ImieTB_TextChanged(object sender, EventArgs e)
        {
            ImieTB.MaxLength = 13;


        }

        private void PodajNazwisko_Click(object sender, EventArgs e)
        {

        }

        private void NazwiskoTB_TextChanged(object sender, EventArgs e)
        {
            NazwiskoTB.MaxLength = 30;


        }



        private void PotwierdźBTN_Click(object sender, EventArgs e)
        {
            
            if (ImieTB.TextLength <= 0)
            {
                MessageBox.Show("Podaj swoje imię!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
            }
            if (NazwiskoTB.TextLength <= 0)
            {
                MessageBox.Show("Podaj swoje nazwisko!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
            }
            if (WyborTrasyCB.SelectedIndex != -1)
            {
                
            }
            else
            {
                MessageBox.Show("Wybierz trasę!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (RodzajKarnetuCB.SelectedIndex != -1)
            {
                
            }
            else
            {
                MessageBox.Show("Wybierz rodzaj karnetu!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            WyczyśćBTN.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WyborTrasyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RodzajKarnetuCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RodzajKarnetuCB.SelectedIndex == 0)
            {
                ZjazdowyLB.Visible = false;
                ZjazdowyCB.Visible = false;
                CzasowyLB.Visible = true;
                CzasowyCB.Visible = true;
            }
            if (RodzajKarnetuCB.SelectedIndex == 1)
            {
                CzasowyLB.Visible = false;
                CzasowyCB.Visible = false;
                ZjazdowyLB.Visible = true;
                ZjazdowyCB.Visible = true;
            }
        }

        private void ZjazdowyLB_Click(object sender, EventArgs e)
        {
            
        }

        private void CzasowyLB_Click(object sender, EventArgs e)
        {

        }

        private void ZjazdowyCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CzasowyCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PodajWiekDTP_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void WyczyśćBTN_Click(object sender, EventArgs e)
        {
            ImieTB.Clear();
            NazwiskoTB.Clear();
            WyborTrasyCB.SelectedIndex = -1;
            RodzajKarnetuCB.SelectedIndex = -1;
            CzasowyCB.SelectedIndex = -1;
            ZjazdowyCB.SelectedIndex = -1;
            
            
        }
    }
}
