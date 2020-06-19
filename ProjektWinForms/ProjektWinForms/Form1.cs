using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            EmailTB.MaxLength = 30;
        }

        private void NazwiskoTB_TextChanged(object sender, EventArgs e)
        {
            ImieTB.MaxLength = 30;
        }

        public void Insert(SqlConnection connection, int id, string email, string numer, string imie)
        {
            var query = "INSERT INTO Użytkownik(ID_użytkownika, Email, Telefon, Imię)" +
                "VALUES (@id, @email, @numer, @imie)";
            var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@numer", numer);
            command.Parameters.AddWithValue("@imie", imie);

            
            MessageBox.Show($"Zapisano użytkownika {EmailTB.Text} do DB", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void PotwierdźBTN_Click(object sender, EventArgs e)
        {
            if (EmailTB.TextLength <= 0)
            {
                MessageBox.Show($"Podaj swoje imię!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                while (true)
                {
                    int i = 1;
                    var connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Projekt; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    Insert(connection, i, EmailTB.Text, NumerTB.Text, ImieTB.Text);
                    connection.Close();

                    i++;
                    break;
                }
                
                
            }
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

        private void WyczyśćBTN_Click(object sender, EventArgs e)
        {
            EmailTB.Clear();
            ImieTB.Clear();
            NumerTB.Clear();
            WyborTrasyCB.SelectedIndex = -1;
            RodzajKarnetuCB.SelectedIndex = -1;
            CzasowyCB.SelectedIndex = -1;
            ZjazdowyCB.SelectedIndex = -1;
        }

        private void CzasowyCB_MouseEnter(object sender, EventArgs e)
        {
            CzasowyTIP.SetToolTip(CzasowyCB, "Ten czas podawany jest w minutach.");
        }
    }
}
