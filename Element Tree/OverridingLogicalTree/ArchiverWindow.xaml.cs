using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;

namespace OverridingLogicalTree
{
    public partial class ArchiverWindow : Window
    {
        /*public ArchiverWindow()
        {
            InitializeComponent();
        }

        private void ArchiveButton_Click(object sender, RoutedEventArgs e)
        {
            // Vérification des champs
            if (dataTypeComboBox.SelectedItem == null || startDatePicker.SelectedDate == null || endDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs avant d'archiver.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Simuler l'archivage
            MessageBox.Show("Archivage réussi !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

            // Activer le bouton Exporter
            buttonExport.IsEnabled = true;
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Fichiers ZIP (*.zip)|*.zip|Tous les fichiers (*.*)|*.*",
                Title = "Enregistrer l'archive"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                MessageBox.Show($"Archive exportée vers : {saveFileDialog.FileName}", "Exportation réussie", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }*/
    }
}