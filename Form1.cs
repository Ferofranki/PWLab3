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
using System.Text.Json;

namespace PWLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Imię");
            dataTable.Columns.Add("Nazwisko");
            dataTable.Columns.Add("Wiek");
            dataTable.Columns.Add("Stanowisko");

            dataGridView1.DataSource = dataTable;
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (NowyPracownik nowyPracownik = new NowyPracownik())
            {
                if(nowyPracownik.ShowDialog() == DialogResult.OK)
                {
                    int newId = 1;

                    if (!(dataGridView1.DataSource is System.Data.DataTable dataTable))
                    {
                        InitializeDataGridView();
                        dataTable = (DataTable)dataGridView1.DataSource;
                    }
                    if (dataTable.Rows.Count > 1)
                    {
                        int maxId = 0;
                        foreach (System.Data.DataRow row in dataTable.Rows)
                        {
                            if (row["ID"] != DBNull.Value && int.TryParse(row["ID"].ToString(), out int obecneId))
                            {
                                if (obecneId > maxId)
                                {
                                    maxId = obecneId;
                                }
                            }
                        }
                        newId = maxId + 1;
                    }
                        dataTable.Rows.Add(newId, nowyPracownik.Imie, nowyPracownik.Nazwisko, nowyPracownik.Wiek, nowyPracownik.Stanowisko);
                    }
                    
                }
            }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnZapiszJSON_Click(object sender, EventArgs e)
        {
            List<Osoba> listaOsob = new List<Osoba>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    Osoba osoba = new Osoba(
                        Convert.ToInt32(row.Cells["ID"].Value),
                        row.Cells["Imię"].Value.ToString(),
                        row.Cells["Nazwisko"].Value.ToString(),
                        Convert.ToInt32(row.Cells["Wiek"].Value),
                        row.Cells["Stanowisko"].Value.ToString()
                    );
                    listaOsob.Add(osoba);
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki JSON (*.json)|*.json";
            saveFileDialog.Title = "Wybierz lokalizację zapisu pliku JSON";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = JsonSerializer.Serialize(listaOsob, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(saveFileDialog.FileName, jsonString);

            }
        }
    }
}
