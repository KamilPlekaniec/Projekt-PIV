namespace ProjektWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NazwaOsrodka = new System.Windows.Forms.Label();
            this.PodajImie = new System.Windows.Forms.Label();
            this.ImieTB = new System.Windows.Forms.TextBox();
            this.PodajNazwisko = new System.Windows.Forms.Label();
            this.NazwiskoTB = new System.Windows.Forms.TextBox();
            this.PodajWiek = new System.Windows.Forms.Label();
            this.WybierzTrase = new System.Windows.Forms.Label();
            this.PotwierdźBTN = new System.Windows.Forms.Button();
            this.WyborTrasyCB = new System.Windows.Forms.ComboBox();
            this.WyborKarnetuLB = new System.Windows.Forms.Label();
            this.RodzajKarnetuCB = new System.Windows.Forms.ComboBox();
            this.PodajWiekDTP = new System.Windows.Forms.DateTimePicker();
            this.CzasowyCB = new System.Windows.Forms.ComboBox();
            this.CzasowyLB = new System.Windows.Forms.Label();
            this.ZjazdowyLB = new System.Windows.Forms.Label();
            this.ZjazdowyCB = new System.Windows.Forms.ComboBox();
            this.WyczyśćBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NazwaOsrodka
            // 
            this.NazwaOsrodka.AutoSize = true;
            this.NazwaOsrodka.Location = new System.Drawing.Point(208, 20);
            this.NazwaOsrodka.Name = "NazwaOsrodka";
            this.NazwaOsrodka.Size = new System.Drawing.Size(230, 20);
            this.NazwaOsrodka.TabIndex = 0;
            this.NazwaOsrodka.Text = "Ośrodek narciarski biała krecha";
            this.NazwaOsrodka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PodajImie
            // 
            this.PodajImie.AutoSize = true;
            this.PodajImie.Location = new System.Drawing.Point(45, 74);
            this.PodajImie.Name = "PodajImie";
            this.PodajImie.Size = new System.Drawing.Size(129, 20);
            this.PodajImie.TabIndex = 1;
            this.PodajImie.Text = "Podaj swoje imię:";
            this.PodajImie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImieTB
            // 
            this.ImieTB.Location = new System.Drawing.Point(258, 74);
            this.ImieTB.MaxLength = 13;
            this.ImieTB.Name = "ImieTB";
            this.ImieTB.Size = new System.Drawing.Size(127, 26);
            this.ImieTB.TabIndex = 2;
            this.ImieTB.TextChanged += new System.EventHandler(this.ImieTB_TextChanged);
            // 
            // PodajNazwisko
            // 
            this.PodajNazwisko.AutoSize = true;
            this.PodajNazwisko.Location = new System.Drawing.Point(45, 116);
            this.PodajNazwisko.Name = "PodajNazwisko";
            this.PodajNazwisko.Size = new System.Drawing.Size(166, 20);
            this.PodajNazwisko.TabIndex = 3;
            this.PodajNazwisko.Text = "Podaj swoje nazwisko:";
            this.PodajNazwisko.Click += new System.EventHandler(this.PodajNazwisko_Click);
            // 
            // NazwiskoTB
            // 
            this.NazwiskoTB.Location = new System.Drawing.Point(258, 116);
            this.NazwiskoTB.Name = "NazwiskoTB";
            this.NazwiskoTB.Size = new System.Drawing.Size(127, 26);
            this.NazwiskoTB.TabIndex = 3;
            this.NazwiskoTB.TextChanged += new System.EventHandler(this.NazwiskoTB_TextChanged);
            // 
            // PodajWiek
            // 
            this.PodajWiek.AutoSize = true;
            this.PodajWiek.Location = new System.Drawing.Point(45, 157);
            this.PodajWiek.Name = "PodajWiek";
            this.PodajWiek.Size = new System.Drawing.Size(207, 20);
            this.PodajWiek.TabIndex = 5;
            this.PodajWiek.Text = "Podaj swoją datę urodzenia:";
            // 
            // WybierzTrase
            // 
            this.WybierzTrase.AutoSize = true;
            this.WybierzTrase.Location = new System.Drawing.Point(45, 195);
            this.WybierzTrase.Name = "WybierzTrase";
            this.WybierzTrase.Size = new System.Drawing.Size(109, 20);
            this.WybierzTrase.TabIndex = 7;
            this.WybierzTrase.Text = "Wybierz trasę:";
            // 
            // PotwierdźBTN
            // 
            this.PotwierdźBTN.Location = new System.Drawing.Point(542, 335);
            this.PotwierdźBTN.Name = "PotwierdźBTN";
            this.PotwierdźBTN.Size = new System.Drawing.Size(112, 40);
            this.PotwierdźBTN.TabIndex = 8;
            this.PotwierdźBTN.Text = "Potwierdź";
            this.PotwierdźBTN.UseVisualStyleBackColor = true;
            this.PotwierdźBTN.Click += new System.EventHandler(this.PotwierdźBTN_Click);
            // 
            // WyborTrasyCB
            // 
            this.WyborTrasyCB.FormattingEnabled = true;
            this.WyborTrasyCB.Items.AddRange(new object[] {
            "Czarna",
            "Czerwona",
            "Niebieska",
            "Zielona"});
            this.WyborTrasyCB.Location = new System.Drawing.Point(258, 195);
            this.WyborTrasyCB.Name = "WyborTrasyCB";
            this.WyborTrasyCB.Size = new System.Drawing.Size(127, 28);
            this.WyborTrasyCB.TabIndex = 5;
            this.WyborTrasyCB.SelectedIndexChanged += new System.EventHandler(this.WyborTrasyCB_SelectedIndexChanged);
            // 
            // WyborKarnetuLB
            // 
            this.WyborKarnetuLB.AutoSize = true;
            this.WyborKarnetuLB.Location = new System.Drawing.Point(45, 232);
            this.WyborKarnetuLB.Name = "WyborKarnetuLB";
            this.WyborKarnetuLB.Size = new System.Drawing.Size(174, 20);
            this.WyborKarnetuLB.TabIndex = 11;
            this.WyborKarnetuLB.Text = "Wybierz rodzaj karnetu:";
            // 
            // RodzajKarnetuCB
            // 
            this.RodzajKarnetuCB.FormattingEnabled = true;
            this.RodzajKarnetuCB.Items.AddRange(new object[] {
            "Czasowy",
            "Zjazdowy"});
            this.RodzajKarnetuCB.Location = new System.Drawing.Point(258, 232);
            this.RodzajKarnetuCB.Name = "RodzajKarnetuCB";
            this.RodzajKarnetuCB.Size = new System.Drawing.Size(127, 28);
            this.RodzajKarnetuCB.TabIndex = 6;
            this.RodzajKarnetuCB.SelectedIndexChanged += new System.EventHandler(this.RodzajKarnetuCB_SelectedIndexChanged);
            // 
            // PodajWiekDTP
            // 
            this.PodajWiekDTP.Location = new System.Drawing.Point(258, 152);
            this.PodajWiekDTP.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.PodajWiekDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PodajWiekDTP.Name = "PodajWiekDTP";
            this.PodajWiekDTP.Size = new System.Drawing.Size(127, 26);
            this.PodajWiekDTP.TabIndex = 4;
            this.PodajWiekDTP.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PodajWiekDTP.ValueChanged += new System.EventHandler(this.PodajWiekDTP_ValueChanged);
            // 
            // CzasowyCB
            // 
            this.CzasowyCB.FormattingEnabled = true;
            this.CzasowyCB.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "150",
            "180"});
            this.CzasowyCB.Location = new System.Drawing.Point(258, 274);
            this.CzasowyCB.Name = "CzasowyCB";
            this.CzasowyCB.Size = new System.Drawing.Size(127, 28);
            this.CzasowyCB.TabIndex = 16;
            this.CzasowyCB.Visible = false;
            this.CzasowyCB.SelectedIndexChanged += new System.EventHandler(this.CzasowyCB_SelectedIndexChanged);
            // 
            // CzasowyLB
            // 
            this.CzasowyLB.AutoSize = true;
            this.CzasowyLB.Location = new System.Drawing.Point(45, 274);
            this.CzasowyLB.Name = "CzasowyLB";
            this.CzasowyLB.Size = new System.Drawing.Size(164, 20);
            this.CzasowyLB.TabIndex = 17;
            this.CzasowyLB.Text = "Wybierz czas karnetu:";
            this.CzasowyLB.Visible = false;
            this.CzasowyLB.Click += new System.EventHandler(this.CzasowyLB_Click);
            // 
            // ZjazdowyLB
            // 
            this.ZjazdowyLB.AutoSize = true;
            this.ZjazdowyLB.Location = new System.Drawing.Point(45, 274);
            this.ZjazdowyLB.Name = "ZjazdowyLB";
            this.ZjazdowyLB.Size = new System.Drawing.Size(165, 20);
            this.ZjazdowyLB.TabIndex = 18;
            this.ZjazdowyLB.Text = "Wybierz ilość zjazdów:";
            this.ZjazdowyLB.Visible = false;
            this.ZjazdowyLB.Click += new System.EventHandler(this.ZjazdowyLB_Click);
            // 
            // ZjazdowyCB
            // 
            this.ZjazdowyCB.FormattingEnabled = true;
            this.ZjazdowyCB.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.ZjazdowyCB.Location = new System.Drawing.Point(258, 274);
            this.ZjazdowyCB.Name = "ZjazdowyCB";
            this.ZjazdowyCB.Size = new System.Drawing.Size(127, 28);
            this.ZjazdowyCB.TabIndex = 7;
            this.ZjazdowyCB.Visible = false;
            this.ZjazdowyCB.SelectedIndexChanged += new System.EventHandler(this.ZjazdowyCB_SelectedIndexChanged);
            // 
            // WyczyśćBTN
            // 
            this.WyczyśćBTN.Location = new System.Drawing.Point(424, 335);
            this.WyczyśćBTN.Name = "WyczyśćBTN";
            this.WyczyśćBTN.Size = new System.Drawing.Size(112, 40);
            this.WyczyśćBTN.TabIndex = 20;
            this.WyczyśćBTN.Text = "Wyczyść";
            this.WyczyśćBTN.UseVisualStyleBackColor = true;
            this.WyczyśćBTN.Visible = false;
            this.WyczyśćBTN.Click += new System.EventHandler(this.WyczyśćBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 387);
            this.Controls.Add(this.WyczyśćBTN);
            this.Controls.Add(this.ZjazdowyCB);
            this.Controls.Add(this.ZjazdowyLB);
            this.Controls.Add(this.CzasowyLB);
            this.Controls.Add(this.CzasowyCB);
            this.Controls.Add(this.PodajWiekDTP);
            this.Controls.Add(this.RodzajKarnetuCB);
            this.Controls.Add(this.WyborKarnetuLB);
            this.Controls.Add(this.WyborTrasyCB);
            this.Controls.Add(this.PotwierdźBTN);
            this.Controls.Add(this.WybierzTrase);
            this.Controls.Add(this.PodajWiek);
            this.Controls.Add(this.NazwiskoTB);
            this.Controls.Add(this.PodajNazwisko);
            this.Controls.Add(this.ImieTB);
            this.Controls.Add(this.PodajImie);
            this.Controls.Add(this.NazwaOsrodka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt WinForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NazwaOsrodka;
        private System.Windows.Forms.Label PodajImie;
        private System.Windows.Forms.TextBox ImieTB;
        private System.Windows.Forms.Label PodajNazwisko;
        private System.Windows.Forms.TextBox NazwiskoTB;
        private System.Windows.Forms.Label PodajWiek;
        private System.Windows.Forms.Label WybierzTrase;
        private System.Windows.Forms.Button PotwierdźBTN;
        private System.Windows.Forms.Label WyborKarnetuLB;
        private System.Windows.Forms.ComboBox RodzajKarnetuCB;
        private System.Windows.Forms.DateTimePicker PodajWiekDTP;
        private System.Windows.Forms.ComboBox CzasowyCB;
        private System.Windows.Forms.Label CzasowyLB;
        private System.Windows.Forms.Label ZjazdowyLB;
        private System.Windows.Forms.ComboBox ZjazdowyCB;
        private System.Windows.Forms.Button WyczyśćBTN;
        private System.Windows.Forms.ComboBox WyborTrasyCB;
    }
}

