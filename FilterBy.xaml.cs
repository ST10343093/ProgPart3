﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProgPart3
{



    /*  Code attribution
        *  The follwing code was taken from StackOverFlow:
        *  Link : https://stackoverflow.com/questions/2552501/switch-statement-in-c-sharp
        *  switch (x)
        {
        case 1:
        //do something
        break;
        case 2..8:
        //do something else
        break;
        default:
        break;
        }


        The follwing code was taken from StackOverFlow:
        *  Link : https://stackoverflow.com/questions/14973642/how-using-try-catch-for-exception-handling-is-best-practice
        *  try
        {
        //do something
        }
        catch
        {
        //Do nothing
        } 
        *  
        *  The follwing code was taken from StackOverFlow:
        *  Link : The follwing code was taken from StackOverFlow: 
        *  https://stackoverflow.com/questions/14973642/how-using-try-catch-for-exception-handling-is-best-practice
        * 
        *   for (i=0 ; i<=10; i++)
        {
        ..
        ..
        }

        i=0;
        while(i<=10)
        {
        ..
        ..
        i++;
        }
        END
        */

    /// <summary>
    /// Interaction logic for FilterBy.xaml
    /// </summary>
    public partial class FilterBy : Window
    {//FilterWindow begin

        //Variable Declaration
        private int filter; //variable to hold the value of which catergory to filter by
        private ManageRecepie manageRecipe;
        private List<Recipe> recipes;
        private List<Recipe> filteredRecipes; // New member variable to store filtered recipes
        //List to hold the FoodGroup Values
        private List<FoodGroup> groups = new List<FoodGroup>();

        //constructor with parameter
        public FilterBy(ManageRecepie manageRecipe)
        {//constructor begin
            InitializeComponent();
            this.manageRecipe = manageRecipe;
            this.recipes = manageRecipe.Recipes;
            PopulateComboBox(); //method to populate food group comnobox with values from the enum
        }//constructor end

        //Method to populate foodgroup combobox with the enum values
        private void PopulateComboBox()
        {//PopulateComboBox begin
            groups = Enum.GetValues(typeof(FoodGroup)).Cast<FoodGroup>().ToList();
            foreach (var group in groups)
            {//foreach begin
                cmbGroup.Items.Add(group.ToString());
            }//foreach end
        }//PopulateComboBox end

        //MainMenuBtn Button click event to return to main menu
        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {//MainMenubtn begin
            //open AllRecipesWindow and close the current window
            var allRecipesWindow = new MainMenu(manageRecipe);
            allRecipesWindow.Show();
            this.Close();
        }//MainMenubtn end



        //Method to hide thecomponets to get user input for filter options
        private void HideAllFilterOptions()
        {//HideAllFilterOptions begin
            NameTxt.Visibility = Visibility.Hidden;
            cmbGroup.Visibility = Visibility.Hidden;
            CaloriesTxt.Visibility = Visibility.Hidden;
        }//HideAllFilterOptions end

        //Method to take in the ingrient name entered by user as a parameter and search through the recipes
        private void NameFilter(string ingredientName)
        {//Namefilter method begin
         //Using the lambda expression to find if the recipe contains the name of the ingredient user entered display the filtered list of recipes
            filteredRecipes = recipes
       .Where(r => r.Ingredients.Any(i => i.Name.IndexOf(ingredientName, StringComparison.OrdinalIgnoreCase) >= 0))
       .ToList();
            DisplayRecipes(filteredRecipes);
        }//Namefilter method end

        //Method to take in the food group selected by user as a parameter and search through the recipes
        private void GroupFilter(FoodGroup selectedGroup)
        {//GroupFilter begin
         //Using the lambda expression to find if the recipe contains the food group of the ingredient user entered display the filtered list of recipes
            filteredRecipes = recipes
      .Where(r => r.Ingredients.Any(i => i.FoodGroup == selectedGroup))
      .ToList();
            DisplayRecipes(filteredRecipes);
        }//GroupFilter end

        //Method to take in the ingrient name entered by user as a parameter and search through the recipes
        private void CalorieFilter(double maxCalories)
        {//CalorieFilter begin
         //Using the lambda expression to find if the recipe contains the max calories of the ingredient user entered display the filtered list of recipes
            filteredRecipes = recipes
               .Where(r => r.CalculateTotalCalories() <= maxCalories)
               .ToList();
            DisplayRecipes(filteredRecipes);
        }//CalorieFilter end

        //Method to display the filtered reiupe list 
        private void DisplayRecipes(List<Recipe> filteredRecipes)
        {//DisplayRecipes begin

            //Clear listbox
            lbxRecipes.Items.Clear();

            //if statement to validate if there are no recipes found 
            if (filteredRecipes.Count == 0)
            {//if there are no results for filter begin
                lbxRecipes.Items.Add("No recipes found.");
            }//if there are no results for filter end
            else
            {//else if there are no results for filter begin
                foreach (var recipe in filteredRecipes)
                {//for each to display all recipes in the recipe list begin
                    lbxRecipes.Items.Add($"{recipe.Name}\n{recipe.CalculateTotalCalories()} total calories");
                }//for each end
            }//else if there are no results for filter end
        }//DisplayRecipes end

        
       

        //Button to display components to get user input for the Ingredient Name Filter
        private void NameFilterBtn_Click(object sender, RoutedEventArgs e)
        {//NameFilterBtn begin
            HideAllFilterOptions();
            NameTxt.Visibility = Visibility.Visible;
            filter = 1;
        }//NameFilterBtn begin

        //Button to display components to get user input for the Max Calories of recipe Filter
        private void CaloriesFilterBtn_Click(object sender, RoutedEventArgs e)
        {//CaloriesFilterBtn begin
            HideAllFilterOptions();
            CaloriesTxt.Visibility = Visibility.Visible;
            filter = 3;
        }//CaloriesFilterBtn end
        

        private void FoodGroupFilterBtn_Click(object sender, RoutedEventArgs e)
        {//FoodGroupFilterBtn begin
            HideAllFilterOptions();
            cmbGroup.Visibility = Visibility.Visible;
            filter = 2;
        }//FoodGroupFilterBtn begin

        private void ApplyFilterBtn_Click(object sender, RoutedEventArgs e)
            {//ApplyFilterBtn begin
                lbxRecipes.Items.Clear();
                //use the filter value in a switch case to decide on what catergory  to filter the recipes
                switch (filter)
                {//switch begin
                    case 1:
                        string ingredientName = NameTxt.Text;
                        NameFilter(ingredientName);
                        break;
                    case 2:
                        int selectedIndex = cmbGroup.SelectedIndex;
                        if (selectedIndex >= 0)
                        {
                            FoodGroup selectedGroup = groups[selectedIndex];
                            GroupFilter(selectedGroup);
                        }
                        break;
                    case 3:
                        if (double.TryParse(CaloriesTxt.Text, out double maxCalories))
                        {
                            CalorieFilter(maxCalories);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number for calories.");
                        }
                        break;
                    default:
                        MessageBox.Show("Please select a filter criteria.");
                        break;
                }//switch end
            }//ApplyFilterBtn end

        private void ViewRecipeBtn_Click(object sender, RoutedEventArgs e)
        {//ViewRecipeButton begin
            int selectedIndex = lbxRecipes.SelectedIndex;

            // Check if there are any recipes in the ListBox
            if (lbxRecipes.Items.Count == 0 || (lbxRecipes.Items.Count > 0 && lbxRecipes.Items[0].ToString() == "No recipes found."))
            {//if no recipes found begin
                // Display a message if no recipes are found
                MessageBox.Show("No recipes found to view. Please apply a different filter or add recipes.");
                return;
            }//if no recipes found end

            //if statement to valid if the user selected a recipe to view
            if (selectedIndex >= 0)
            {//if begin
                // Get the selected recipe from the filtered list
                var selectedRecipe = filteredRecipes[selectedIndex];

                if (selectedRecipe != null)
                {
                    // Open ViewRecipeWindow and close the current window
                    var viewRecipeWindow = new ViewRecipe(selectedRecipe, manageRecipe);
                    viewRecipeWindow.Show();
                    this.Hide();
                }
                else
                {
                    // Display error message if the recipe is not found in the filtered list
                    MessageBox.Show("Selected recipe not found in the filtered list.");
                }
            }//if end
            else
            {//else begin
                //Display error message
                MessageBox.Show("Please select a recipe to view.");
            }//else end
        }//ViewRecipeButton end
    }//FilterWindow end
}//namespace ST10251759_PROG6221_POE end
