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
    /// <summary>
    /// Interaction logic for ViewRecipe.xaml
    /// </summary>
    public partial class ViewRecipe : Window
    {//ViewRecipe Window begin

        //Variable Declaration
        private Recipe currentRecipe;
        private ManageRecepie manageRecipe;

        //constructor with parameters for the current recipe and manageRecipe class
        public ViewRecipe(Recipe recipe, ManageRecepie manageRecipe)
        {//constructor begin
            InitializeComponent();
            this.currentRecipe = recipe;
            DisplayRecipeDetails(); //call method to display the recipe details in a richedit
            this.manageRecipe = manageRecipe;
        }//constructor end

        //Method to display the recipe dietails in the richedit
        private void DisplayRecipeDetails()
        {// DisplayRecipeDetails() begin
            //Display the recipe details in a richedit so that user can mark of the steps and ingredients they completed
            txtRecipeDetails.Document.Blocks.Clear(); //clear the richedit 
            txtRecipeDetails.AppendText(currentRecipe.DisplayRecipe()); //call the method from recipe class to display the recipe the user selected
        }// DisplayRecipeDetails() end

        private void ScalingRecipe_Click(object sender, RoutedEventArgs e)
        {//ScalingRecipeButton begin
            //Make the components visible
            lblScalingFactor.Visibility = Visibility.Visible;
            FactorComboBox.Visibility = Visibility.Visible;
            ProccedButton.Visibility = Visibility.Visible;
        }//ScalingRecipeButton end

        private void ResetRecipeButton_Click(object sender, RoutedEventArgs e)
        {//ResetRecipeButton  begin
            //call the resetRecipe method to return the recipe ingreients to the orginal values before scaling
            manageRecipe.ResetRecipe(currentRecipe);
            //clear richedit
            txtRecipeDetails.Document.Blocks.Clear();
            //display the reseted recipe
            txtRecipeDetails.AppendText(currentRecipe.DisplayRecipe());
        }//ResetRecipeButton  end

        private void ClearRecipeButton_Click(object sender, RoutedEventArgs e)
        {//ClearRecipeButton begin

            //Get user confirmation to delete the recipe
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this recipe?", "Delete Recipe", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            //if the result is yes then remove recipe
            if (result == MessageBoxResult.Yes)
            {//if begin
                //call the delete recipe method from manageRecipe class, removing the current recipe from the recipe list
                manageRecipe.DeleteRecipe(currentRecipe);
                //open the AllRecipes Menu by calling the method
                OpenAllRecipesWindow();
            }//if end
        }//ClearRecipeButton end

        //Method to open the AllRecipes Window
        private void OpenAllRecipesWindow()
        {//OpenAllRecipesWindow() begin
            //open the AllRecipes window and close the current window
            MainMenu allRecipesWindow = new MainMenu(manageRecipe);
            allRecipesWindow.Show();
            this.Close();
        }//OpenAllRecipesWindow() end

        private void ProccedButton_Click(object sender, RoutedEventArgs e)
        {//ProccedButton begin
            //if statement to validate the user selected a vlue to scale from the combobox
            if (FactorComboBox.SelectedItem != null)
            {//if begin

                //clear the richedit
                txtRecipeDetails.Document.Blocks.Clear();

                ComboBoxItem selectedItem = (ComboBoxItem)FactorComboBox.SelectedItem;
                double factor = Convert.ToDouble(selectedItem.Content); //store the user the selected value from the combobox alone
                manageRecipe.ScaleRecipe(currentRecipe, factor); //call the method to scale recipe in the manage recipe class
                txtRecipeDetails.AppendText(currentRecipe.DisplayRecipe()); //call the method to displat the scaled recipe in the rich edit

                //Hide the Scaling Components
                lblScalingFactor.Visibility = Visibility.Hidden;
                FactorComboBox.SelectedIndex = -1;
                FactorComboBox.Visibility = Visibility.Hidden;
                ProccedButton.Visibility = Visibility.Hidden;
            }//if end
            else
            {//else if the user didnt select a factor to scale
                //Display the error message
                MessageBox.Show("Please select a scaling factor.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }//ProccedButton end

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {//MainMenuButton begin
            //open the AllRecipe menu passing the current manageRecipe class as a parameter
            var AllRecipes = new MainMenu(manageRecipe);
            AllRecipes.Show();
            //close thi current window
            this.Close();
        }//MainMenuButton end


    }//ViewRecipe Window end
}
