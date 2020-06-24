namespace ProjektWinForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.WróćBTN = new System.Windows.Forms.Button();
            this.UżytkownikBTN = new System.Windows.Forms.Button();
            this.UżytkownikLV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // WróćBTN
            // 
            this.WróćBTN.Location = new System.Drawing.Point(542, 314);
            this.WróćBTN.Name = "WróćBTN";
            this.WróćBTN.Size = new System.Drawing.Size(112, 61);
            this.WróćBTN.TabIndex = 21;
            this.WróćBTN.Text = "Wróć";
            this.WróćBTN.UseVisualStyleBackColor = true;
            this.WróćBTN.Click += new System.EventHandler(this.WróćBTN_Click);
            // 
            // UżytkownikBTN
            // 
            this.UżytkownikBTN.Location = new System.Drawing.Point(366, 314);
            this.UżytkownikBTN.Name = "UżytkownikBTN";
            this.UżytkownikBTN.Size = new System.Drawing.Size(170, 61);
            this.UżytkownikBTN.TabIndex = 22;
            this.UżytkownikBTN.Text = "Pokaż użytkowników";
            this.UżytkownikBTN.UseVisualStyleBackColor = true;
            this.UżytkownikBTN.Click += new System.EventHandler(this.UżytkownikBTN_Click);
            // 
            // UżytkownikLV
            // 
            this.UżytkownikLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chEmail,
            this.chTelefon,
            this.chImie});
            this.UżytkownikLV.FullRowSelect = true;
            this.UżytkownikLV.GridLines = true;
            this.UżytkownikLV.HideSelection = false;
            this.UżytkownikLV.Location = new System.Drawing.Point(16, 43);
            this.UżytkownikLV.Name = "UżytkownikLV";
            this.UżytkownikLV.Size = new System.Drawing.Size(642, 265);
            this.UżytkownikLV.TabIndex = 23;
            this.UżytkownikLV.UseCompatibleStateImageBehavior = false;
            this.UżytkownikLV.View = System.Windows.Forms.View.Details;
            this.UżytkownikLV.SelectedIndexChanged += new System.EventHandler(this.UżytkownikLV_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Lista użytkowników ośrodka narciarskiego w bazie:";
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 100;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.Width = 150;
            // 
            // chTelefon
            // 
            this.chTelefon.Text = "Numer telefonu";
            this.chTelefon.Width = 150;
            // 
            // chImie
            // 
            this.chImie.Text = "Imię użytkownika";
            this.chImie.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UżytkownikLV);
            this.Controls.Add(this.UżytkownikBTN);
            this.Controls.Add(this.WróćBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WróćBTN;
        private System.Windows.Forms.Button UżytkownikBTN;
        private System.Windows.Forms.ListView UżytkownikLV;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chTelefon;
        private System.Windows.Forms.ColumnHeader chImie;
        private System.Windows.Forms.Label label1;
    }
}