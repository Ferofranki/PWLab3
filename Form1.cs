using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
           
            string csvContent = "ID,Imię,Nazwisko,Wiek,Stanowisko" + Environment.NewLine; 

    
    foreach (DataGridViewRow row in dataGridView.Rows) 
    {
                
                if (!row.IsNewRow) 
        {
                   
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value)) + Environment.NewLine; 
        }
            }
           
            File.WriteAllText(filePath, csvContent); 
}

        private void btnZapisz_Click(object sender, EventArgs e)
        {       
    SaveFileDialog saveFileDialog1 = new SaveFileDialog(); 
    saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*"; 
    saveFileDialog1.Title = "Wybierz lokalizację zapisu pliku CSV"; 
    saveFileDialog1.ShowDialog(); 

    if (saveFileDialog1.FileName != "") 
    {
               
                ExportToCSV(dataGridView1, saveFileDialog1.FileName); 
    }
        }

        private void LoadCSVToDataGridView(string filePath)
        {
            // Sprawdź, czy plik istnieje
            if (!File.Exists(filePath)) 
    {
                MessageBox.Show("Plik CSV nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        return; 
    }

            // Odczytaj zawartość pliku CSV
            string[] lines = File.ReadAllLines(filePath); 

    // Tworzenie tabeli danych
    DataTable dataTable = new DataTable(); 

    // Dodanie kolumn na podstawie nagłówka
    string[] headers = lines[0].Split(','); 
    foreach (string header in headers) 
    {
                dataTable.Columns.Add(header); 
    }

            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++) 
    {
                string[] values = lines[i].Split(','); 
        dataTable.Rows.Add(values); 
    }

            // Przypisanie tabeli danych do DataGridView
            dataGridView1.DataSource = dataTable; 
}

        private void btnOdczyt_Click(object sender, EventArgs e)
        {
            // Wyświetlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); 
    openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*"; 
    openFileDialog1.Title = "Wybierz plik CSV do wczytania"; 
    openFileDialog1.ShowDialog(); 

    // Jeśli użytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
    if (openFileDialog1.FileName != "") 
    {
                // Wywołanie funkcji wczytującej dane z pliku CSV
                LoadCSVToDataGridView(openFileDialog1.FileName); 
    }
        }
    }
}
