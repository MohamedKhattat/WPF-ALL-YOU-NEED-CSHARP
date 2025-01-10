using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OverridingLogicalTree
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Existing method to add a single logical element
        private void AddLogicalElement(object sender, RoutedEventArgs e)
        {
            var mybutton = new Button { Content = "Happy birthday! " + DateTime.Now.TimeOfDay };
            CustomElement.SetSingleChild(mybutton);
        }

        // New methods to enhance functionality

        // 1. Add multiple dynamic buttons based on a list of strings
        private void AddMultipleButtons(List<string> buttonContents)
        {
            foreach (var content in buttonContents)
            {
                var mybutton = CreateButton(content);
                CustomElement.SetSingleChild(mybutton); // Add buttons sequentially
                // Alternatively, update your panel to accept multiple children
            }
        }

        // 2. Fetch and display dynamic data from an external source (simulated or real)
        private async Task FetchAndDisplayDataAsync()
        {
            string fetchedMessage = await SimulateApiCallAsync();
            var mybutton = CreateButton($"Fetched: {fetchedMessage}");
            CustomElement.SetSingleChild(mybutton);
        }

        // 3. Clear the SingletonPanel
        private void ClearSingletonPanel()
        {
            CustomElement.RemoveLogicalChild(null); // Clear the child
            MessageBox.Show("SingletonPanel cleared!");
        }

        // 4. Add conditional logic to update UI based on user input
        private void AddButtonWithCondition(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Input cannot be empty!");
                return;
            }

            var mybutton = CreateButton(userInput);
            CustomElement.SetSingleChild(mybutton);
        }

        // 5. Method to toggle button visibility
        private void ToggleButtonVisibility(Button button)
        {
            button.Visibility = button.Visibility == Visibility.Visible
                ? Visibility.Collapsed
                : Visibility.Visible;
        }

        // Helper: Create a button with consistent styling
        private Button CreateButton(string content)
        {
            return new Button
            {
                Content = content,
                Width = 200,
                Height = 50,
                Margin = new Thickness(5)
            };
        }

        // Simulated API Call
        private async Task<string> SimulateApiCallAsync()
        {
            await Task.Delay(1000); // Simulating latency
            return "Simulated API Data";
        }


        private void OnAddMultipleButtons(object sender, RoutedEventArgs e)
        {
            AddMultipleButtons(new List<string> { "Dynamic 1", "Dynamic 2", "Dynamic 3" });
        }

        private async void OnFetchData(object sender, RoutedEventArgs e)
        {
            await FetchAndDisplayDataAsync();
        }

        private void OnClearPanel(object sender, RoutedEventArgs e)
        
        {
            ClearSingletonPanel();
        }


        private void OnAddConditionalButton(object sender, RoutedEventArgs e)
        {
            var myButton = new Button { Content = "Conditionally Added Button " + DateTime.Now.TimeOfDay };

            // Exemple d'une condition pour ajouter un bouton
            if (DateTime.Now.Second % 2 == 0)
            {
                CustomElement.SetSingleChild(myButton); // Si la condition est vraie, ajouter le bouton
            }
            else
            {
                MessageBox.Show("Condition non remplie pour ajouter le bouton");
            }
        }
    }


}
