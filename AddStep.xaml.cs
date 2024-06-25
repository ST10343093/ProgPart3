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
    /// Interaction logic for AddStep.xaml
    /// </summary>
    public partial class AddStep : Window
    {//AddSteps Window Begin
        //Variable Declaration
        private Recipe recipe;
        private int numSteps;
        private int currentStepIndex = 0; //holds the current step number that the user is entering a description for
        ManageRecepie manageRecipe;

        //contructor that has parameters passing the current state of the casses as well as the number of steps the user wishes to enter
        public AddStep(Recipe recipe, int numSteps, ManageRecepie manageRecipe)
        {//AddSteps Constructor begin
            InitializeComponent();
            this.recipe = recipe;
            this.numSteps = numSteps;
            UpdateStepLabel(); //calls methods to update the label to let the user know which step number they are entering the description for
            this.manageRecipe = manageRecipe;
        }//AddSteps constructor end

        private void btnAddStep_Click(object sender, RoutedEventArgs e)
        {//btnAddStep begin

            //store the user entered input for the description
            string description = StepDescriptiontxt.Text;
            if (string.IsNullOrWhiteSpace(description))
            {//if validation for string input is null begin
                //Display error message to user
                MessageBox.Show("Step description cannot be empty.");
                return;
            }//if validation for string input is null end

            //if the input is valid pass as aparameter into step class and create instance of step object
            recipe.Steps.Add(new Step { Description = description });

            currentStepIndex++; //increment the step counter

            //if statment to validate either if the current step is successfully enter or if all steps are successfully  entered  
            if (currentStepIndex < numSteps)
            {//if current step is captured successfully begin
                //Display successwindow passing the message as a parameter
                var successWindow = new SuccessWindow("Step added successfully!");
                successWindow.Show();
                ResetFields(); //call method to reset the input text box
                UpdateStepLabel(); // call method to update the step number in the label so user knows which step they are entering description for 
            }//if current step is captured successfully end
            else
            {//else if all the steps are entered successful begin
                //Display successwindow passing the message as a parameter
                var successWindow = new SuccessWindow("All steps added successfully!");
                successWindow.Show();
                //close current window
                this.Close();

                //Display successwindow passing the message as a parameter
                var successWindow2 = new SuccessWindow("Recipe added successfully!");
                successWindow2.Show();

                //open the AllRecipe window passing the manageRecipel class as a parameter
                var mainMenu = new MainMenu(manageRecipe);
                mainMenu.Show();


            }//else if all the steps are entered successful end
        }//btnAddStep end

        //Method to reset the desciption textbox to get new user input
        private void ResetFields()
        {//ResetFields() begin
            StepDescriptiontxt.Text = "";
        }//ResetFields() end

        //Method to update the title to the step number to user is entering the description for
        private void UpdateStepLabel()
        {//UpdateStepLabel() begin
            AddStepLabel.Content = $"Add Step {currentStepIndex + 1} of {numSteps}";
        }//UpdateStepLabel() end
    }
}//AddSteps Window End