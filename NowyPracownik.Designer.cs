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
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbStanowisko = new System.Windows.Forms.Label();
            this.btnZatwierdz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(13, 75);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(121, 22);
            this.tbAge.TabIndex = 10;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(13, 44);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(121, 22);
            this.tbSurname.TabIndex = 11;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(122, 22);
            this.tbName.TabIndex = 12;
            // 
            // NowyPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 205);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZatwierdz);
            this.Controls.Add(this.lbStanowisko);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbStanowisko);
            this.Name = "NowyPracownik";
            this.Text = "NowyPracownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbStanowisko;
        private System.Windows.Forms.Button btnZatwierdz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
    }
}