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
    /// Interaction logic for AddIngredient.xaml
    /// </summary>
    public partial class AddIngredient : Window
        {//AddIngredients Window begin

            //Variable Declaration
            private Recipe recipe;
            ManageRecepie manageRecipe;

            List<UnitOfMeasurement> units = new List<UnitOfMeasurement>();
            // list to store units in enum
            List<FoodGroup> groups = new List<FoodGroup>();
            // list to store food groups in enum

            private int numIngredients;
            private int currentIngredientIndex = 0; //count which ingreient is used

            //Consructor with parameters
            public AddIngredient(Recipe recipe, int numIngredients, ManageRecepie manageRecipe)
            {///AddIngreients constructor with parameterized constructor begin
                InitializeComponent();
                this.recipe = recipe;
                this.numIngredients = numIngredients;
                UpdateIngredientLabel();
                PopulateComboBoxes(); //Call populate comboboxes method to initalise the values in the comboboxes
                this.manageRecipe = manageRecipe;

            }//AddIngreients constructor with parameterized constructor end

            //Method to populate the comboboxes on the opening of the AddIngredients form
            private void PopulateComboBoxes()
            {//PopulateComboBoxes() begin
             // add all enum values to units list
                units.Add(UnitOfMeasurement.SMALL);
                units.Add(UnitOfMeasurement.MEDIUM);
                units.Add(UnitOfMeasurement.LARGE);
                units.Add(UnitOfMeasurement.EXTRALARGE);
                units.Add(UnitOfMeasurement.TEASPOON);
                units.Add(UnitOfMeasurement.TEASPOONS);
                units.Add(UnitOfMeasurement.TABLESPOON);
                units.Add(UnitOfMeasurement.TABLESPOONS);
                units.Add(UnitOfMeasurement.CUP);
                units.Add(UnitOfMeasurement.CUPS);


                // add all enum values from the list to the correct combo box
                for (int i = 0; i < units.Count(); i++)
                {//for begin
                    unitComboBox.Items.Add(units[i]);
                }//for end

                // add all enum values to groups list
                groups.Add(FoodGroup.CARBOHYDRATE);
                groups.Add(FoodGroup.PROTEIN);
                groups.Add(FoodGroup.FAT);
                groups.Add(FoodGroup.FRUIT);
                groups.Add(FoodGroup.VEGETABLE);
                groups.Add(FoodGroup.DAIRY);

                // add all enum values from Food list to the correct combo box
                for (int i = 0; i < groups.Count(); i++)
                {//for begin
                    foodGroupComboBox.Items.Add(groups[i]);
                }//for end
            }// PopulateComboBoxes() nd
            private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
            {//btnAddIngredient begin
             //Store ingreient name in variable
                string name = IngredientNameTextBox.Text;
                //validate the string is not null with an if statement
                if (string.IsNullOrWhiteSpace(name))
                {//if name validation begin
                 //Display error message
                    MessageBox.Show("Ingredient name cannot be empty.");
                    return;
                }//if name validation end

                //Validate the Quantity is a valid number
                if (!double.TryParse(Quantitytxt.Text, out double quantity) || quantity <= 0)
                {//if quantity validation begin
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }//if quantity validation end

                //Validate the no Calories is a valid number
                if (!double.TryParse(NumCaloriestxt.Text, out double calories) || calories < 0)
                {//if Calories validation begin
                    MessageBox.Show("Please enter a valid number of calories.");
                    return;
                }//if Calories validation end

                //Validate the user select an item from the combobox for the unit
                if (!Enum.TryParse<UnitOfMeasurement>(unitComboBox.SelectedItem?.ToString(), out UnitOfMeasurement unit))
                {//if unit validation begin
                    MessageBox.Show("Please select a unit of measurement.");
                    return;
                }//if unir validation end

                //Validate the user select an item from the combobox for the Food Group
                if (!Enum.TryParse<FoodGroup>(foodGroupComboBox.SelectedItem?.ToString(), out FoodGroup group))
                {//if FoodGroup validation begin
                    MessageBox.Show("Please select a food group.");
                    return;
                }//if FoodGroup validation end

                //Pass the user input for ingredient details as parameters in the ingreient object
                recipe.Ingredients.Add(new Ingredient(name, quantity, unit, group, calories));

                currentIngredientIndex++; //increment the counter

                //Validation to alret user if they ingredient has been entered
                if (currentIngredientIndex < numIngredients)
                {//if they ingreient entered success begin
                 //open success winfow passing the message as a parameter
                    var successWindow = new SuccessWindow("Ingredient added successfully!");
                    successWindow.Show();
                    ResetFields();
                    UpdateIngredientLabel(); //call method to update which ingreient details is being entered
                }//if they ingreient entered success end
                else
                {//else if all ingredients had=ve been entered alret user
                    var successWindow = new SuccessWindow("All ingredients added successfully!");
                    successWindow.Show();

                    //close ingreient window
                    this.Close();

                    // Open the AddSteps window
                    var addStepsWindow = new AddStep(recipe, recipe.NumSteps, manageRecipe);
                    addStepsWindow.Show();
                }//else end

                //Call method Calulate the totalCalories of all ingrredients for recipe
                recipe.CalculateTotalCalories();

            }//btnAddIngredient end

            //Method to reset fields to enter the next ingreient details
            private void ResetFields()
            {//ResetFields begin
                IngredientNameTextBox.Clear();
                Quantitytxt.Clear();
                NumCaloriestxt.Clear();
                unitComboBox.SelectedIndex = -1;
                foodGroupComboBox.SelectedIndex = -1;
            }//ResetFields end

            //method to update label with the ingreient that the user is currrently entering the details for
            private void UpdateIngredientLabel()
            {//UpdateIngreientslabel begin
                AddIngredientLabel.Content = $"Add Ingredient {currentIngredientIndex + 1} of {numIngredients}";
            }//UpdateIngreientlable end

        }//AddIngredients Window end
    }// namespace ST10251759_PROG6221_POE end