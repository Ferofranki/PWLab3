namespace PWLab3
{
    partial class NowyPracownik
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbSurname = new System.Windows.Forms.ComboBox();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbStanowisko = new System.Windows.Forms.Label();
            this.btnZatwierdz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(13, 13);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 24);
            this.cbName.TabIndex = 0;
            // 
            // cbSurname
            // 
            this.cbSurname.FormattingEnabled = true;
            this.cbSurname.Location = new System.Drawing.Point(13, 44);
            this.cbSurname.Name = "cbSurname";
            this.cbSurname.Size = new System.Drawing.Size(121, 24);
            this.cbSurname.TabIndex = 1;
            // 
            // cbAge
            // 
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Location = new System.Drawing.Point(13, 75);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(121, 24);
            this.cbAge.TabIndex = 2;
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(13, 106);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(121, 24);
            this.cbStanowisko.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(157, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(32, 16);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Imie";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(157, 44);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(65, 16);
            this.lbSurname.TabIndex = 5;
            this.lbSurname.Text = "Nazwisko";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(160, 75);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(38, 16);
            this.lbAge.TabIndex = 6;
            this.lbAge.Text = "Wiek";
            // 
            // lbStanowisko
            // 
            this.lbStanowisko.AutoSize = true;
            this.lbStanowisko.Location = new System.Drawing.Point(160, 106);
            this.lbStanowisko.Name = "lbStanowisko";
            this.lbStanowisko.Size = new System.Drawing.Size(76, 16);
            this.lbStanowisko.TabIndex = 7;
            this.lbStanowisko.Text = "Stanowisko";
            // 
            // btnZatwierdz
            // 
            this.btnZatwierdz.Location = new System.Drawing.Point(12, 153);
            this.btnZatwierdz.Name = "btnZatwierdz";
            this.btnZatwierdz.Size = new System.Drawing.Size(95, 40);
            this.btnZatwierdz.TabIndex = 8;
            this.btnZatwierdz.Text = "Zatwierdz";
            this.btnZatwierdz.UseVisualStyleBackColor = true;
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(134, 153);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(102, 40);
            this.btnAnuluj.TabIndex = 9;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // NowyPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 205);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZatwierdz);
            this.Controls.Add(this.lbStanowisko);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.cbAge);
            this.Controls.Add(this.cbSurname);
            this.Controls.Add(this.cbName);
            this.Name = "NowyPracownik";
            this.Text = "NowyPracownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbSurname;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbStanowisko;
        private System.Windows.Forms.Button btnZatwierdz;
        private System.Windows.Forms.Button btnAnuluj;
    }
}