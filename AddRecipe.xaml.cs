using System;
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



                /*
            =============Code Attribution====================
            Author: Microsoft
            Website: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/overview/?view=netdesktop-8.0
            Date of Access: 24 June 2024

            Author: tutorialspoint
            Website: https://www.tutorialspoint.com/wpf/index.htm
            Date of Access: 24 June 2024     

            =============Code Attribution====================
            */

    /// <summary>
    /// Interaction logic for AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Window
    {//AddRecipe Window begin
        //Varaible declaration
        private ManageRecepie manageRecipes;

        //Constructor with parameter
        public AddRecipe(ManageRecepie manageRecipes)
        {//AddRecipe constructorpassing manage recipe variable as a paramether begin
            InitializeComponent();
            this.manageRecipes = manageRecipes;
        }//AddRecipe constructorpassing manage recipe variable as a paramether end

        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {//AddRecipe Button begin

            //Store the recipe name in a variable
            string recipeName = RecipeNameTextBox.Text;
            //Validation for if input is null
            if (string.IsNullOrEmpty(recipeName))
            {//if recipeName is null display error message begin
                MessageBox.Show("Recipe name cannot be empty.");
                return;
            }//if recipeName end

            //store the number of ingreints in varaible and then do validation id user did not enter a number
            if (!int.TryParse(NumIngredientstxt.Text, out int numIngredients) || numIngredients <= 0)
            {//if user did not enter a number then display error message begin
                MessageBox.Show("Please enter a valid number of ingredients.");
                return;
            }//if numIngredients is invlaid end

            //store the number of steps in a variable and do validation if the value is a valid number
            if (!int.TryParse(NumStepstxt.Text, out int numSteps) || numSteps <= 0)
            {//if user did not enter a number then display error message begin
                MessageBox.Show("Please enter a valid number of steps.");
                return;
            }//if numSteps is invlaid end

            // Create the recipe object and pass the name of recipem number of ingredients and number of steps to the recipe class
            Recipe recipe = new Recipe(recipeName, numIngredients, numSteps);
            //Create AddIngreientWindow object int=stance pass number of ingreinetns and the recipe and manage recipe class as parameters,  numIngreidents will be used to llop the window to get all the ingredients input from user
            var addIngredientsWindow = new AddIngredient(recipe, numIngredients, manageRecipes);
            //Open AddIngredientsWindow and close the current window
            addIngredientsWindow.Show();
            this.Close();

            //Add an instance of the recipe and pass this as a parameter to manage recipe class
            manageRecipes.AddRecipe(recipe);



            // Reset the fields for the next recipe
            RecipeNameTextBox.Clear();
            NumIngredientstxt.Clear();
            NumStepstxt.Clear();
        }//AddRecipe button end
    }//AddRecipe Window end
}//namespace end
