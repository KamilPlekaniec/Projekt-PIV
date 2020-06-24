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
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ProjektWinForms
{
    public partial class Form1 : Form
    {
               
        public Form1()
        {
            InitializeComponent();
            
        }
        private void WywolajForme()
        {
            var Form2 = new Form2(this);
            Form2.Show();
        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {
            EmailIsValid(EmailTB.Text);
        }

        private void ImieTB_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(ImieTB.Text, @"^[a-zA-Z]*$")) 
            {
                ImieTB.Text = string.Empty;
            }
        }

        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //bool IsValidEmail(string email)
        //{
        //    try
        //    {
        //        var addr = new MailAddress(email);
        //        return addr.Address == email;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        private void PotwierdźBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(EmailTB.Text)
                    || string.IsNullOrEmpty(NumerTB.Text)
                    || string.IsNullOrEmpty(ImieTB.Text))
                {
                    MessageBox.Show("Wszystkie pola muszą być wypełnione! Trasa oraz karnety muszą być wybrane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var conectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    SqlConnection connection = new SqlConnection(conectionString);

                    connection.Open();

                    string querry = "INSERT INTO Użytkownik(Email, Telefon, Imię)"
                    + "VALUES (@Email, @Telefon, @Imię)";
                    SqlCommand command = new SqlCommand(querry, connection);
                    command.Parameters.AddWithValue("Email", EmailTB.Text);
                    command.Parameters.AddWithValue("Telefon", NumerTB.Text);
                    command.Parameters.AddWithValue("Imię", ImieTB.Text);
                    int result = command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show($"Dodano {result} wiersz do DB!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WywolajForme();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś poszło nie tak.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
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

        private void NumerTB_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(NumerTB.Text, "^[0-9]*$"))
            {
                NumerTB.Text = string.Empty;
            }
        }
    }
}
