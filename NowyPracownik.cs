using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWLab3
{
    public partial class NowyPracownik : Form
    {
        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public int Wiek { get; private set; }
        public string Stanowisko { get; private set; }
        public NowyPracownik()
        {
            InitializeComponent();
            cbStanowisko.Items.AddRange(new string[] { "Programista", "Tester", "Kierownik" });
            if (cbStanowisko.Items.Count > 0)
            {
                cbStanowisko.SelectedIndex = 0;
            }
        }

        private void btnZatwierdz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbSurname.Text) ||
                !int.TryParse(tbAge.Text, out int wpisanyWiek))
            {
                MessageBox.Show("Prosze wypelnic wszystkie pola", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Imie = tbName.Text;
            Nazwisko = tbSurname.Text;
            Wiek = wpisanyWiek;
            Stanowisko = cbStanowisko.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
