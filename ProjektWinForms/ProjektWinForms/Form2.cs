using Dapper;
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
    public partial class Form2 : Form
    {
        private Form1 Form1;

        public Form2(Form1 forma)
        {
            InitializeComponent();
            Form1 = forma;
        }
        public void Select(IDbConnection connection)
        {

            {
                var users = connection.Query<Użytkownik>("SELECT * FROM Użytkownik");
                UżytkownikLV.Items.Clear();
                foreach (var item in users)
                {
                    var row = new string[]
                    {
                        item.ID_użytkownika.ToString(),
                        item.Email,
                        item.Telefon,
                        item.Imię
                    };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = users;
                    UżytkownikLV.Items.Add(lvi);
                }
            }
        }

        private void UżytkownikBTN_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Projekt; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                Select(connection);
            }
        }

        private void WróćBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UżytkownikLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Użytkownik)UżytkownikLV.SelectedItems[0].Tag;

                if (selectedItem != null)
                {
                    MessageBox.Show(selectedItem.ToString(), "Szczegóły użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
