using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace ProgPart3
{//namespace begin
    //Manage Recipe Class to manage instances of my recipes
    public class ManageRecepie
    {
        //Variable Declaration
        public List<Recipe> Recipes { get; private set; }

        //Constructor
        public ManageRecepie()
        {
            Recipes = new List<Recipe>();
        }

        //AddRecipe class with parameter of recipe list --add recipe instance
        public void AddRecipe(Recipe recipe)
        {
            Recipes.Add(recipe);
        }
        //method to display all recipes in a list box
        public void DisplayAllRecipes(ListBox recipeListBox)
        {
            recipeListBox.Items.Clear();
            var sortedRecipes = Recipes.OrderBy(r => r.Name).ToList();

            foreach (var recipe in sortedRecipes)
            {
                recipeListBox.Items.Add(recipe.Name);
            }
        }

        //Method to display individual 
        public void DisplayRecipeDetails(Recipe recipe, TextBlock recipeDetailsTextBlock)
        {
            recipeDetailsTextBlock.Text = recipe.DisplayRecipe();
        }

        //Method to scale Recipe 
        public void ScaleRecipe(Recipe recipe, double factor)
        {
            recipe.ScaleRecipe(factor);
        }

        //method to reset a recipe to its orginal 
        public void ResetRecipe(Recipe recipe)
        {
            recipe.ResetRecipe();
        }

        //Delete recipes from the list
        public void DeleteRecipe(Recipe recipe)
        {
            if (Recipes.Contains(recipe))
            {
                Recipes.Remove(recipe);
                MessageBox.Show($"Recipe '{recipe.Name}' has been deleted.", "Delete Recipe", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Recipe '{recipe.Name}' not found.", "Delete Recipe", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}//namespace end